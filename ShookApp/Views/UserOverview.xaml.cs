using ShookApp.Utils;
using ShookApp.ViewModels;
using ShookModel.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserOverview : ContentPage
    {
        /// <summary>
        /// Constructor of the UserOverview.
        /// </summary>
        public UserOverview()
        {
            InitializeComponent();
            BuildProfile();
        }

        #region Methods

        /// <summary>
        /// Builds the UserOverview. A picture, a username and the recent shooks
        /// of this user are needed.
        /// </summary>
        private void BuildProfile()
        {
            // TODO: Set the Picture which is coming from the <see cref="LoginPackage"/> as ProfilePicture.
            ProfilePictureView.Source = "profilepicture.png";
            UserNameLabel.Text = Statics.loginPackage.AccountUser.UserData.UserName;

            // TODO: Set the won, lost, created variables depending on the user.

            // TODO: Get all Shooks of current user and add the 10 most recent to the list as 
            // RecentShooksCellView Object.
            recentShooksListView.ItemsSource = CreateListOfRecentShooksCellViews();
        }

        /// <summary>
        /// Test method for filling the ListView.
        /// </summary>
        /// <returns>A list with the recent shooks of the user as
        /// <see cref="RecentShooksCellView"/></returns>
        private List<RecentShooksCellView> CreateListOfRecentShooksCellViews()
        {
            List<RecentShooksCellView> recentShooksCellViews = new List<RecentShooksCellView>();

            foreach (Shook shook in Statics.loginPackage.AccountUser.Shooks)
            {
                recentShooksCellViews.Add(new RecentShooksCellView(shook));
            }

            return recentShooksCellViews;
        }

        #endregion

        #region ClickEvents

        /// <summary>
        /// Opens the settings.
        /// </summary>
        private void OpenSettingsButton_Clicked(object sender, EventArgs e)
        {
            // TODO: Open settings.
        }

        #endregion
    }
}