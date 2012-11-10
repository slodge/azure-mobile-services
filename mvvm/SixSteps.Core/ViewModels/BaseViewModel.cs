using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.ViewModels;
using SixSteps.Core.Interfaces.Errors;

namespace SixSteps.Core.ViewModels
{
    public class BaseViewModel
        : MvxViewModel
    {
        public void ReportError(string error)
        {
            this.GetService<IErrorReporter>().ReportError(error);
        }
    }
}