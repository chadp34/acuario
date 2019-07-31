using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using acuario.Models;   

namespace acuario.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionPage : ContentPage
    {
        public static string lang ="es";

        public SelectionPage()
        {
            InitializeComponent();
        }

        async void OnClicked(object sender, EventArgs e)
        {
            var item = new Item();

            Application.Current.Properties["Language"] = true;
            Application.Current.Properties["Choose"] = lang;

            //Debug.WriteLine("Action: " + item.Language);
            //await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
            var mainPage = new MainPage();
            this.Navigation.InsertPageBefore(mainPage, this);
            await this.Navigation.PopAsync();
        }

        async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            var item = new Models.Item();
            var action = await DisplayActionSheet("Select Language: ", "Cancel", null, "English", "Español", "Français");
            switch(action)
            {
                case "English":
                    lang = "en";
                    LabelEn.IsVisible = true;
                    LabelEs.IsVisible = false;
                    LabelFr.IsVisible = false;
                    LabelLanguage.Text = "Language selected: " + action;
                    break;
                case "Español":
                    lang = "es";
                    LabelEs.IsVisible = true;
                    LabelFr.IsVisible = false;
                    LabelEn.IsVisible = false;
                    LabelLanguage.Text = "El idioma seleccionado es: " + action;
                    
                    break;
                case "Français":
                    lang = "fr";
                    LabelFr.IsVisible = true;
                    LabelEn.IsVisible = false;
                    LabelEs.IsVisible = false;
                    LabelLanguage.Text = "La langue selectionnée est: " + action;
                    break;
                default:
                    break;
            }

            LabelLanguage.IsVisible = true;            
            LabelConfiguration.IsVisible = false;
            ButtonSubmit.IsEnabled = true;
            
            //item.Language = lang;
            //Debug.WriteLine("Action: " + item.Language);
        }

               
    }
}