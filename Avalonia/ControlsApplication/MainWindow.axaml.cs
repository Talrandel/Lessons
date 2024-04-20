using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

using System;
using System.Collections.Generic;

namespace ControlsApplication
{
    public partial class MainWindow : Window
    {
        Random Random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            //ListBox_One.ItemsSource = new List<string> { "Item one", "Item two", "Item three", "Item four", "Item five", };
            //ComboBox_One.ItemsSource = new List<string> { "Item one", "Item two", "Item three", "Item four", "Item five", };
            //ComboBox_One.SelectedIndex = 0;
            //ListBox_One.SelectedIndex = 0;

        }

        public void Button11_Click(object sender, RoutedEventArgs e)
        {
            if (Random.Next(0, 2) > 0)
            {
                Button11.Background = Brushes.Red;
            }
            else
            {
                Button11.Background = Brushes.Blue;
            }
        }
    }
}