using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvctest.Models;
using Sitecore.Links;
using Sitecore.Helper.Extensions;

namespace mvctest.Controllers
{
    public class NavigationMenuController : Controller
    {
        // GET: NavigationMenu
        public ActionResult Index()
        {
            var currentItem = Sitecore.Context.Item;
            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);

            var menuItems = homeItem.Children
                .Where(i => i.Template.HasBaseTemplate("_base page"))
                .Select(i => new NavigationItem
                {
                    Title = i["title"],
                    Url = LinkManager.GetItemUrl(i),
                    ActiveItem = i.ID == currentItem.ID
                }).ToArray();

            return View(menuItems);
        }
    }
}