using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RoutingTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RoutingTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PageService ps;

        public IndexModel(PageService ps)
        {

            this.ps = ps;
        }
        [BindProperty(SupportsGet = true)]
        public string Slug { get; set; }
        public Models.Page CurrentPage { get; private set; }

        public void OnGet()
        {
            // If Slug is null, that we're at the startpage (/)
            if (Slug == null) CurrentPage = ps.GetPages().FirstOrDefault(p => p.Name == "Home");
            else
                CurrentPage = ps.GetPages().FirstOrDefault(p => p.Slug == Slug);
            if (CurrentPage == null) // Not found
                CurrentPage = new() { Name = "Hittades inte", Content = $"Sidan hittades inte! Du angav {Slug}" };
        }
    }
}
