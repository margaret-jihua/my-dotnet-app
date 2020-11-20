using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace myWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("Welcome");
        }
    }
}
