using System;
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
            string w = "weighit";
            String h = "heighit";
            double bmi;

            try
            {
                double we = parse.double(w);
                double he = parse.double(h);

                if (we > 200)
                {
                    we=we/1000;
                    //g→kg
                }
                else
                {
                    //kg
                }

                if (he > 2.5)
                {
                    we=we/100;
                    //cm→m
                }
                else
                {
                    //m
                }

                bmi = we /(he*he);
                result.Text=bmi.Tostring();

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }



        }
    }
}
