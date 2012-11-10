using Cirrious.MvvmCross.Touch.Views.Presenters;
using MonoTouch.UIKit;

namespace SixSteps.UI.Touch
{
    public class SixStepsPhonePresenter 
        : MvxModalSupportTouchViewPresenter
	{
        public SixStepsPhonePresenter(UIApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}
		
		protected override UINavigationController CreateNavigationController (UIViewController viewController)
		{
			var toReturn = base.CreateNavigationController (viewController);
			toReturn.NavigationBarHidden = false;
			return toReturn;
		}
	}
}

