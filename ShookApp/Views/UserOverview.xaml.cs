using ShookApp.Utils;
using ShookApp.ViewModels;
using ShookModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShookApp.Views
{

    /// <summary>
    /// Displays a <see cref="User"/> in a nice way.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserOverview : ContentPage
    {
        private readonly User _userToDisplay;

        /// <summary>
        /// Constructor of the UserOverview.
        /// </summary>
        /// <param name="user">The user that should be displayed.</param>
        public UserOverview(User user)
        {
            InitializeComponent();
            _userToDisplay = user;
            BuildProfile();
        }

        #region Methods

        /// <summary>
        /// Builds the UserOverview. A picture, a username and the recent shooks
        /// of this user are needed.
        /// </summary>
        private void BuildProfile()
        {
            // TODO: Set the Picture which is coming from the user as ProfilePicture.
            ProfilePictureView.Source = "profile_picture.png";
            UserNameLabel.Text = _userToDisplay.UserData.UserName;
            StatisticsGrid.BindingContext = new StatisticsGridBindings(_userToDisplay); 
            RecentShooksListView.ItemsSource = CreateListOfRecentShooksCellViews();
        }

        /// <summary>
        /// Creates a list with RecentShooksCellViews. But only the 10 recent ones.
        /// </summary>
        /// <returns>A list with the recent shooks of the user as
        /// <see cref="RecentShooksCellView"/></returns>
        private List<RecentShooksCellView> CreateListOfRecentShooksCellViews()
        {
            List<RecentShooksCellView> recentShooksCellViews = new List<RecentShooksCellView>();

            // If the user is member in less than 10 shooks iterate over all present shooks.
            if (_userToDisplay.Shooks.Count > 10)
            {
                for (var i = 0; i < 10; i++)
                {
                    recentShooksCellViews.Add(new RecentShooksCellView(_userToDisplay.Shooks[i]));
                }
            }
            else
            {
                foreach (Shook shook in _userToDisplay.Shooks)
                {
                    recentShooksCellViews.Add(new RecentShooksCellView(shook));
                }
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
            Navigation.PushAsync(new MainPage());
        }

        #endregion
    }
}