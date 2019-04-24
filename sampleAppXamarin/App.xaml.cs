using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("c3748b80-b532-4143-af95-843ee25c6526;",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ButtonPage();
        }
    }
}
