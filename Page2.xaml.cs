using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void b_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }

        private async void b_west_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }

        private async void c_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void c_west_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new b_east());

        }

        private async void  d_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void d_west_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void e_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void e_west_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void orange_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }

        private async void orange_west_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void orange_east_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void orange_south_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void orange_north_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void red_south_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void red_north_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());

        }

        private async void blue_east_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }

        private async void blue_west_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }


        private async void orange_south_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }

        private async void orange_north_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new b_east());
        }
    }
}