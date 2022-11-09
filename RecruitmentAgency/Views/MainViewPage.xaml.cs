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
    /// Логика взаимодействия для MainViewPage.xaml
    /// </summary>
    public partial class MainViewPage : Page
    {
        public static Work work { get; set; }
        public User user = new User();
        public MainViewPage(Work getWork, User getUser)
        {
            InitializeComponent();
            work = getWork;
            user = getUser;
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void filtrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentFiltr = filtrCmb.SelectedItem as Work;
            if (currentFiltr != null)
            {
                listView.ItemsSource = AppData.db.Work.Where(item => item.Title == currentFiltr.Title).ToList();
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(new Work()));

            listView.ItemsSource = AppData.db.Work.ToList();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listView.SelectedItems != null)
                {
                    NavigationService.Navigate(new EditPage(listView.SelectedItem as Work));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + " ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            listView.ItemsSource = AppData.db.Work.ToList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 
                Work deleteCheck = (Work)listView.SelectedItem;

                if (deleteCheck == null)
                {
                    MessageBox.Show("Вы не выбрали товар", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);


                }
                else if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент? Данные будут удалены навсегда", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (deleteCheck != null)
                    {
                        AppData.db.Work.Remove(deleteCheck);
                        AppData.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                    else
                    {
                        throw new Exception("Для удаления выберите элемент из списка");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

           
        }

        private void clear_cmb_Click(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = AppData.db.Work.ToList();
            filtrCmb.ItemsSource = null;
            filtrCmb.ItemsSource = AppData.db.Work.ToList();
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = AppData.db.Work.Where(item => item.Title.Contains(searchTxb.Text) || item.Profession.Contains(searchTxb.Text)
            || item.Salary.Contains(searchTxb.Text) || item.WorkExperience.Title.Contains(searchTxb.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
                listView.ItemsSource = AppData.db.Work.ToList();
            filtrCmb.ItemsSource = AppData.db.Work.ToList();
            if (user.RoleID == 2)
            {
                AdminPanel.Visibility = Visibility.Collapsed;
            }
        }

        
    }
}
