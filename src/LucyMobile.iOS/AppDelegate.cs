using Foundation;
using MvvmCross.Platforms.Ios.Core;
using LucyMobile.Core;

namespace LucyMobile.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
