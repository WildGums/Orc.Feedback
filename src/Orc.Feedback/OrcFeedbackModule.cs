namespace Orc;

using Catel.Services;
using Catel.ThirdPartyNotices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orc.Feedback;

/// <summary>
/// Core module which allows the registration of default services in the service collection.
/// </summary>
public static class OrcFeedbackModule
{
    public static IServiceCollection AddOrcFeedback(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddSingleton<IFeedbackService, FeedbackService>();

        serviceCollection.AddSingleton<ILanguageSource>(new LanguageResourceSource("Orc.Feedback", "Orc.Feedback.Properties", "Resources"));

        serviceCollection.AddSingleton<IThirdPartyNotice>((x) => new LibraryThirdPartyNotice("Orc.Feedback", "https://github.com/wildgums/orc.feedback"));

        return serviceCollection;
    }
}
