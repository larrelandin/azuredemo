using System;
using System.Linq;
using System.Web.Mvc;
using HoneyBees.Models;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace HoneyBees.Controllers
{
    public class ChildListController : Controller
    {
        // GET: ChildList
        public ActionResult Index()
        {
            Item contextItem = RenderingContext.Current.ContextItem;
            var database = contextItem.Database;
            var indexName = string.Format("sitecore_{0}_index", database);
            try
            {
                var index = ContentSearchManager.GetIndex(indexName);

                var model = new PagesList();
                using (var context = index.CreateSearchContext())
                {
                    var results = context.GetQueryable<PageDetails>()
                        .Where(i => i.Paths.Contains(contextItem.ID))
                        .Where(i => i.Language == contextItem.Language.Name)
                        .GetResults();

                    model.Pages = results.Hits.Select(h => h.Document).ToList();
                    model.TotalResultCount = results.TotalSearchResults;
                }
                return View(model);
            }
            catch (Exception e)
            {
                return new EmptyResult();
            }
        }
    }
}