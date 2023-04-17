using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Netflix_codes.Data;

namespace Netflix_codes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    

    public partial class Picker : ContentPage
    {
        MainPage parent = null;
        int selected = 0;
        string NameSaved = "";
        public Picker(MainPage parent)
        {
            InitializeComponent();
            this.parent = parent;
            BindingContext = new PickerViewModel();
        }

        private void back_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void continue_clicked(object sender, EventArgs e)
        {
            parent.subName = "subgerer";
            parent.SelectedSubCode = 0;
            parent.SelectedCode = selected;
            parent.Name = NameSaved;
            Navigation.PopAsync();
        }

        private async void ListView_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var gener = ((ListView)sender).SelectedItem as Gener;
            if (gener == null)
                return;

            if(gener == null) return;

            
            Continue_btn.BackgroundColor = Color.FromHex("#272727");
            Continue_btn.Text = "";
            await Task.Delay(200);
            Continue_btn.BackgroundColor = Color.FromHex("#a1231a");
            Continue_btn.Text = gener.Name;
            selected = int.Parse(gener.Code);
            NameSaved = gener.Name;
            parent.Url = gener.URL;
            parent.favorite = gener.Favorite;
            parent.SelectedSubCode = 0;
        }

        private void ListView_Tapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        
    }
}