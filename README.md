# MVC Developer Demo #

* Built for Sitecore 8.1 rev 160302

### Preparations ###
* Clone solution from git
* Make sure publish works
* Remove all custom code that you want to demo
* Load icons in rocks once
* Open Experience Editor once

## Demo steps ##

### Content Management ###
* Show Sitecore standard features in empty Sitecore 
* Create item
* Explain components

### Set up solution ###
* Open Visual Studio, explain separation of code and platform
* Show Bootstrap
* Solution structure
* Nuget
* Sitecore Rocks

### Create scaffolding ###
* Create view "Main.cshtml" based on "Sitecore/MVC/Sitecore View Layout"  under "Shared"
* Move title and VisitorIdentification to "_Layout.cshtml"
* Publish solution to Sitecore
* Change layout for "home" and show page

### Product template ###
* Create template "Product" with "Title", "Description" and "Image"
* Create standard values
* Set layout for "product"
* Create items under "home" {Book, Car, Dishwasher, Phone}

### Poduct Description Rendering ###
* Create View "ProductDescription"
* Register Sitecore View Rendering
* Add to Standard Values for "Product" placeholder "Main"
* Show change on all pages

### Build for Editors ###
* Add placeholder setting for "main" placeholder
* Add Datasource location and datasource template to "Product Description"
* Add additional components on home page, explain layout deltas

### Add navigation ###
* Explain difference between View renderings and Controller renderings
* Create model "NavigationItem" {Title, Url, (ActiveItem)}
* Create controller "NavigationMenuController"
* Explain the Sitecore API, examples
* Code to get items using Linq
* Create View {Index, List, NavigationItem}
* Create a Controller Rendering {NavigationMenu, Index}
* Add rendering to "_Layout.cshtml"