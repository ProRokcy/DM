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
    /// Логика взаимодействия для MainClientPage.xaml
    /// </summary>
    public partial class MainClientPage : Page
    {
        void Updata()
        {
            MyDataGrid.ItemsSource = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId).ToList();
            var sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId).ToList();

            if (CmbStatus.SelectedIndex == 0)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId).ToList();
            }
            else if (CmbStatus.SelectedIndex == 1)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId
                && x.IdStatusApplication == 1).ToList();
            }
            else if (CmbStatus.SelectedIndex == 2)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId
                && x.IdStatusApplication == 2).ToList();
            }
            else if (CmbStatus.SelectedIndex == 3)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdClient == UserControlClasess.UserId
                && x.IdStatusApplication == 3).ToList();
            }

            sort = sort.Where(x => x.Description.Contains(TxbSerch.Text) &&
            x.IdClient == UserControlClasess.UserId).ToList();
            MyDataGrid.ItemsSource = sort.ToList();
        }

        public MainClientPage()
        {
            InitializeComponent();
            Updata();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            dynamic k = (sender as Button).DataContext;
            FrameApp.frmObj.Navigate(new EditApplicationPage(k));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AddApplicationPage());
        }

        private void TxbSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Updata();
        }
        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Updata();
        }
    }
}
