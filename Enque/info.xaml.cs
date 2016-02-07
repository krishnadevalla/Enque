using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace Enque
{
    public partial class info : PhoneApplicationPage
    {
        
        public info()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            wait.Begin();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        	 NavigationService.Navigate(new Uri("/instructions.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}