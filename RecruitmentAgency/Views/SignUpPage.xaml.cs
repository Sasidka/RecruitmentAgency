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
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public static User user { get; set; }
        public SignUpPage(User cUser)
        {
            InitializeComponent();
            user = cUser;
            this.DataContext = this;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (PasswordTb.Text.Length < 4)
                {
                    throw new Exception("Пароль должен содержать не менее 4-х символов");
                }
                else 
                {
                    var currentLogin = AppData.db.User.FirstOrDefault(x => x.Login == LoginTb.Text);
                    if (currentLogin != null)
                    {
                        MessageBox.Show("Логин занят");
                    }
                    else
                    {
                        user.RoleID = 2;
                        AppData.db.User.Add(user);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Вы успешно зарегестрировались!");
                        NavigationService.GoBack();
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ReturnPasswordTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ReturnPasswordTb.Text != PasswordTb.Text)
            {
                PasswordTb.Background = Brushes.Red;
                ReturnPasswordTb.Background = Brushes.Red;
                addBtn.IsEnabled = false;
            }
            else
            {
                PasswordTb.Background = Brushes.Green;
                ReturnPasswordTb.Background = Brushes.Green;
                addBtn.IsEnabled = true;
            }
        }

       
    }
}
