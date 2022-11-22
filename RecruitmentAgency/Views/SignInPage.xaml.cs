using RecruitmentAgency.Classes;
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
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public static Work cwork { get; set; }
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage(new User()));
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var dataUser = AppData.db.User.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Password);

            if (dataUser != null)
            {
                switch (dataUser.RoleID)
                {
                    case 2:
                        NavigationService.Navigate(new MainViewPage(cwork, dataUser));
                        break;
                    case 1:
                        NavigationService.Navigate(new MenuPage(dataUser, cwork));
                        break;
                }
            }
        }
    }
}
