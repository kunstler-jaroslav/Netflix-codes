using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("BebasNeue-Regular.ttf", Alias = "Bebas")]
[assembly: ExportFont("Poppins-Bold.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("Poppins-Light.ttf", Alias = "PoppinsLight")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "PoppinsMedium")]
[assembly: ExportFont("Poppins-Regular.ttf", Alias = "PoppinsRegular")]
[assembly: ExportFont("Poppins-Black.ttf", Alias = "PoppinsBlack")]

namespace Netflix_codes
{
    public partial class App : Application
    {
        private static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sites.db3"));

                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
