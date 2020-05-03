using ShookModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShookApp.ViewModels
{
    /// <summary>
    /// This ViewModel is used to fill the StatisticsGrid in UserOverview.xaml.
    /// </summary>
    class StatisticsGridBindings
    {
        /// <summary>
        /// The amount of lost shooks. This property has to be calculated because it 
        /// is not stored in the database.
        /// </summary>
        public int LostShooks { get; set; }

        /// <summary>
        /// The amount of created shooks.
        /// </summary>
        public int CreatedShooks { get; set; }

        /// <summary>
        /// The amount of won shooks.
        /// </summary>
        public int WonShooks { get; set; }

        /// <summary>
        /// The constructor gets all necessary information from a user object.
        /// </summary>
        /// <param name="user">The user that should be displayed.</param>
        public StatisticsGridBindings(User user)
        {
            LostShooks = user.Shooks.Count - WonShooks;
            CreatedShooks = user.CreatedShooks;
            WonShooks = user.WonShooks;
        }
    }
}
