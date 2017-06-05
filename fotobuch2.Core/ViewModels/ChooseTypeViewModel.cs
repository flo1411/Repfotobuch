using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using fotobuch2.Core.Models;
using fotobuch2.Core.Services;

namespace fotobuch2.Core.ViewModels
{
	public class ChooseTypeViewModel : MvxViewModel
	{
		private readonly IStorageService _storageService;

		private List<ProductType> _productTypes;
		public List<ProductType> ProductTypes
		{
			get
			{
				return _productTypes;
			}
			set
			{
				SetProperty(ref _productTypes, value);
			}
		}

		public ChooseTypeViewModel(IStorageService storageService)
		{
            _storageService = storageService;
		}

		public async void Init() 
		{
            await LoadContent();
		}

        public async Task LoadContent()
        {
            var types = await _storageService.ReadStringFromLocalPath(GlobalConstants.ProductTypes);
            var rootElement = JsonConvert.DeserializeObject<RootObject>(types);
			ProductTypes = rootElement.types;
        }

		public IMvxCommand ShowChooseImagesCommand
		{
			get { return new MvxCommand(DoShowChooseImagesCommand); }
		}

		private void DoShowChooseImagesCommand()
		{
			ShowViewModel<ChooseImagesViewModel>();
		}
	}
}
