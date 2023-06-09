﻿using HarchenkoSchool.ViewModel;
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
using System.Windows.Shapes;

namespace HarchenkoSchool.View
{
    /// <summary>
    /// Логика взаимодействия для FoodWindow.xaml
    /// </summary>
    public partial class FoodWindow : Window
    {
        public FoodWindow()
        {
            InitializeComponent();
            this.DataContext = new AppVM();
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            var AddWindowsFood = new FoodChangeWindow(null);
            AddWindowsFood.Show();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
