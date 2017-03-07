using System.Linq;
using System.Web.Mvc;
using HoneyBees.Models;
using Sitecore.Links;

namespace HoneyBees.Controllers
{
    public class NavigationMenuController : Controller
    {
        // GET: NavigationMenu
        public ActionResult Index()
        {
            var currentItem = Sitecore.Context.Item;
            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);

            var menuItems = homeItem.Children
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