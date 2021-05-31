using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoutingTest.Models;
namespace RoutingTest.Services
{
    public class PageService
    {
        private IEnumerable<Page> _pages;
        public PageService()
        {
            List<Page> list = new()
            {
                new Page()
                {
                    Name = "Home",
                    Slug = "home",
                    Content = "Detta är startsidan!"
                },
                new Page()
                {
                    Name = "Contact",
                    Slug = "contact",
                    Content = "Detta är kontaktsidan!"
                },

            };
            _pages = list;
        }
        public IEnumerable<Page> GetPages()
        {
            return _pages;
        }
    }
}
