# Orc.Feedback

Allows the user to easily get feedback from the end-user. 

## Initializing the service

It is very important to initialize the service. It can be done by retrieving it from the service locator and update the required data:

	var dependencyResolver = this.GetDependencyResolver();
	var feedbackService = dependencyResolver.ResolveType<IFeedbackService>();

	feedbackService.SomeProperty = "http://myfeedbackwebsite";