﻿using RecruitmentAgency.Classes;
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
    /// Логика взаимодействия для MoreUserInfoPage.xaml
    /// </summary>
    public partial class MoreUserInfoPage : Page
    {
        public static User user {get;set;}
        public MoreUserInfoPage(User getUser)
        {
            InitializeComponent();
            user = getUser;
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user.ID == 0)
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
            }
            else if (user.ID != 0)
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }

        }
    }
}