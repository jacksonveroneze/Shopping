using System;
using System.Collections.Generic;

namespace JacksonVeroneze.Shopping.Services.Interfaces
{
    //
    // Summary:
    //     /// Interface responsible for the contract. ///
    //
    public interface ICrashlyticsService
    {
        void TrackEventAsync(string eventName, IDictionary<string, string> dictionary);

        void TrackErrorAsync(Exception e);
    }
}