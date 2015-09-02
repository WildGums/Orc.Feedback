# Orc.Feedback

[![Join the chat at https://gitter.im/WildGums/Orc.Feedback](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/WildGums/Orc.Feedback?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

![License](https://img.shields.io/github/license/wildgums/orc.commandline.svg)
![NuGet downloads](https://img.shields.io/nuget/dt/orc.commandline.svg)
![Version](https://img.shields.io/nuget/v/orc.commandline.svg)
![Pre-release version](https://img.shields.io/nuget/vpre/orc.commandline.svg)

Allows the user to easily get feedback from the end-user. 

## Initializing the service

It is very important to initialize the service. It can be done by retrieving it from the service locator and update the required data:

	var dependencyResolver = this.GetDependencyResolver();
	var feedbackService = dependencyResolver.ResolveType<IFeedbackService>();

	feedbackService.SomeProperty = "http://myfeedbackwebsite";
