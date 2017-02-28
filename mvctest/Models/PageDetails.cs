using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;

namespace mvctest.Models
{
    public class PageDetails : SearchResultItem
    {
        [IndexField("_name")]
        public string Title { get; set; }
    }
}