﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A37 我妻　龍希";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string w = weighit.Text;
            string h = heighit.Text;
            double bmi;

           double we = double.Parse(w);
           double he = double.Parse(h);
           if (we > 200)
           {
                we = we/1000;
           }
            if (he > 2.5)
            {
                   he = he/100;
            }
            bmi = we /(he*he);
            result.Text=bmi+"";
        }
    }
}
