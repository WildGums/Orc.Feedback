// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackService.cs" company="Orchestra development team">
//   Copyright (c) 2008 - 2014 Orchestra development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Feedback
{
    using System.Threading.Tasks;
    using Catel;
    using Catel.Services;

    public class FeedbackService : IFeedbackService
    {
        private readonly IProcessService _processService;

        public FeedbackService(IProcessService processService)
        {
            Argument.IsNotNull(() => processService);

            _processService = processService;
        }

        public string ApiToken { get; set; }

        public string Url { get; set; }

        public async Task ProvideFeedbackAsync()
        {
            // for now, just open the url in the browser
            _processService.StartProcess(Url);
        }
    }
}