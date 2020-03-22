using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserOverview : ContentPage
    {
        public UserOverview()
        {
            InitializeComponent();
            BuildProfile();
        }

        #region Methods

        private void BuildProfile()
        {
            // TODO: Set the Picture which is coming from the LoginPackage as ProfilePicture
            ProfilePictureView.Source = "profile_picture.png";
            UserNameLabel.Text = "Samofan";
        }

        #endregion

        #region ClickEvents

        private void OpenSettingsButton_Clicked(object sender, EventArgs e)
        {
            // TODO: Open settings
        }

        #endregion
    }
}