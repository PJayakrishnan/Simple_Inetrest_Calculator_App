using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:ExportFont("Comfortaa-VariableFont_wght.ttf", Alias = "Comfortaa")]
[assembly:ExportFont("CutiveMono-Regular.ttf",Alias = "cutive_mono")]
namespace TestApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
