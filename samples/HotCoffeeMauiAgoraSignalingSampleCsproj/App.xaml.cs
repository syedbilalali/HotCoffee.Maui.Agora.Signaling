using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using System.Diagnostics;

namespace HotCoffeeMauiAgoraSignalingSampleCsproj
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}