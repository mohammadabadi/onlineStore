using OnlineStore.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Public
{
    public class ProductListSettings
    {
        public List<int> Paging { get; set; }
        public List<ProductItem> Products { get; set; }
        public List<ProducerItem> Producers { get; set; }
        public List<BreadCrumbLink> BreadCrumbUrls { get; set; }
        public List<ViewAttribute> Attributes { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPageIndex { get; set; }
        public string GroupUrl { get; set; }
        public int GroupID { get; set; }
        public string OriginalUrl { get; set; }
        public string CanonicalUrl { get; set; }
        public string PageTitle { get; set; }
        public List<int> ProducersFilter { get; set; }
        public List<ViewAttributeOption> AttributesFilter { get; set; }
    }
}
