# Sitecore Azuredemo
Developer demo showing different ways of deploying a Sitecore solution on Azure Web Apps. (And also teaches you a little bit about honey bees)

1. Automated builds from remote Git repo using Kudo (code and Sitecore items)
2. Web Deploy from Visual Studio (only code)

*Using Unicorn by @kamsar to handle and deploy the Sitecore content.
https://github.com/kamsar/Unicorn*

*Built and tested on Sitecore 8.2.161221*

## Preparations
First clone this repo to your local machine then upload it to your own favourite spot such as TFS, GitHub or BitBucket. You are going to do automatic builds from your online repo later on.

Secondly, deploy a Sitecore environment in Azure, you can use the Azure marketplace for a standard installation or tweek some ARM-templates to fit your need. It is up to you but we will need a CM and CD environment deployed.

## Configuring automatic build in Azure using Kudu
In Azure, open your Web App for the CM-server, go to "Application settings" and add the following App Setting:
*SCM_BUILD_ARGS = /p:Configuration=ReleaseAzureCM*
```
Above line tells Kudu what build configuration to use.

This solution relies on config transforms for the different environments.
```

Still on the CM, go to "Deployment Options" and configure the connection to your repo. Deployment should start automatically and hopefully show a green checkmark after a while.
```
N.B. You could have Azure trigger on a specific branch only.
```

## Setting up Web Deploy in Visual Studio
Use the Web Deploy features of Visual Studio to set up a deploy for your CD in the Azure environment. This will build and push code to the instance.

## How is it set up?
1. Since we are using the Sitecore Nuget packages for references we need to tell Kudu where to actually find the packages. This is handled in the file "NuGet.config" found in the root of the repo.
2. The path for the Unicorn serialization folder is different in Azure than it is on our local environment. We are using config transforms for the /App_Config/Include/Unicorn/Unicorn.config to set the correct path locally and in Azure.
3. When using Web Deploy to a CD-server in Azure, we do not want to deploy the content items. We are using config transforms for the /App_Config/Include/Unicorn.Configs.Default.config to remedy this.
4. Not really related to Azure but we are using Bundles to register scripts and css-files. In order for Sitecore to render this correctly we need to register this with Sitecore and our good friends at BrainJocks wrote a blog post on just that: http://jockstothecore.com/bundling-with-sitecore-mvc/ 

## Whishlist
1. Automatic publish in Azure after deploy from repo.
2. Automation script to warm up the newly deployed instance.
3. Explore search indexes in Azure and have a working component.
4. More honey bees.
