[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName="")]
public static class ModuleInitializer
{
    public static void Initialize() { }
}
namespace Orc.Feedback
{
    public class FeedbackService : Orc.Feedback.IFeedbackService
    {
        public FeedbackService(Catel.Services.IProcessService processService) { }
        public string Url { get; set; }
        public System.Threading.Tasks.Task ProvideFeedbackAsync() { }
    }
    public interface IFeedbackService
    {
        string Url { get; set; }
        System.Threading.Tasks.Task ProvideFeedbackAsync();
    }
}