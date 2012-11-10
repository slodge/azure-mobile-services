using System;
using System.Collections.Generic;

namespace SixSteps.Core.Interfaces.Speakers
{
    public interface ISpeakerService
    {
        void GetSpeakers(string key, Action<List<Speaker>> onSuccess, Action<SpeakerServiceError> onError);
    }
}
