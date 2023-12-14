namespace Orc.Feedback;

using System;
using System.Threading.Tasks;
using Catel.Logging;
using Catel.Services;

public class FeedbackService : IFeedbackService
{
    private static readonly ILog Log = LogManager.GetCurrentClassLogger();
    private readonly IProcessService _processService;

    public FeedbackService(IProcessService processService)
    {
        ArgumentNullException.ThrowIfNull(processService);

        _processService = processService;

        Url = string.Empty;
    }

    public string Url { get; set; }

    public async Task ProvideFeedbackAsync()
    {
        if (string.IsNullOrEmpty(Url))
        {
            Log.Error("Incorrect feedback uri");
            return;
        }

        Log.Debug($"Launching uri '{Url}");

        // for now, just open the url in the browser
        _processService.StartProcess(new ProcessContext
        {
            FileName = Url,
            UseShellExecute = true
        });
    }
}
