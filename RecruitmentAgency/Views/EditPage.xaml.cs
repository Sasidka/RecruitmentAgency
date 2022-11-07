using Microsoft.Win32;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public static Work user { get; set; }
        public OpenFileDialog file = new OpenFileDialog();
        public EditPage(Work cWork)
        {
            InitializeComponent();
            user = cWork;
            this.DataContext = this;
        }

        private void SaveImageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (file.ShowDialog() == true)
                {
                    ProductImage.Source = new BitmapImage(new Uri(file.FileName));
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!", "Упсм", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user.Code== 0)
            {
                user.image= file.FileName;
                AppData.db.Work.Add(user);
                AppData.db.SaveChanges();
                MessageBox.Show("Данные были успешно добавлены!");
                NavigationService.GoBack();
            }
            else if (user.Code != 0)
            {
                user.image = file.FileName;
                AppData.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (user.Code == 0)
            {
                addBtn.Content = "Добавить";
            }
            else
            {
                addBtn.Content = "Редактировать";
            }
        }
    }
}
