using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RollCounter
{
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(2);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(3);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(4);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(5);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(6);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(7);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(8);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(9);
        }

        private void Ten_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(10);
        }

        private void Eleven_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(11);
        }

        private void Twelve_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.AddRoll(12);
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.UndoRoll();
        }
    }
}