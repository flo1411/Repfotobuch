using fotobuch2.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace fotobuch2.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

			RegisterAppStart<InitializationViewModel>();
        }
    }
}
