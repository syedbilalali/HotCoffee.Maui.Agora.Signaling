using HotCoffee.Maui.Agora.Signaling;
namespace HotCoffeeMauiAgoraSignalingSampleCsproj
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            RtmManager rtmManager = new RtmManager();
            rtmManager.Init("","");
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}