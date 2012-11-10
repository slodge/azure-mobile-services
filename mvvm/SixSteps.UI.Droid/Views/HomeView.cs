
using Android.App;
using Cirrious.MvvmCross.Binding.Droid.Views;
using SixSteps.Core.ViewModels;

namespace SixSteps.UI.Droid.Views
{
    [Activity]
    public class HomeView
        : MvxBindingActivityView<HomeViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_HomeView);
        }
    }
}