using System;
using MvvmCross.Core.ViewModels;
using fotobuch2.Core.Services;

namespace fotobuch2.Core.ViewModels
{
    public class InitializationViewModel : MvxViewModel
    {
		private readonly IInitializationService _initializationService;

		public InitializationViewModel(IInitializationService initializationService)
		{
			_initializationService = initializationService;
		}

		public async void Init()
		{
			await _initializationService.Initialize();
            ShowViewModel<MainContainerViewModel>();
		}
    }
}
