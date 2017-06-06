using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using fotobuch2.Core.ViewModels;
using fotobuch2.Droid.Adapter;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;

namespace fotobuch2.Droid.Fragments
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame)]
	[Register("fotobuch2.droid.fragments.ChooseImagesFragment")]
	public class ChooseImagesFragment : BaseFragment<ChooseImagesViewModel>
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			ShowHamburgerMenu = true;

			var view = base.OnCreateView(inflater, container, savedInstanceState);
		    var recyclerView = view.FindViewById<RecyclerView>(Resource.Id.choose_scenario_recyclerview);
		    var adapter = new ChooseImagesRecyclerViewAdapter(ViewModel, Activity);
		    var set = this.CreateBindingSet<ChooseImagesFragment, ChooseImagesViewModel>();
		    set.Bind(adapter).For("ImageWrappers").To(vm => vm.ImageWrappers);
            set.Apply();

            recyclerView.SetAdapter(adapter);
            recyclerView.SetLayoutManager(new GridLayoutManager(Activity,3));

            return view;
		}

        protected override int FragmentId => Resource.Layout.fragment_chooseImages;
    }
}
