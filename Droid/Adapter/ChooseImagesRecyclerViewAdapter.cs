using System.Collections.Generic;
using System.Linq;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using fotobuch2.Core.Models;
using fotobuch2.Core.ViewModels;
using fotobuch2.Droid.Controls;
using MvvmCross.Binding.Droid.Views;

namespace fotobuch2.Droid.Adapter
{
    public class ChooseImagesRecyclerViewAdapter : RecyclerView.Adapter
    {
        private ChooseImagesViewModel _viewModel;
        private readonly FragmentActivity _context;
        public ChooseImagesRecyclerViewAdapter(ChooseImagesViewModel vm, FragmentActivity activity)
        {
            _viewModel = vm;
            _context = activity;
        }

        public IList<ImageWrapper> ImageWrappers
        {
            get { return _viewModel.ImageWrappers; }
            set { NotifyDataSetChanged(); }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var layout = (LinearLayout)holder.ItemView;
            var item = position < ItemCount ? ImageWrappers.ElementAt(position) : null;

            var imageView = layout.FindViewById<MvxImageView>(Resource.Id.imageToChoose);

            if (item == null)
            {
                System.Diagnostics.Debug.WriteLine("item == null");
                return;
            }
            imageView.ImageUrl = item.Path;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = _context.LayoutInflater.Inflate(Resource.Layout.image_item, null);
            return new ItemClickedViewHolder(layout, this);

        }

        public void ItemClicked(int position)
        {
        }

        public override int ItemCount => ImageWrappers.Count;
    }
}