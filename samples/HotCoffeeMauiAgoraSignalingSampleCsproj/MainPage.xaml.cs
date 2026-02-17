using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using HotCoffee.Maui.Agora.Signaling.Core.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotCoffeeMauiAgoraSignalingSampleCsproj
{
    public partial class MainPage : ContentPage
    {
        private IRtmClient _tmClient;


        public static bool IsLoggedIn = false;

        public MainPage(IRtmClient rtmClient)
        {
            InitializeComponent();
            rtmClient.InitializeAsync(new() { AppId = "124da2495f7d493494fe6e7c08184f6d", UserId = "bilal123" });
            Debug.WriteLine(" Initialised " + rtmClient.ToString());
            rtmClient.MessageReceived += RtmClient_MessageReceived;
            _tmClient = rtmClient;

        }

        private void RtmClient_MessageReceived(object? sender, RtmMessage e)
        {
            Console.WriteLine("------------> Messages Received : " + e.Payload.ToString());
        }

        private void RtmLogin_Clicked(object sender, EventArgs e)
        {
            _tmClient.LoginAsync("007eJxSYFgQcrzFTPDw4cYYQdGishc2/34JhfD9/Lui/aROUPTxfDcFBkMjk5REIxNL0zTzFBNLYxNLk7RUs1TzZAMLQwuTNLOU7yJTMhsCGRlMTfexMjEwMoAwiM8CJlkZMlJzcvI5GJIycxJzDI2MQdIQBQgxQAAAAP//AEcmag==", new RtmLoginResultCallBackSink());
            
        }

        private void RtmLogout_Clicked(object sender, EventArgs e)
        {
            _tmClient.LogoutAsync(new RtmLogoutResultCallback());
        }

        private void RtmSendMessages_Clicked(object sender, EventArgs e)
        {
            _tmClient.SendMessageAsync("hello", "Self Messages ", new RtmSendMsgResultCallBackSink());
        }

        private void RtmSubscribe_Clicked(object sender, EventArgs e)
        {
            _tmClient.Subscribe("hello", new RtmSubscribeResultCallback());
        }

        public record RtmLogoutResultCallback : IRtmResultCallback
        {
            public void OnFailure(RtmError error)
            {
                Console.WriteLine(error.ToString());
            }

            public void OnSuccess(object? responseInfo)
            {
                Console.WriteLine(responseInfo?.ToString());
            }
        }
        public record RtmSubscribeResultCallback : IRtmResultCallback
        {
            public void OnFailure(RtmError error)
            {
                Console.WriteLine(error.ToString());
            }

            public void OnSuccess(object? responseInfo)
            {
                Console.WriteLine(responseInfo?.ToString());
            }
        }

        public record RtmLoginResultCallBackSink : IRtmResultCallback
        {
            public void OnFailure(RtmError error)
            {
                Console.WriteLine(error.ToString());
                // Shell.Current.CurrentPage.DisplayAlert("Login", "Login failed !!!", "OK").ConfigureAwait(false);
            }

            public void OnSuccess(object? responseInfo)
            {
                IsLoggedIn = true;
                Console.WriteLine(responseInfo?.ToString());
                // Shell.Current.CurrentPage.DisplayAlert("Login", "Login Successfull !!!", "OK").ConfigureAwait(false);
            }
        }
        public record RtmSendMsgResultCallBackSink : IRtmResultCallback
        {
            void IRtmResultCallback.OnFailure(RtmError error)
            {
                Console.WriteLine(error.ToString());
            }

            void IRtmResultCallback.OnSuccess(object? responseInfo)
            {
                Console.WriteLine(responseInfo?.ToString());
            }
        }
    }

}