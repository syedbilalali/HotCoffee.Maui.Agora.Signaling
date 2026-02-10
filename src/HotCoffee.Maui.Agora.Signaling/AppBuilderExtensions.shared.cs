
#if ANDROID
using HotCoffee.Maui.Agora.Signaling.Android;
#endif
using Microsoft.Maui.LifecycleEvents;
using System.Runtime.CompilerServices;

namespace HotCoffee.Maui.Agora.Signaling
{
    // All the code in this file is included in all platforms.
    public static class AppBuilderExtensions
    {
        /// <summary>
        /// Initialise the HotCoffee.Maui.Agora.Signaling. 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MauiAppBuilder UseMauiAgoraSignaling(this MauiAppBuilder builder , Action<HotCoffee.Maui.Agora.Signaling.Core.Models.RtmOptions> options)
        {

            builder.ConfigureLifecycleEvents(static lifecycle =>
            {

#if ANDROID

                lifecycle.AddAndroid(static method =>
                {
                    method.OnCreate(static  (activity , _) =>
                    {
                        AppDomain.CurrentDomain.InitSignaling();    
                    });
                });
#endif
            });
            return builder;
        }
    }
}