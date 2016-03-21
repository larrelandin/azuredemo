# MVC Developer Demo #

* Built for Sitecore 8.1 rev 160302

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

### Create scaffolding ###
* Create view "Main.cshtml" under "Shared", publish solution to Sitecore
* Change layout for "home" and show page
* Add H1 "Title" to Main
* Add placeholder "main"
* Show updated page

### Product template ###
* Create template "Product" with "Title", "Description" and "Image"
* Create standard values
* Set layout for "product"
* Create items under "home" {Book, Car, Dishwasher, Phone}

### Poduct Description Rendering ###
* Create View "ProductDescription"
* Register Sitecore View Rendering
* Add to Standard Values for "Product"
* Show change on all pages
* Add placeholder setting for "main" placeholder
* Add additional components on one page, explain layout deltas

### Add navigation ###
* Explain difference between View renderings and Controller renderings
* Create model "NavigationItem" {Title, Url, (ActiveItem)}
* Create controller "NavigationMenuController"
* Explain the Sitecore API, examples