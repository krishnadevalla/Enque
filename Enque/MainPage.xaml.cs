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
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
          InitializeComponent();
        }

        private void cont_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/info.xaml",UriKind.RelativeOrAbsolute));
        }

       


    }
}