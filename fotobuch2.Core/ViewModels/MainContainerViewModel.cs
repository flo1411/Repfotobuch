using MvvmCross.Core.ViewModels;

namespace fotobuch2.Core.ViewModels
{
    public class MainContainerViewModel : MvxViewModel
	{
        public MainContainerViewModel()
		{
            
		}

		public void ShowMenu()
		{
			ShowViewModel<ChooseTypeViewModel>();
			ShowViewModel<MenuViewModel>();
		}
	}
}
