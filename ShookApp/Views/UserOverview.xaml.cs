using ShookApp.ViewModels;
using ShookModel.Models;
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
            // TODO: Set the Picture which is coming from the LoginPackage as ProfilePicture.
            ProfilePictureView.Source = "profile_picture.png";
            UserNameLabel.Text = "Samofan";

            // TODO: Get all Shooks of current user and add the 10 most recent to the list as 
            // RecentShooksCellView Object.
            recentShooksListView.ItemsSource = CreateListOfRecentShooksCellViews();
        }

        // Test.
        private List<RecentShooksCellView> CreateListOfRecentShooksCellViews()
        {
            Shook shook1 = new Shook
            {
                Title = "Test",
                Description = "Test Description",
                EndTime = DateTime.Now
            };

            List<RecentShooksCellView> recentShooksCellViews = new List<RecentShooksCellView>();

            recentShooksCellViews.Add(new RecentShooksCellView(shook1));
            recentShooksCellViews.Add(new RecentShooksCellView(shook1));
            recentShooksCellViews.Add(new RecentShooksCellView(shook1));
            recentShooksCellViews.Add(new RecentShooksCellView(shook1));

            return recentShooksCellViews;
        }

        #endregion

        #region ClickEvents

        private void OpenSettingsButton_Clicked(object sender, EventArgs e)
        {
            // TODO: Open settings.
        }

        #endregion
    }
}