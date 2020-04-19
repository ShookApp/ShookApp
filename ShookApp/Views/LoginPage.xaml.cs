using System;
using ShookApp.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShookApp.Views
{
    /// <summary>
    /// The controller class for Views/LoginPage.xaml.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        /// <summary>
        /// The <see cref="LoginManager"/> that is responsible for validating the password and username.
        /// </summary>
        private readonly LoginManager loginManager = new LoginManager();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The action of the "Login" button. Changes the main page of the application if the 
        /// password is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (loginManager.CheckPassword(usernameEntry.Text, passwordEntry.Text))
            {
                App.Current.MainPage = new UserOverview();
            }
            else
            {
                passwordEntry.Text = "";
                passwordEntry.BackgroundColor = Color.Red;
            }
        }
    }
}