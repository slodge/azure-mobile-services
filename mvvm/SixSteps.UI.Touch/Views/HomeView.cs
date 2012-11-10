using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using SixSteps.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using System.Collections.Generic;
using Cirrious.MvvmCross.Views;

namespace SixSteps.UI.Touch.Views
{
    public sealed partial class HomeView 
        : MvxBindingTouchViewController<HomeViewModel>
    {
		const string CellBindingText = @"
                        {
                           'TitleText':{'Path':'TalkTitle'},
                           'DetailText':{'Path':'Name'},
                           'HttpImageUrl':{'Path':'PictureUrl','Converter':'SpeakerImage'}
                        }";

        public HomeView (MvxShowViewModelRequest request)
            : base (request, "HomeView", null)
        {
            Title = "Home";
        }
        
        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            
            this.AddBindings(new Dictionary<object, string>()
            {
                { Go, "{'TouchDown':{'Path':'FetchItemsCommand'}}"}, 
                { Edit, "{'Text':{'Path':'Key','Mode':'TwoWay'}}"}, 
            });

			var source = new MvxActionBasedBindableTableViewSource(
				Table, 
				UITableViewCellStyle.Subtitle,
				new NSString("Speaker"), 
				CellBindingText,
				UITableViewCellAccessory.None);
			
			source.CellModifier = (cell) =>
			{
				cell.Image.DefaultImagePath = "Images/Icons/50_icon.png";
			};
			
			this.AddBindings(new Dictionary<object, string>() 
			{
				{source, "{'ItemsSource':{'Path':'Items'}}"},
			});
			Table.Source = source;
			Table.ReloadData();
        }
        
        public override void ViewDidUnload ()
        {
            base.ViewDidUnload ();
            
            ReleaseDesignerOutlets ();
        }
        
        public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
    }
}

