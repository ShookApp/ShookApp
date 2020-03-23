using Humanizer;
using ShookModel.Models;
using System;

namespace ShookApp.ViewModels
{
    class RecentShooksCellView
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string End { get; private set; }
        // TODO: If this Shook was won ? Color = green : Color = red
        public string Color { get; private set; }

        public RecentShooksCellView(Shook _shook)
        {
            Title = _shook.Title;
            Description = _shook.Description;
            End = CalculateEndTime(_shook.EndTime);
            Color = "#fc85ae";
        }

        private string CalculateEndTime(DateTime endTime)
        {
            DateTime _returnDateTime = DateTime.Now;

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
