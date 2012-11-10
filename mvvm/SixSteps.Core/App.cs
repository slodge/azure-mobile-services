using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using SixSteps.Core.ApplicationObjects;
using SixSteps.Core.Interfaces.Errors;
using SixSteps.Core.Services;

namespace SixSteps.Core
{
    public class App
        : MvxApplication
        , IMvxServiceProducer
    {
        public App()
        {
            InitaliseErrorReporting();
            InitialisePlugins();
            InitialiseStartNavigation();
        }

        private void InitaliseErrorReporting()
        {
            var errorService = new ErrorApplicationObject();
            this.RegisterServiceInstance<IErrorReporter>(errorService);
            this.RegisterServiceInstance<IErrorSource>(errorService);
        }

        private void InitialiseStartNavigation()
        {
            var startApplicationObject = new StartNavigation();
            this.RegisterServiceInstance<IMvxStartNavigation>(startApplicationObject);
        }

        private void InitialisePlugins()
        {
            // initialise any plugins where are required at app startup
            // e.g. Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
        }
    }
}
