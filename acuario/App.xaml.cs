using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using acuario.Services;
using acuario.Views;

namespace acuario
{
    public partial class App : Application
    {
        //public static string AzureBackendUrl =
        //    DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";

        public static string BackendUrl = "http://noti.heliohost.org/mghalynho/wikimap.json";

        public static bool UseMockDataStore = false;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();
            MainPage = new NavigationPage(new SelectionPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            if (Application.Current.Properties.ContainsKey("Language"))
            {

                bool PropName = Application.Current.Properties["Language"] is bool;

                if (PropName = true)
                {
                    MainPage = new MainPage();
                }
                else
                {
                    MainPage = new NavigationPage(new SelectionPage());
                }
            }
            else
            {                
                MainPage = new NavigationPage(new SelectionPage());
            }

            if (Application.Current.Properties.ContainsKey("Choose"))
            {

                string choose = Application.Current.Properties["Choose"].ToString();

                switch(choose)
                {
                    case "fr":
                        SelectionPage.lang = "fr";
                        break;
                    case "en":
                        SelectionPage.lang = "en";
                        break;
                    case "es":
                        SelectionPage.lang = "es";
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
