using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Provider;
using fotobuch2.Core.Services;

namespace fotobuch2.Droid
{
    public class AndroidGalleryService : IGalleryService
    {
        public AndroidGalleryService()
        {
        }

        public IEnumerable<string> GetImagePaths()
		{
            var projection = new[] { MediaStore.Images.Media.InterfaceConsts.Id, MediaStore.Images.Media.InterfaceConsts.Data };
            var cursor = Application.Context.ContentResolver.Query(MediaStore.Images.Media.ExternalContentUri, projection,
				null, null, MediaStore.Images.Media.InterfaceConsts.Id);

			var pathIndex = cursor.GetColumnIndex(MediaStore.Images.Media.InterfaceConsts.Data);

			System.Diagnostics.Debug.WriteLine($"Got {cursor.Count} images");
			var imagePaths = new List<string>();
			while (cursor.MoveToNext())
			{
				var path = cursor.GetString(pathIndex);
				imagePaths.Add(path);
			}

			return imagePaths;
		}
    }
}
