using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Shell.Feeds.FeedTypes;

namespace mvctest.Models
{
    public class NavigationItem
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public bool ActiveItem { get; set; }
    }
}