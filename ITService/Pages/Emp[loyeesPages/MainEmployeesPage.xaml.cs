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

namespace ITService.Pages.Emp_loyeesPages
{
    /// <summary>
    /// Логика взаимодействия для MainEmployeesPage.xaml
    /// </summary>
    public partial class MainEmployeesPage : Page
    {
        void Updata()
        {
            MyDataGrid.ItemsSource = OdbConnectHelper.entObj.Order.ToList();
            var sort = OdbConnectHelper.entObj.Order.ToList();

            if (CmbStatus.SelectedIndex == 0)
            {
                sort = OdbConnectHelper.entObj.Order.Where(x =>x.IdEmploye == UserControlClasess.UserId).ToList();
            }
            else if (CmbStatus.SelectedIndex == 1)
            {
                sort = OdbConnectHelper.entObj.Order.Where(x => x.IdEmploye == UserControlClasess.UserId
                && x.IdPriority == 1).ToList();
            }
            else if (CmbStatus.SelectedIndex == 2)
            {
                sort = OdbConnectHelper.entObj.Order.Where(x => x.IdEmploye == UserControlClasess.UserId
                && x.IdPriority == 2).ToList();
            }
            else if (CmbStatus.SelectedIndex == 3)
            {
                sort = OdbConnectHelper.entObj.Order.Where(x => x.IdEmploye == UserControlClasess.UserId
                && x.IdPriority == 3).ToList();
            }

            sort = sort.Where(x => x.Applications.Description.Contains(TxbSerch.Text)).ToList();
            MyDataGrid.ItemsSource = sort.ToList();
        }
        public MainEmployeesPage()
        {
            InitializeComponent();
            Updata();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

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
