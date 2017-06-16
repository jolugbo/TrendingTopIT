﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TrendingTopIt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Discover : TabbedPage
    {
        
        public Discover()
        {
            
            InitializeComponent();
            this.Children.Add(new NavigationPage(new DiscoverTab1()));




        }
    }
}
