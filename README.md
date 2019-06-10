# Kentico Cloud & ASP.NET Core MVC Web application

[![Preview](https://img.shields.io/badge/-Preview-brightgreen.svg)](http://cloud-template-dotnet-core-dev-as.azurewebsites.net/)

Kentico cloud web template using ASP.NET Core MVC and Kentico Cloud.

## Get started

### Prerequisites

* [.Net core 2.1+](https://dotnet.microsoft.com/download)

### Run

1. [Clone](https://git-scm.com/docs/git-clone) or [fork](https://hub.github.com/hub-fork.1.html) this repository. Once it's done, navigate to the app's `/source`  and install the packages:

    ```sh
    cd source
    yarn
    ```

1. [Register on Kentico Cloud](http://app.kenticocloud.com)
1. [Create an empty project](https://docs.kenticocloud.com/tutorials/set-up-projects/manage-projects/adding-projects)
1. [Enable Content Management API](https://docs.kenticocloud.com/tutorials/set-up-projects/migrate-content/importing-to-kentico-cloud#a-enabling-the-api-for-your-project)
1. Import [content.zip](/content.zip) data using [Template manager](https://kentico.github.io/cloud-template-manager/import-from-file)
    * Use `Project Id` and `Content Management API key` from previously generated project.
1. Place the `ProjectId` to the  [`/source/gatsby-config.js`](/source/gatsby-config.js#L13) configuration file.
1. Run development environment

    ```sh
    yarn develop
    ```

🚀 Your site is now running at http://localhost:8000!

## Features

* [GatsbyJS](https://www.gatsbyjs.org/) static site generator
* Data source - Kentico Cloud (using [Gatsby source plugin for Kentico Cloud](https://www.gatsbyjs.org/packages/gatsby-source-kentico-cloud/))
* Styling using SCSS
* [Font awesome + Material Icons](#Icons)
* [CSS Grid](#CSS-Grid)

### Color palette

To define color pallette - change values of variables stored in [_vars.scss](https://github.com/Simply007/cloud-template-gatsby/blob/master/source/src/assets/scss/libs/_vars.scss#L32).

### Icons

It is possible to use [two sets of font icons](https://github.com/Simply007/cloud-template-gatsby/tree/master/source/src/assets/css) - [Material Icons](https://material.io/tools/icons/) as well as [Font Awesome](https://fontawesome.com/).

Format Example:

* Material icons: `<i className="material-icons">face</i>` (`face` - icon code)
* Font Awesome : `<li><span  className="fa-code"></span></li>` (`fa-code` - icon code)

### CSS Grid

The grid on this site was replaced with a custom version, built using CSS Grid. It's a very simple 12 column grid that is disabled on mobile. To start using the grid, wrap the desired items with `grid-wrapper`. Items inside the `grid-wrapper` use the class `col-` followed by a number, which should add up to 12.

Here is an example of using the grid, for a 3 column layout:

```html
<div className="grid-wrapper">
    <div className="col-4">
        <p>Adipiscing a commodo ante nunc accumsan et interdum mi ante adipiscing. A nunc lobortis non nisl amet vis sed volutpat aclacus nascetur ac non. Lorem curae et ante amet sapien sed tempus adipiscing id accumsan.</p>
    </div>
    <div className="col-4">
        <p>Content Here</p>
    </div>
    <div className="col-4">
        <p>Adipiscing a commodo ante nunc accumsan et interdum mi ante adipiscing. A nunc lobortis non nisl amet vis sed volutpat aclacus nascetur ac non. Lorem curae et ante amet sapien sed tempus adipiscing id accumsan.</p>
    </div>
</div>
```

## Thanks

 © 2019, Built with Gatsby using [Gatsby starter Photon](https://www.gatsbyjs.org/starters/codebushi/gatsby-starter-photon/)
