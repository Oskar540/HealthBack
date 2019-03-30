using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunShawn.Web.Areas.Admin.Models
{
    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Prize { get; set; }
        public string ImageSrc { get; set; }
    }
}