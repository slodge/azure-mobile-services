using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Platform.Diagnostics;
using Microsoft.WindowsAzure.MobileServices;
using SixSteps.Core.Interfaces.Speakers;
using Cirrious.MvvmCross.ExtensionMethods;

namespace SixSteps.UI.Touch.PlatformSpecificServices
{
    public class SpeakerService : ISpeakerService
    {
#error To use this code you will need to supply some details here...
        private const string Url = @"http://YOUR_APP_NAME.azure-mobile.net";
        private const string Key = @"YOUR_APP_KEY";

        private readonly MobileServiceClient _mobileService = new MobileServiceClient(Url, Key);

        public void GetSpeakers(string key, Action<List<Speaker>> onSuccess, Action<SpeakerServiceError> onError)
        {
                var table = _mobileService.GetTable<Speaker>();

                Task<List<Speaker>> task;
                if (string.IsNullOrEmpty(key))
                {
                    task = table.ToListAsync();
                }
                else
                {
                    var query = table.Where(s => s.Name.StartsWith(key));
                    task = query.ToListAsync();
                }

                task.ContinueWith(t =>
                                      {
                                          if (t.Exception != null)
                                          {
                                              MvxTrace.Trace("Error seen: " + task.Exception.ToLongString());
                                              onError(SpeakerServiceError.ErrorException);
                                              return;
                                          }

                                          var result = t.Result;
                                          onSuccess(result);
                                      });
        }
    }
}