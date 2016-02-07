using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Enque
{
    public partial class instructions : PhoneApplicationPage
    {
        public instructions()
        {
            InitializeComponent();
        }

        private void abou_Click(object sender, RoutedEventArgs e)
        {
            insttext.Visibility = Visibility.Collapsed;
            showgrid.Visibility = Visibility.Visible;
            abouttext.Visibility = Visibility.Visible;
        }

        private void inst_Click(object sender, RoutedEventArgs e)
        {
            abouttext.Visibility = Visibility.Collapsed;
            showgrid.Visibility = Visibility.Visible;
            insttext.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}