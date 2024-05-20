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

namespace ITService.Pages.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для EditApplicationPage.xaml
    /// </summary>
    public partial class EditApplicationPage : Page
    {
        int Idt;
        public EditApplicationPage(Applications application)
        {
            InitializeComponent();
            Idt = application.Id;
            TxbDescript.Text = application.Description;
            TxbDevice.Text = application.Device;
            TxbModelDevice.Text = application.ModelDevice;
        }

        private void EditAppBtn_Click(object sender, RoutedEventArgs e)
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
                    var editApplication = OdbConnectHelper.entObj.Applications.FirstOrDefault(a => a.Id == Idt);
                    if (editApplication != null)
                    {
                        editApplication.Description = TxbDescript.Text;
                        editApplication.Device = TxbDevice.Text;
                        editApplication.ModelDevice = TxbModelDevice.Text;
                   
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Изменено",
                    "Умедовление",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
                    FrameApp.frmObj.Navigate(new MainClientPage());
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

        private void DelAppBtn_Click(object sender, RoutedEventArgs e)
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
                            FrameApp.frmObj.Navigate(new MainClientPage());
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
