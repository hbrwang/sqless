﻿using System.Windows.Controls;

namespace Demo.Sqless.Wpf.View
{
    public partial class Products : Page
    {
        public Products()
        {
            InitializeComponent();

            VM.Init();
        }

        private void Order_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Orders());
        }
    }
}
