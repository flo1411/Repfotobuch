using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform.Droid.Platform;
using MvvmCross.Platform;
using fotobuch2.Core.Services;
using fotobuch2.Droid.Services;
using fotobuch2.Droid.Utils;

namespace fotobuch2.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeLastChance()
        {
            Mvx.RegisterSingleton<IGalleryService>(new AndroidGalleryService());
            base.InitializeLastChance();
        }

		/// <summary>
		/// This is very important to override. The default view presenter does not know how to show fragments!
		/// </summary>
		protected override IMvxAndroidViewPresenter CreateViewPresenter()
		{
			var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
			Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

			//add a presentation hint handler to listen for pop to root
			mvxFragmentsPresenter.AddPresentationHintHandler<MvxPanelPopToRootPresentationHint>(hint =>
			{
				var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
				var fragmentActivity = activity as Android.Support.V4.App.FragmentActivity;

				for (int i = 0; i < fragmentActivity.SupportFragmentManager.BackStackEntryCount; i++)
				{
					fragmentActivity.SupportFragmentManager.PopBackStack();
				}
				return true;
			});
			//register the presentation hint to pop to root
			//picked up in the third view model
			Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPanelPopToRootPresentationHint());
			return mvxFragmentsPresenter;   
		}
    }
}
