using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;

namespace HoneyBees.Models
{
    public class PageDetails : SearchResultItem
    {
        [IndexField("_name")]
        public string Title { get; set; }
    }
}