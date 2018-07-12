[assembly: System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.6", FrameworkDisplayName=".NET Framework 4.6")]
public class static ModuleInitializer
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