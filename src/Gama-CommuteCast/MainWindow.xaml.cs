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
using System.IO.Ports;


namespace Gama_CommuteCast
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MapBtn_Click(object sender, RoutedEventArgs e)
        {
            /* Navigate to MapViewer.xaml */
            MainFrame.Navigate(new MapViewer());
        }

        private void AirPollutionBtn_Click(object sender, RoutedEventArgs e)
        {
            /* Navigate to AirPollutionViewer.xaml */
            MainFrame.Navigate(new AirPollutionViewer());
        }

        private void WeatherBtn_Click(object sender, RoutedEventArgs e)
        {
            /* Navigate to WeatherViewer.xaml */
            MainFrame.Navigate(new WeatherViewer());
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            /* Navigate to UserViewer.xaml */
            /*MainFrame.Navigate(new UserViewer());*/
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Change window to login window
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
