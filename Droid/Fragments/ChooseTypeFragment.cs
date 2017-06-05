using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Shared.Attributes;
using Android.Runtime;
using fotobuch2.Core.ViewModels;

namespace fotobuch2.Droid.Fragments
{
	[MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame)]
	[Register("fotobuch2.droid.fragments.ChooseTypeFragment")]
	public class ChooseTypeFragment : BaseFragment<ChooseTypeViewModel>
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			ShowHamburgerMenu = true;
			return base.OnCreateView(inflater, container, savedInstanceState);
		}

        protected override int FragmentId => Resource.Layout.fragment_chooseType;
	}
}
