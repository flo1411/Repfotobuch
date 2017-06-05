using Android.App;
using Android.OS;
using fotobuch2.Core.ViewModels;
using fotobuch2.Droid;
using MvvmCross.Droid.Views;


namespace Activities
{
    [Activity()]
    public class InitializationActivity : MvxActivity<InitializationViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_initialization);
        }
    }
}
