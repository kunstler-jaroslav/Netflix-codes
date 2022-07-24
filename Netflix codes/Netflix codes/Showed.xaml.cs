using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Netflix_codes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Showed : ContentPage
    {
        bool favorite = false;
        MainPage parent = null;
        public Showed(string code, string url, bool favorite, MainPage parent)
        {
            InitializeComponent();
            code_data.Text = code;
            url_data.Text = url;
            this.favorite = favorite;
            this.parent = parent;
        }

        private void back_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void copy_clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(code_data.Text);
            code_frame.BorderColor = Color.Green;
            code_frame.BackgroundColor = Color.FromHex("#1f331a");
            await Task.Delay(300); 
            code_frame.BorderColor = Color.FromHex("#A7A7A7");
            code_frame.BackgroundColor = Color.FromHex("#131313");
        }

        private async void open_clicked(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri(url_data.Text, UriKind.Absolute);
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "It is not possible to open this code" + ex.Message, "OK");
            }
        }

        private void favorite_clicked(object sender, EventArgs e)
        {
            favorite = !favorite;
            parent.Favorite = favorite;
            if (favorite)
                favorite_icon.Source = "favorite_minus.png";
            else
                favorite_icon.Source = "favorite_plus.png";

        }
    }
}