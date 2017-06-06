using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using fotobuch2.Droid.Adapter;

namespace fotobuch2.Droid.Controls
{
    public class ItemClickedViewHolder : RecyclerView.ViewHolder, View.IOnClickListener
    {
        private readonly ChooseImagesRecyclerViewAdapter _adapter;

        public ItemClickedViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ItemClickedViewHolder(View itemView, ChooseImagesRecyclerViewAdapter adapter = null) : base(itemView)
        {
            _adapter = adapter;
            itemView.Clickable = true;
            itemView.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            _adapter?.ItemClicked(AdapterPosition);
        }
    }

}