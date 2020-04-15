using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShookModel.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        { 
            App.Current.MainPage = new LoginPage();
        }
    }
}