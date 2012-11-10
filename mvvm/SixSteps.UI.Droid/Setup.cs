using System;
using System.Collections.Generic;
using Android.Content;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.Binding.Droid;
using Cirrious.MvvmCross.ExtensionMethods;
using SixSteps.Core;
using SixSteps.Core.Converters;
using SixSteps.Core.Interfaces.Speakers;
using SixSteps.UI.Droid.PlatformSpecificServices;

namespace SixSteps.UI.Droid
{
    public class Setup
        : MvxBaseAndroidBindingSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override MvxApplication CreateApp()
        {
            return new App();
        }

        protected override IEnumerable<Type> ValueConverterHolders
        {
            get { return new[] { typeof(Converters) }; }
        }

        protected override void InitializeLastChance()
        {
            InitialiseErrorDisplay();
            InitialiseServices();
            base.InitializeLastChance();
        }

        private void InitialiseErrorDisplay()
        {
            var errorDisplayer = new ErrorDisplayer(ApplicationContext);
        }

        private void InitialiseServices()
        {
            this.RegisterServiceInstance<ISpeakerService>(new SpeakerService());
        }
    }
}