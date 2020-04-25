using Humanizer;
using ShookModel.Models;
using System;

namespace ShookApp.ViewModels
{
    /// <summary>
    /// This class is used to fill the recentShooksListView in UserOverview.xaml.
    /// </summary>
    class RecentShooksCellView
    {
        public string Title { get; }
        public string Description { get; }
        public string End { get; }
        // TODO: If this Shook was won ? Color = green : Color = red.
        public string Color { get; }

        /// <summary>
        /// Converts a <see cref="Shook"/> to <see cref="RecentShooksCellView"/> item.
        /// </summary>
        /// <param name="shook">A Shook you want to convert.</param>
        public RecentShooksCellView(Shook shook)
        {
            Title = shook.Title;
            Description = shook.Description;
            End = CalculateEndTime(shook.EndTime);
            Color = "#fc85ae";
        }

        /// <summary>
        /// Calculates the end time of a shook. 
        /// </summary>
        /// <param name="endTime">The DateTime when a Shook ends.</param>
        /// <returns>A humanized string like "Ended 1 week ago"</returns>
        private string CalculateEndTime(DateTime endTime)
        {
            var returnDateTime = DateTime.Now;

            // TODO: Add i18n to return value.

            if (endTime < returnDateTime)
            {
                var timeSpan = endTime.Subtract(returnDateTime);

                return "Ended " + timeSpan.Humanize() + " ago.";
            }
            else
            {
                var timeSpan = returnDateTime.Subtract(endTime);

                return "Ending in " + timeSpan.Humanize() + ".";
            }
        }
    }
}
