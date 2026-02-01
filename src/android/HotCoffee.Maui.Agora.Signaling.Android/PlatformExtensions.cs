using Java.Lang;

namespace HotCoffee.Maui.Agora.Signaling.Android
{
    public static class PlatformExtensions
    {
        #region Private Fields
        private static bool _initialized;
        private static readonly object _lock = new();
        #endregion
        public static void InitSignaling(this AppDomain appDomain)
        {
            if (_initialized)
                return;

            lock (_lock)
            {
                if (_initialized)
                    return;

                try
                {
                    // IMPORTANT: load dependencies FIRST
                    JavaSystem.LoadLibrary("cipherdb");
                    JavaSystem.LoadLibrary("agora-rtm-sdk");

                    _initialized = true;
                }
                catch (UnsatisfiedLinkError ex)
                {
                    // Native lib missing / wrong ABI / wrong name
                    throw new InvalidOperationException(
                        "Failed to load Agora native libraries. " +
                        "Check ABI folders and Build Action = AndroidNativeLibrary.",
                        ex);
                }
            }
        }
    }
}