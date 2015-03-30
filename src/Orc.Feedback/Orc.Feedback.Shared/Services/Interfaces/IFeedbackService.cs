// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeedbackService.cs" company="Orchestra development team">
//   Copyright (c) 2008 - 2014 Orchestra development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Feedback
{
    using System.Threading.Tasks;

    public interface IFeedbackService
    {
        string Url { get; set; }
        Task ProvideFeedback();
    }
}