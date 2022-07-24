using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Netflix_codes
{
    public partial class MainPage : ContentPage
    {
        private bool favorite;

        public bool Favorite
        {
            get { return favorite; }
            set 
            { 
                favorite = value;
                //call writein action
            }
        }

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void showCode_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Showed("69884215", "https://www.netflix.com/browse", false, this));
        }
    }
}
