# Sitecore Azuredemo
Developer demo showing different ways of deploying a Sitecore solution on Azure Web Apps. (And also teaches you a little bit about honey bees)

1. Automated builds from remote Git repo using Kudo (code and Sitecore items)
2. Web Deploy from Visual Studio (only code)

*Using Unicorn by @kamsar to handle and deploy the Sitecore content.
https://github.com/kamsar/Unicorn*

*Built and tested on Sitecore 8.2.161221*

## Preparations
First clone this repo to your local machine then upload it to your own favourite spot such as TFS, GitHub or BitBucket. You are going to do automatic builds from your online repo later on.

Secondly, deploy a Sitecore environment in Azure, you can use the Azure marketplace for a standard installation or tweek some ARM-templates to fit your need. It is up to you.

## Configuring automatic build in Azure using Kudu
In Azure, open your Web App for the CM-server, go to "Application settings" and add the following App Setting:
*SCM_BUILD_ARGS = /p:Configuration=ReleaseAzureCM*
```
Above line tells Kudu what build configuration to use. This solution relies on config transforms for the different environments.
```

Still on the CM, go to "Deployment Options" and configure the connection to your repo. Deployment should start automatically and hopefully show a green checkmark after a while.

## Setting up Web Deploy in Visual Studio


## How is it set up?