using Android.OS;
using Android.Runtime;
using Android.Views;
using fotobuch2.Droid;
using fotobuch2.Droid.Fragments;
using fotobuch2.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;

namespace Fragments
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame)]
	[Register("fotobuch2.droid.fragments.ChooseImagesFragment")]
	public class ChooseImagesFragment : BaseFragment<ChooseImagesViewModel>
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			ShowHamburgerMenu = true;
			return base.OnCreateView(inflater, container, savedInstanceState);
		}

        protected override int FragmentId => Resource.Layout.fragment_chooseImages;
    }
}
