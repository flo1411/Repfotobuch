using System;
using System.Collections.Generic;
using System.Linq;
using fotobuch2.Core.Models;
using fotobuch2.Core.Services;
using MvvmCross.Core.ViewModels;

namespace fotobuch2.Core.ViewModels
{
    public class ChooseImagesViewModel : MvxViewModel
    {
        private readonly IGalleryService _galleryService;
        private IList<ImageWrapper> _imageWrappers;
        public IList<ImageWrapper> ImageWrappers
        {
            get { return _imageWrappers; }
            set { SetProperty(ref _imageWrappers, value);}
        }

        public ChooseImagesViewModel(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public void Init()
        {
            var allImages = _galleryService.GetImagePaths();
            ImageWrappers = allImages.Select(image => new ImageWrapper(image)).ToList();
        }
    }
}