using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Public
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public string GroupText { get; set; }
    }
}
