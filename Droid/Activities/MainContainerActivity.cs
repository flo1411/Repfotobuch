using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using fotobuch2.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platform;

namespace fotobuch2.Droid.Activities
{
	[Activity(
		Label = "Fotobuch bestellen",
		LaunchMode = LaunchMode.SingleTop,
		Theme =  "@style/AppTheme"
	)]
	public class MainContainerActivity : MvxCachingFragmentCompatActivity<MainContainerViewModel>
{
	public DrawerLayout DrawerLayout;

	protected override void OnCreate(Bundle bundle)
	{
		base.OnCreate(bundle);

		SetContentView(Resource.Layout.activity_main);

		DrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

		if (bundle == null)
			ViewModel.ShowMenu();
	}

	public override bool OnOptionsItemSelected(IMenuItem item)
	{
		switch (item.ItemId)
		{
			case Android.Resource.Id.Home:
				DrawerLayout.OpenDrawer(GravityCompat.Start);
				return true;
		}

		return base.OnOptionsItemSelected(item);
	}

	private void ShowBackButton()
	{
		//Block the menu slide gesture
		DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeLockedClosed);
	}

	private void ShowHamburguerMenu()
	{
		//Unlock the menu sliding gesture
		DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeUnlocked);
	}

	public override void OnBackPressed()
	{
		if (DrawerLayout != null && DrawerLayout.IsDrawerOpen(GravityCompat.Start))
			DrawerLayout.CloseDrawers();
		else
			base.OnBackPressed();
	}

	public void HideSoftKeyboard()
	{
		if (CurrentFocus == null) return;

		InputMethodManager inputMethodManager = (InputMethodManager)GetSystemService(InputMethodService);
		inputMethodManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, 0);

			CurrentFocus.ClearFocus();
		}
    }
}
