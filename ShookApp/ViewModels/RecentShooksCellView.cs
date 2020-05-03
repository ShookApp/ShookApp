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
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string End { get; private set; }
        // TODO: If this Shook was won ? Color = green : Color = red.
        public string Color { get; private set; }

        /// <summary>
        /// Converts a <see cref="Shook"/> to <see cref="RecentShooksCellView"/> item.
        /// </summary>
        /// <param name="_shook">A Shook you want to convert.</param>
        public RecentShooksCellView(Shook _shook)
        {
            Title = _shook.Title;
            Description = _shook.Description;
            End = CalculateEndTime(_shook.EndTime);
            Color = "#fc85ae";
        }

        /// <summary>
        /// Calculates the end time of a shook. 
        /// </summary>
        /// <param name="endTime">The DateTime when a Shook ends.</param>
        /// <returns>A humanized string like "Ended 1 week ago"</returns>
        private string CalculateEndTime(DateTime endTime)
        {
            DateTime _returnDateTime = DateTime.Now;

            // TODO: Add i18n to return value.

            if (endTime < _returnDateTime)
            {
                TimeSpan timeSpan = endTime.Subtract(_returnDateTime);

                return "Ended " + timeSpan.Humanize() + " ago.";
            }
            else
            {
                TimeSpan timeSpan = _returnDateTime.Subtract(endTime);

                return "Ending in " + timeSpan.Humanize() + ".";
            }
        }
    }
}
