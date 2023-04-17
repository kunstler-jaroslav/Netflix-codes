using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Netflix_codes.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Netflix_codes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerFavorite : ContentPage
    {
        MainPage parent;
        int selected = 0;
        public static List<Code> CodeData = new List<Code>();
        public PickerFavorite(MainPage parent, List<Code> codes)
        {
            InitializeComponent();
            this.parent = parent;
            CodeData = codes;
            BindingContext = new PickerFavoriteViewModel(CodeData);
        }

        private void back_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void continue_clicked(object sender, EventArgs e)
        {
            parent.SelectedSubCode = selected;
            Navigation.PopAsync();
        }

        private async void ListView_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var subgener = ((ListView)sender).SelectedItem as Subgener;
            if (subgener == null)
                return;

            if (subgener == null) return;


            Continue_btn.BackgroundColor = Color.FromHex("#272727");
            Continue_btn.Text = "";
            await Task.Delay(200);
            Continue_btn.BackgroundColor = Color.FromHex("#a1231a");
            Continue_btn.Text = subgener.Name;
            selected = int.Parse(subgener.Code);
            parent.subName = subgener.Name;
            parent.Name = GenerName(subgener.GenerCode);

            parent.Url = subgener.URL;
            parent.favorite = subgener.Favorite;
        }

        private string GenerName(string code)
        {
            foreach (Gener gen in GenerData)
            {
                if (gen.Code == code)
                    return gen.Name;
            }
            return "All genres";
        }

        private void ListView_Tapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}