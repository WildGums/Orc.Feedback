// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeedbackService.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Feedback
{
    using System.Threading.Tasks;

    public interface IFeedbackService
    {
        string Url { get; set; }
        Task ProvideFeedbackAsync();
    }
}