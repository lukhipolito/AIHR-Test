### AIHR-Test
The Tests for AIHR.

## Coding


#Reasonings:

This project is supposed to be a fully functional MVP of the given problem.
Because of that, the technology chosen for the whole project is .NET, which the developer has the most experience and confort working with, 
and thus providing a more reliable solution for the short amount of time.

The problem specifically requested an interface on which the user can select the courses to visually see the calculations and plan their studies.
For this purpose, there were a few options, including the popular SPAs of Angular and VueJs and even a console application. But they were left out due to focus on functionality.
This is a simple project so it makes sense to have a well designed interface that doesn't require a lot of pre-configuring and coding like Angular and Vue both require.
A console application was also left out because not only its not user-friendly enough, but also increases complexity while requiring to design and code a well-rounded flow for it to work properly.

Since the logic for this project is also not too complex and doesn't require a lot of integrations besides a database, a fully designed wep api would be an overkill.
A simpler Api with its own logic could be enough, but in that case it would also need two separate projects comunicating via HTTP/S.
A function app (to run on a serverless cloud-based structure) is also a good option for the micro service involved in this problem. 
But that would require a lot more setup and also some not previously planned integrations.

And for all the reasons above this project is made as a Blazor WebAssembly app. A well rounded monolith that has a layer dedicated to a client and another dedicated to run as a server.
Since it is a pure .NET solution it also works in the way intended to use the experience of the developer at his favor. 
The frontend is pre-build and pre-configured with the netcore sdk and native webassembly, which means it can run as a web app native to any browser that supports it and also run javascript scripts.
Since the server is running with the sdk it also handles all the necessary logics and possible integrations.


There should be a connection with a database, but the choice was really open. To avoid overcomplexity on an MVP project the database used is a session storage.


Everything built is fully functional and the project tries to avoid most of the possible errors. It's not perfect but handles the problem given.


#Suggestions for the future:
-- Improve the logics of Calculate method;
-- Develop a function app to host the courses's business rules and logic;
-- Develop a function app to host the study plans's business rules and logic;
-- Develop a different client frontend with a more popular SPA technology for guaranteed evolution and qualified professionals working on it;
-- Develop a better arquitecture, with proper workflows, data modeling, and error-proof;
-- Host the application as a CDN-enabled hosted web page on a cloud, calling the microservices via Lambda functions (in the case of AWS) or any other serverless technology for a better reuse of services;
-- Improve UI/UX;
-- Implement an improved alert/message system. This current project makes javascript calls to the 'alert()' function. This can be changed into some kind of 'toast' like the ones present in modern popular SPAs;
-- Implement a proper database. The most common recommendation being a no-SQL one due to a higher amount of writing than reading
