using MvvmCross.IoC;
using MvvmCross.ViewModels;
using LucyMobile.Core.ViewModels.Main;

namespace LucyMobile.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
