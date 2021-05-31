using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingTest.Models
{
    public class Page
    {
        public Page()
        {
            Component = typeof(Components.Page);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public Type Component { get; set; }
    }
}
