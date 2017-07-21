using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml;
using System.Xml.Linq;

namespace PhoneApp1
{
    public partial class hg : PhoneApplicationPage
    {



        public hg()
        {
            InitializeComponent();
            this.Loaded += hg_Loaded;
        }

        void hg_Loaded(object sender, RoutedEventArgs e)
        {

            XDocument d = XDocument.Load("hindugirl.xml");
            var p = from temp in d.Descendants("names")
                    select new hinduboy
                    {
                        name = temp.Element("name1").Value
                    };
            list.ItemsSource = p;
        }


    }
}