[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v3.1", FrameworkDisplayName="")]
public static class ModuleInitializer
{
    public static void Initialize() { }
}
namespace Orc.Feedback
{
    public class FeedbackService : Orc.Feedback.IFeedbackService
    {
        public FeedbackService() { }
        public string ApiToken { get; set; }
        public string Url { get; set; }
        public System.Threading.Tasks.Task ProvideFeedbackAsync() { }
    }
    public interface IFeedbackService
    {
        string Url { get; set; }
        System.Threading.Tasks.Task ProvideFeedbackAsync();
    }
}