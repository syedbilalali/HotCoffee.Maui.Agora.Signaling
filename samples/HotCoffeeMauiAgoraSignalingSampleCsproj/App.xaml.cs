using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using System.Diagnostics;

namespace HotCoffeeMauiAgoraSignalingSampleCsproj
{
    public partial class App : Application
    {
        
        public App(IRtmClient rtmClient)
        {
            InitializeComponent();
            rtmClient.InitializeAsync(new() { AppId = "fkkfhkdhfkdfhfh374273283h23h2", UserId = "1213122" });
            Debug.WriteLine(" Initialised " + rtmClient.ToString());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}