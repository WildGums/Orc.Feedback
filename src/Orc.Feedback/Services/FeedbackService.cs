// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackService.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Feedback
{
    using System;
    using System.Threading.Tasks;
    using Catel.Logging;

#if NETFX_CORE
    using Windows.System;
#else
    using System.Diagnostics;
#endif

    public class FeedbackService : IFeedbackService
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public FeedbackService()
        {
        }

        public string ApiToken { get; set; }

        public string Url { get; set; }

        public async Task ProvideFeedbackAsync()
        {
            Log.Debug($"Launching uri '{Url}");

            // for now, just open the url in the browser
#if NETFX_CORE
            await Launcher.LaunchUriAsync(new Uri(Url, UriKind.RelativeOrAbsolute));
#else
            Process.Start(Url);
#endif
        }
    }
}