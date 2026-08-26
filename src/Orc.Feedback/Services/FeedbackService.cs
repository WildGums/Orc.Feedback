namespace Orc.Feedback;

using System.Threading.Tasks;
using Catel.Services;
using Microsoft.Extensions.Logging;

public class FeedbackService : IFeedbackService
{
    private readonly ILanguageService _languageService;
    private readonly ILogger<FeedbackService> _logger;
    private readonly IProcessService _processService;

    public FeedbackService(ILogger<FeedbackService> logger, IProcessService processService, ILanguageService languageService)
    {
        _logger = logger;
        _processService = processService;
        _languageService = languageService;

        Url = string.Empty;
    }

    public string Url { get; set; }

    public async Task ProvideFeedbackAsync()
    {
        if (string.IsNullOrEmpty(Url))
        {
            _logger.LogError(_languageService.GetString("FeedbackService_IncorrectFeedbackUri"));
            return;
        }

        _logger.LogDebug(_languageService.GetString("FeedbackService_LaunchingUri"), Url);

        // for now, just open the url in the browser
        _processService.StartProcess(new ProcessContext
        {
            FileName = Url,
            UseShellExecute = true
        });
    }
}
