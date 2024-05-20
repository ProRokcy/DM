using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ITService.Pages.ClientPages;
using ITService.Classes;
using ITService.Pages.Emp_loyeesPages;
using ITService.Pages.OperatorPages;

namespace ITService.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbLogin.Text == null ||
                    PsbBox.Password == null)
                {
                    MessageBox.Show("Не все поля заполнены",
                                       "Умедовление",
                                       MessageBoxButton.OK,
                                       MessageBoxImage.Information);
                }
                else
                {
                    var user = OdbConnectHelper.entObj.Users.FirstOrDefault(x => x.Login == TxbLogin.Text &&
                    x.Password == PsbBox.Password);
                    if (user == null)
                    {
                        MessageBox.Show("Неверный логин или пароль",
                                        "Умедовление",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Information);
                    }
                    else
                    {
                        UserControlClasess.UserId =  user.Id;

                        switch (user.IdRole)
                        {
                            case 1:
                                FrameApp.frmObj.Navigate(new MainClientPage());
                                break;
                            case 2:
                                FrameApp.frmObj.Navigate(new MainOperatorPage());
                                break;
                            case 3:
                                FrameApp.frmObj.Navigate(new MainEmployeesPage());
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message,
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
