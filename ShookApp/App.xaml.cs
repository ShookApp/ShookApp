using ShookApp.Views;
using Xamarin.Forms;

namespace ShookApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UserOverview();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
