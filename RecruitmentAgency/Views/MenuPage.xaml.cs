using RecruitmentAgency.Model;
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

namespace RecruitmentAgency.Views
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public static Work work { get; set; }
        User user = new User();
        public MenuPage(User cUser, Work cWork)
        {
            InitializeComponent();
            user = cUser;
            work = cWork;
            this.DataContext = this;
        }

        private void UserListBtn_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new UserListPage(user));
          
        }

        private void WorkListBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainViewPage(new Work(), user));

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (user.RoleID != 2)
            {
                UserListBtn.Visibility = Visibility.Visible;
            }
            else if (user.RoleID == 2)
            {
                UserListBtn.Visibility = Visibility.Collapsed;
            }
        }
    }
}
