namespace Orc.Feedback;

using System.Threading.Tasks;
using Catel.Services;
using Microsoft.Extensions.Logging;

public class FeedbackService : IFeedbackService
{
    private readonly ILogger<FeedbackService> _logger;
    private readonly IProcessService _processService;

    public FeedbackService(ILogger<FeedbackService> logger, IProcessService processService)
    {
        _logger = logger;
        _processService = processService;

        Url = string.Empty;
    }

    public string Url { get; set; }

    public async Task ProvideFeedbackAsync()
    {
        if (string.IsNullOrEmpty(Url))
        {
            _logger.LogError("Incorrect feedback uri");
            return;
        }

        _logger.LogDebug($"Launching uri '{Url}");

        // for now, just open the url in the browser
        _processService.StartProcess(new ProcessContext
        {
            FileName = Url,
            UseShellExecute = true
        });
    }
}
