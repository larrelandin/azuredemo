using System.Collections.Generic;

namespace mvctest.Models
{
    public class PagesList
    {
        public IEnumerable<PageDetails> Pages { get; set; }
        public int TotalResultCount { get; set; }
    }
}