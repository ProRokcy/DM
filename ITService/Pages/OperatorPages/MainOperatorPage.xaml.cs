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
    /// Логика взаимодействия для MainOperatorPage.xaml
    /// </summary>
    public partial class MainOperatorPage : Page
    {
        void Updata()
        {
            MyDataGrid.ItemsSource = OdbConnectHelper.entObj.Applications.ToList();
            var sort = OdbConnectHelper.entObj.Applications.ToList();

            if (CmbStatus.SelectedIndex == 0)
            {
                sort = OdbConnectHelper.entObj.Applications.ToList();
            }
            else if (CmbStatus.SelectedIndex == 1)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x =>  x.IdStatusApplication == 1).ToList();
            }
            else if (CmbStatus.SelectedIndex == 2)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdStatusApplication == 2).ToList();
            }
            else if (CmbStatus.SelectedIndex == 3)
            {
                sort = OdbConnectHelper.entObj.Applications.Where(x => x.IdStatusApplication == 3).ToList();
            }

            sort = sort.Where(x => x.Description.Contains(TxbSerch.Text)).ToList();
            MyDataGrid.ItemsSource = sort.ToList();
        }
        public MainOperatorPage()
        {
            InitializeComponent();
            Updata();
        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Updata();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            dynamic k = (sender as Button).DataContext;
            FrameApp.frmObj.Navigate(new RegApplicationPage(k));
        }

        private void TxbSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Updata();
        }
    }
}
