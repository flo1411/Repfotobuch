using System;
using MvvmCross.Core.ViewModels;

namespace fotobuch2.Core.ViewModels
{
	public class MenuViewModel : MvxViewModel
{
	#region Cross Platform Commands & Handlers

	public IMvxCommand ShowHomeCommand
	{
		get { return new MvxCommand(ShowHomeExecuted); }
	}

	private void ShowHomeExecuted()
	{
			ShowViewModel<ChooseTypeViewModel>();
	}
	#endregion
}
}