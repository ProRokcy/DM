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
using ITService.Classes;
using ITService.Pages.ClientPages;

namespace ITService.Pages.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для AddApplicationPage.xaml
    /// </summary>
    public partial class AddApplicationPage : Page
    {
        public AddApplicationPage()
        {
            InitializeComponent();
        }

        private void AddAppBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbDescript.Text == null ||
                    TxbDevice.Text == null ||
                    TxbModelDevice.Text == null)
                {
                    MessageBox.Show("Не все поля заполнены",
                      "Умедовление",
                     MessageBoxButton.OK,
                     MessageBoxImage.Information);
                }
                else
                {
                    Applications application = new Applications()
                    {
                        IdClient = UserControlClasess.UserId,
                        Device = TxbDevice.Text,
                        ModelDevice = TxbModelDevice.Text,
                        Description = TxbDescript.Text,
                        IdStatusApplication = 1,
                        StartData = DateTime.Now
                    };
                    OdbConnectHelper.entObj.Applications.Add(application);
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Добавлено",
                    "Умедовление",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
                    FrameApp.frmObj.Navigate(new MainClientPage());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, 
                    "Ошибка",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
