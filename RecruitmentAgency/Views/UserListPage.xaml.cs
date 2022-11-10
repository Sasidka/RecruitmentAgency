using RecruitmentAgency.Classes;
using RecruitmentAgency.Model;
using System;
using System.Collections;
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
    /// Логика взаимодействия для UserListPage.xaml
    /// </summary>
    public partial class UserListPage : Page
    {
       
        public static User user { get; set; }
        public UserListPage(User getUser)
        {
            InitializeComponent();
            user = getUser;
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsersPanel.ItemsSource = AppData.db.WorkUser.ToList();
        }

        private void MoreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (UsersPanel.SelectedItem != null)
                {
                    NavigationService.Navigate(new MoreUserInfoPage(UsersPanel.SelectedItem as WorkUser));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = UsersPanel.SelectedItem as WorkUser;

            CurrentUser.IsAccepted = true;
            AppData.db.SaveChanges();
            MessageBox.Show("пользователь принят на работу");
            UsersPanel.ItemsSource = AppData.db.WorkUser.Where(x => x.IsAccepted != true).ToList();
        }

    }
}
