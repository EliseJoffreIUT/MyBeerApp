using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using MyBeerApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ViewCell), typeof(CustomViewCellRenderer))]

namespace MyBeerApp.Droid.Renderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {

        private Android.Views.View cellCore;
        private Drawable unselectedBackground;
        private bool selected;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            cellCore = base.GetCellCore(item, convertView, parent, context);

            // Save original background to rollback to it when not selected,
            // We assume that no cells will be selected on creation.
            selected = false;
            unselectedBackground = cellCore.Background;

            return cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnCellPropertyChanged(sender, args);

            if (args.PropertyName == "IsSelected")
            {
                selected = !selected;

                if (selected)
                {
                    var customTextCell = sender as ViewCell;
                    cellCore.SetBackgroundColor(Android.Graphics.Color.White);
                }
                else
                {
                    cellCore.SetBackground(unselectedBackground);
                }
            }
        }
    }
}