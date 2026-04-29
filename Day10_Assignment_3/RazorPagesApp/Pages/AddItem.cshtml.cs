using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPagesApp.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string NewItem { get; set; }

        public static List<string> Items = new List<string>();

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(NewItem))
            {
                Items.Add(NewItem);
            }
        }
    }
}