﻿using System;
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

namespace TestIndiviProject
{
    /// <summary>
    /// Логика взаимодействия для AddTextBlock.xaml
    /// </summary>
    public partial class AddTextBlock : Window
    {
        public AddTextBlock()
        {
            InitializeComponent();
        }
        

        private void AddTextBlock_Click(object sender, RoutedEventArgs e)
        {
            Car newCar = new Car(int.Parse(speedTB.Text), nameTB.Text);
            MainWindow.mainWindow.AddCar(newCar);
            this.Close();
        }
    }
}
