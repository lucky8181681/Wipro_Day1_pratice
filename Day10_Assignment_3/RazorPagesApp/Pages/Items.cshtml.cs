using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPagesApp.Pages
{
    public class ItemsModel : PageModel
    {
        public List<string> Items => AddItemModel.Items;

        public void OnGet()
        {
        }
    }
}