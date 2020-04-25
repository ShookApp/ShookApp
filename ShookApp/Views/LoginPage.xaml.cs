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
        private readonly LoginManager _loginManager = new LoginManager();

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
        /// <remarks>There is an error on iOS while debugging with a mac. If you press enter on the password entry
        /// something fails and th application crashes!</remarks>
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (_loginManager.CheckPassword(usernameEntry.Text, passwordEntry.Text))
            {
                App.Current.MainPage = new NavigationPage(new UserOverview(Statics.LoginPackage.AccountUser));
            }
            else
            {
                passwordEntry.Text = "";
                passwordEntry.BackgroundColor = Color.Red;
            }
        }
    }
}