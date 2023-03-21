namespace Orc.Feedback;

using System.Threading.Tasks;

public interface IFeedbackService
{
    string Url { get; set; }
    Task ProvideFeedbackAsync();
}
