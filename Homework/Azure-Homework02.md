## Kindra Bilodeau
#### Azure Homework 2

1. **What is an App Service?**
  - An App Service is a service that hosts one of five kinds of applications:
    - Web Apps
    - Mobile Apps
    - Logics Apps
    - API Apps
    - Function Apps
2. **What is an App Service Plan, and what is some of the criteria you can define when you create an App Service?**
  - An App Service plan defines the capacity and resources to be shared among one or more app services that are assigned to that plan.  
  - Some of the criteria would be location, instance count, and pricing tiers.
3. **What is a Web App?**
  - A Web App is a web application that is hosed in an App Service.
  - The App Service is the managed service in Azure that enables you to deploy a web application
4. **What are some of the ways you can monitor your Web App?**
  - Site Metrics Per Instance option: This shows overall metrics for your web app as well as metrics for each instance that is running
  -  Live HTTP Traffic:  which will show what’s going on currently with the web app, showing Request count, HTTP 5xx responses, and HTTP 4xx responses
  - Diagnostics Logs: you can enable and disable the different kinds of diagnostics logging for your web app.
5. **What are the different methods for scaling a Web App?**
  - Scaling out manually:
      - You can specify the number of instances that you want to run. But scaling manually isn’t practical unless you’re sure your apps will run consistently all of the time.
  - Scaling by CPU Percentage:
      - This will allow you to scale up or down depending on the CPU Percentage. When the CPU Percentage is below the limit, it will scale down until it reaches the minimum number of instances.  
  - Scaling by schedule and performance rules:
      - This allows you to set your own rules. You can set a schedule telling when to scale out and in, and you can even combine that with a performance metric
6. **What are Webhooks?**
  - Webhooks allow you to route the notification to other systems. For example, you could have a service that sends you an SMS message when the scaling begins.  
