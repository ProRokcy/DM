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

namespace ITService.Pages.OperatorPages
{
    /// <summary>
    /// Логика взаимодействия для RegApplicationPage.xaml
    /// </summary>
    public partial class RegApplicationPage : Page
    {
        int Idt;
        public RegApplicationPage(Applications applications)
        {
            InitializeComponent();
            Idt = applications.Id;
            CmbEmployee.ItemsSource = OdbConnectHelper.entObj.Users.Where(x => x.IdRole == 3).ToList();
            CmbEmployee.SelectedValuePath = "Id";
            CmbEmployee.DisplayMemberPath = "FIO";

            CmbPriority.ItemsSource = OdbConnectHelper.entObj.Priority.ToList();
            CmbPriority.SelectedValuePath = "Id";
            CmbPriority.DisplayMemberPath = "Title";
        }

        private void DelAppBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                    var delApplication = OdbConnectHelper.entObj.Applications.FirstOrDefault(a => a.Id == Idt);
                    if (delApplication != null)
                    {
                        var result = MessageBox.Show("удалить",
                        "Умедовление",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Information);
                        if (result == MessageBoxResult.Yes)
                        {
                            OdbConnectHelper.entObj.Applications.Remove(delApplication);
                            OdbConnectHelper.entObj.SaveChanges();
                            FrameApp.frmObj.Navigate(new MainOperatorPage());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены",
                    "Умедовление",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
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

        private void EditAppBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CmbEmployee.SelectedValue == null ||
                    CmbPriority.SelectedValue == null)
                {
                    MessageBox.Show("Не все поля заполнены",
                      "Умедовление",
                     MessageBoxButton.OK,
                     MessageBoxImage.Information);
                }
                else
                {
                    var editApplication = OdbConnectHelper.entObj.Applications.FirstOrDefault(a => a.Id == Idt);
                    if (editApplication != null)
                    {
                        editApplication.IdStatusApplication = 2;

                        OdbConnectHelper.entObj.SaveChanges();
                        Order order = new Order()
                        {
                            IdApplication = editApplication.Id,
                            IdPriority = Convert.ToInt32(CmbPriority.SelectedValue),
                            IdEmploye = Convert.ToInt32(CmbEmployee.SelectedValue),
                            StartDate = DateTime.Now,
                        };
                        OdbConnectHelper.entObj.Order.Add(order);
                        OdbConnectHelper.entObj.SaveChanges();
                        MessageBox.Show("Зарегистрировано",
                        "Умедовление",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);
                        FrameApp.frmObj.Navigate(new MainOperatorPage());
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены",
                    "Умедовление",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
                    }
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

        private void CmbEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
