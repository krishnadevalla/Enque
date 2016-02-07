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
using System.Windows.Threading;

namespace Enque
{
    public partial class Page2 : PhoneApplicationPage
    {
        private DispatcherTimer _tick = new DispatcherTimer();
        Queue<int> qe = new Queue<int>(50);
        Stack<int> myQ = new Stack<int>(50);
        int textnum;
        int score = 0;
        int remaintime=100;
        int clickcount = 0;
        public Page2()
        {
            
            InitializeComponent();
        }
        private void quebuff()
        {
            myQ.Clear();

            for (int q = 50; q > 0; q--)
            {
                myQ.Push(q);
            }
        }
        private bool checkfun(string txt)
        {
            textnum = myQ.Pop();
            if (txt == textnum.ToString())
            {
                clickcount++;
                easymediatap.Play();
                score += 10;
                lasthit.Text = txt;
                lasthit1.Text = txt;
                dispscore.Text = score.ToString();
                if (clickcount == 50)
                {
                    _tick.Stop();
                    scorefall.Begin();
                }
                return true;

            }
            else
            {
                errormedia.Play();
                myQ.Push(textnum);
                score -= 5;
                dispscore.Text = score.ToString();
                return false;
            }
        }



        private void _1_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_1.Text))
            {
                _1.Opacity = 0.3;
            }


        }
        private void _2_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_2.Text))
            {
                _2.Opacity = 0.3;
            }
        }

        private void _3_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_3.Text))
            {
                _3.Opacity = 0.3;
            }
        }

        private void _4_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_4.Text))
            {
                _4.Opacity = 0.3;
            }
        }

        private void _5_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_5.Text))
            {
                _5.Opacity = 0.3;
            }
        }

        private void _6_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_6.Text))
            {
                _6.Opacity = 0.3;
            }
        }

        private void _7_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_7.Text))
            {
                _7.Opacity = 0.3;
            }
        }

        private void _8_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_8.Text))
            {
                _8.Opacity = 0.3;
            }
        }

        private void _9_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_9.Text))
            {
                _9.Opacity = 0.3;
            }
        }

        private void _10_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_10.Text))
            {
                _10.Opacity = 0.3;
            }
        }

        private void _11_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_11.Text))
            {
                _11.Opacity = 0.3;
            }
        }

        private void _12_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_12.Text))
            {
                _12.Opacity = 0.3;
            }
        }

        private void _13_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_13.Text))
            {
                _13.Opacity = 0.3;
            }
        }

        private void _14_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_14.Text))
            {
                _14.Opacity = 0.3;
            }
        }

        private void _15_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_15.Text))
            {
                _15.Opacity = 0.3;
            }
        }

        private void _16_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_16.Text))
            {
                _16.Opacity = 0.3;
            }
        }

        private void _17_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_17.Text))
            {
                _17.Opacity = 0.3;
            }
        }

        private void _18_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_18.Text))
            {
                _18.Opacity = 0.3;
            }
        }

        private void _19_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_19.Text))
            {
                _19.Opacity = 0.3;
            }
        }

        private void _20_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_20.Text))
            {
                _20.Opacity = 0.3;
            }
        }

        private void _21_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_21.Text))
            {
                _21.Opacity = 0.3;
            }
        }

        private void _22_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_22.Text))
            {
                _22.Opacity = 0.3;
            }
        }

        private void _23_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_23.Text))
            {
                _23.Opacity = 0.3;
            }
        }

        private void _24_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_24.Text))
            {
                _24.Opacity = 0.3;
            }
        }

        private void _25_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_25.Text))
            {
                _25.Opacity = 0.3;
            }
        }

        private void _26_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_26.Text))
            {
                _26.Opacity = 0.3;
            }
        }

        private void _27_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_27.Text))
            {
                _27.Opacity = 0.3;
            }
        }

        private void _28_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_28.Text))
            {
                _28.Opacity = 0.3;
            }
        }

        private void _29_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_29.Text))
            {
                _29.Opacity = 0.3;
            }
        }

        private void _30_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_30.Text))
            {
                _30.Opacity = 0.3;
            }
        }

        private void _31_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_31.Text))
            {
                _31.Opacity = 0.3;
            }
        }

        private void _32_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_32.Text))
            {
                _32.Opacity = 0.3;
            }
        }

        private void _33_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_33.Text))
            {
                _33.Opacity = 0.3;
            }
        }

        private void _34_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_34.Text))
            {
                _34.Opacity = 0.3;
            }
        }

        private void _35_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_35.Text))
            {
                _35.Opacity = 0.3;
            }
        }

        private void _36_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_36.Text))
            {
                _36.Opacity = 0.3;
            }
        }

        private void _37_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_37.Text))
            {
                _37.Opacity = 0.3;
            }
        }

        private void _38_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_38.Text))
            {
                _38.Opacity = 0.3;
            }
        }

        private void _39_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_39.Text))
            {
                _39.Opacity = 0.3;
            }
        }

        private void _40_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_40.Text))
            {
                _40.Opacity = 0.3;
            }
        }

        private void _41_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_41.Text))
            {
                _41.Opacity = 0.3;
            }
        }

        private void _42_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_42.Text))
            {
                _42.Opacity = 0.3;
            }
        }

        private void _43_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_43.Text))
            {
                _43.Opacity = 0.3;
            }
        }

        private void _44_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_44.Text))
            {
                _44.Opacity = 0.3;
            }
        }

        private void _45_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_45.Text))
            {
                _45.Opacity = 0.3;
            }
        }

        private void _46_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_46.Text))
            {
                _46.Opacity = 0.3;
            }
        }

        private void _47_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_47.Text))
            {
                _47.Opacity = 0.3;
            }
        }

        private void _48_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_48.Text))
            {
                _48.Opacity = 0.3;
            }
        }

        private void _49_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_49.Text))
            {
                _49.Opacity = 0.3;
            }
        }

        private void _50_Tap(object sender, GestureEventArgs e)
        {
            if (checkfun(_50.Text))
            {
                _50.Opacity = 0.3;
            }
        }


        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start the play");
            settext();
            quebuff();
            ticktime();
        }

        private void ticktime()
        {
            _tick = new DispatcherTimer();
         
            _tick.Interval = new TimeSpan(0, 0, 0, 1, 0);

            _tick.Tick += _tick_Tick;
         
            _tick.Start();
         
        }

        void _tick_Tick(object sender, EventArgs e)
        {
            SolidColorBrush scb1 = new SolidColorBrush(Colors.Red);
            SolidColorBrush scb2 = new SolidColorBrush(Colors.Blue);
            finalscore.Text = score.ToString();
            time.Text = remaintime.ToString();
            remaintime--;
            if (remaintime < 15)
            {
                if (remaintime%2==0)
                {
                    time.Foreground = scb1;

                }
                else
                {
                    time.Foreground = scb2;
                }
            }
            if (remaintime == 0)
            {
                _tick.Stop();
                scorefall.Begin();
            }
        }

        private void settext()
        {
            int index = 0, i = 0;
            qe.Clear();
            Random rm = new Random();
            do
            {
                i = rm.Next(50) + 1;
                if (!qe.Contains(i))
                {
                    qe.Enqueue(i);
                    index++;
                }
            } while (index < 50);

            _1.Text = qe.Dequeue().ToString();

            _2.Text = qe.Dequeue().ToString();

            _3.Text = qe.Dequeue().ToString();

            _4.Text = qe.Dequeue().ToString();

            _5.Text = qe.Dequeue().ToString();

            _6.Text = qe.Dequeue().ToString();

            _7.Text = qe.Dequeue().ToString();

            _8.Text = qe.Dequeue().ToString();

            _9.Text = qe.Dequeue().ToString();

            _10.Text = qe.Dequeue().ToString();

            _11.Text = qe.Dequeue().ToString();

            _12.Text = qe.Dequeue().ToString();

            _13.Text = qe.Dequeue().ToString();

            _14.Text = qe.Dequeue().ToString();

            _15.Text = qe.Dequeue().ToString();

            _16.Text = qe.Dequeue().ToString();

            _17.Text = qe.Dequeue().ToString();

            _18.Text = qe.Dequeue().ToString();

            _19.Text = qe.Dequeue().ToString();

            _20.Text = qe.Dequeue().ToString();

            _21.Text = qe.Dequeue().ToString();

            _22.Text = qe.Dequeue().ToString();

            _23.Text = qe.Dequeue().ToString();

            _24.Text = qe.Dequeue().ToString();

            _25.Text = qe.Dequeue().ToString();

            _26.Text = qe.Dequeue().ToString();

            _27.Text = qe.Dequeue().ToString();

            _28.Text = qe.Dequeue().ToString();

            _29.Text = qe.Dequeue().ToString();

            _30.Text = qe.Dequeue().ToString();

            _31.Text = qe.Dequeue().ToString();

            _32.Text = qe.Dequeue().ToString();

            _33.Text = qe.Dequeue().ToString();
            _34.Text = qe.Dequeue().ToString();
            _35.Text = qe.Dequeue().ToString();

            _36.Text = qe.Dequeue().ToString();

            _37.Text = qe.Dequeue().ToString();

            _38.Text = qe.Dequeue().ToString();

            _39.Text = qe.Dequeue().ToString();

            _40.Text = qe.Dequeue().ToString();

            _41.Text = qe.Dequeue().ToString();

            _42.Text = qe.Dequeue().ToString();

            _43.Text = qe.Dequeue().ToString();

            _44.Text = qe.Dequeue().ToString();

            _45.Text = qe.Dequeue().ToString();

            _46.Text = qe.Dequeue().ToString();

            _47.Text = qe.Dequeue().ToString();

            _48.Text = qe.Dequeue().ToString();

            _49.Text = qe.Dequeue().ToString();

            _50.Text = qe.Dequeue().ToString();
        }

        private void reloadtext_Tap(object sender, GestureEventArgs e)
        {
            MessageBoxResult mbr=MessageBox.Show("Reload Game :(", "Alert",MessageBoxButton.OKCancel);
            if (mbr.Equals(MessageBoxResult.OK))
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            }
            
        }
        
    }
}