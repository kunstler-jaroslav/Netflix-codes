using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Netflix_codes.Data;

namespace Netflix_codes
{
    public partial class MainPage : ContentPage
    {
        public List<Code> CodeData = new List<Code>();
        private int code = 0;
        public string Url = "";
        public bool favorite;
        private string name = "";

        private int subcode = 0;
        public string subName = "";

        public string Name 
        {
            get { return name; }
            set
            {
                name = value;
                gener_data.Text = name;
            }
        }

        public bool Favorite
        {
            get { return favorite; }
            set 
            { 
                favorite = value;
                //call writein action
            }
        }

        public int SelectedCode
        {
            get { return code; }
            set
            {
                code = value;
                if (code != 0)
                    gener_data.Text = Name;
            }
        }

        public int SelectedSubCode
        {
            get { return subcode; }
            set
            {
                subcode = value;
                subgener_data.Text = subName;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //FillGener();
            //FillSubgener();
        }

        public async void Fill()
        {
            CodeData = await App.Database.GetCodesAsync();
        }

        private async void showCode_clicked(object sender, EventArgs e)
        {
            if (code == 0 && subcode == 0)
                await DisplayAlert("Pick gener", "In order to view the code, you need to chose a gener or subgener", "Ok");
            else if(subcode == 0)
                await Navigation.PushAsync(new Showed(code.ToString(), Url, favorite, Name, this));
            else
                await Navigation.PushAsync(new Showed(subcode.ToString(), Url, favorite, subName, this));

        }

        private void gener_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Picker(this));
        }

        private void subgener_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PickerSubgener(this, code));
        }

        public async void add_code(int number)
        {
            await App.Database.SaveCodeAsync(new Code
            {
                Number = number
            });
            Fill();
        }

        public async void remove_code(int number)
        {
            await App.Database.RemoveCodeAsync(10);
            //Fill();
        }

        private void favorites_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PickerFavorite(this, CodeData));
        }
    }
}
