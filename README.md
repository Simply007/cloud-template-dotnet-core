# Kentico Cloud & ASP.NET Core MVC Web application

[![Preview](https://img.shields.io/badge/-Preview-brightgreen.svg)](http://cloud-template-dotnet-core-dev-as.azurewebsites.net/)

Kentico cloud web template using ASP.NET Core MVC and Kentico Cloud.

![template preview](/template.jpg)

## Get started

### Prerequisites

* [.Net core 2.1+](https://dotnet.microsoft.com/download)

### Run

1. [Clone](https://git-scm.com/docs/git-clone) or [fork](https://hub.github.com/hub-fork.1.html) this repository. Once it's done, navigate to the app's `/source`  and build the solution:

    ```sh
    cd source
    dotnet build
    ```

1. [Register on Kentico Cloud](http://app.kenticocloud.com)
1. [Create an empty project](https://docs.kenticocloud.com/tutorials/set-up-projects/manage-projects/adding-projects)
1. [Enable Content Management API](https://docs.kenticocloud.com/tutorials/set-up-projects/migrate-content/importing-to-kentico-cloud#a-enabling-the-api-for-your-project)
1. Import [content.zip](/content.zip) data using [Template manager](https://kentico.github.io/cloud-template-manager/import-from-file)
    * Use `Project Id` and `Content Management API key` from previously generated project.
1. Place the `ProjectId` to the  [`/source/appsettings.json`](/source/appsettings.js#L9) configuration file.
1. Run development environment (in `/source` folder)

    ```sh
    dotnet run --project .\cloud-template-dotnet-core\cloud-template-dotnet-core.csproj
    ```

🚀 Your site is now running at:

* [https://localhost:5001](https://localhost:5001)
* [http://localhost:5000](http://localhost:5000)

## Features

* [ASP.NET Core MVC](https://docs.microsoft.com/aspnet/core/mvc/overview) web apps framework
* Data source - Kentico Cloud (using [Delivery SDK for .NET](https://github.com/Kentico/delivery-sdk-net))
* Styling using CSS
* [GLYPHICONS Icons](https://www.glyphicons.com/)
* [Bootstrap](https://getbootstrap.com/)
