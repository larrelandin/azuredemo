using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvctest.Models;
using Sitecore.Links;

namespace mvctest.Controllers
{
    public class NavigationMenuController : Controller
    {
        // GET: NavigationMenu
        public ActionResult Index()
        {
            var home = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
            var contextItem = Sitecore.Context.Item;

            var menuItems = home.Children
                .Where(i => i.Template.Key == "product")
                .Select(i => new NavigationItem
                {
                    Title = i["title"],
                    Url = LinkManager.GetItemUrl(i),
                    ActiveItem = i.ID == contextItem.ID
                })
                .ToArray();

            return View(menuItems);
        }
    }
}