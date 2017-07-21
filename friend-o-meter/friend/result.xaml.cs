using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace friend
{
    public partial class result : PhoneApplicationPage
    {
        
        int i, j, ch;
        Random r = new Random();
        public result()
        {
            InitializeComponent();
            this.Loaded += result_Loaded;
        }

        void result_Loaded(object sender, RoutedEventArgs e)
        {
            int[] A = new int[] { 93, 86, 82, 92, 68, 89, 79, 88, 98, 100, 79, 94, 99, 90, 76 };
            i = r.Next(15);
            tb1.Text = A[i].ToString();
            Storyboard1.Begin();           
            qt();
        }
        void qt()
        {
            int[] B = new int[] { 1, 2, 3, 4, 5, 6 };
            j = r.Next(5);
            ch = B[j];

            if (ch == 1)
            {
                tbq.Text = "Best friends";
            }
            else if (ch == 2)
            {
                tbq.Text = "close friends";
            }
            else if (ch == 3)
            {
                tbq.Text = "lovely friends";
            }
            else if (ch == 4)
            {
                tbq.Text = "friends forever";
            }
            else if (ch == 5)
            {
                tbq.Text = "thick friends";
            }

            else
            {
                tbq.Text = "lucky friends";
            }
        }


        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            this.NavigationService.GoBack();
        }


    }
}