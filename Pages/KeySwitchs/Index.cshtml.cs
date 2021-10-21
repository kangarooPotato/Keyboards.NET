using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Keyboards.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Keyboards.Pages.KeySwitchs
{
    public class IndexModel : PageModel
    {
        private readonly KeyboardContext _context;

        public IndexModel(KeyboardContext context)
        {
            _context = context;
        }

        public IList<Keyboard> Keyboard { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Type { get; set; }
        [BindProperty(SupportsGet = true)]
        public string KeyboardType { get; set; }

        public async Task OnGetAsync()
        {
        // Use LINQ to get list of genres.
        IQueryable<string> TypeQuery = from m in _context.Keyboard
                                    orderby m.Type
                                    select m.Type;    
            // Keyboard = await _context.Keyboard.ToListAsync();

        var Keyboards = from m in _context.Keyboard
                    select m;
        if (!string.IsNullOrEmpty(SearchString))
        {
            Keyboards = Keyboards.Where(s => s.Type.Contains(SearchString));
        }

        Keyboard = await Keyboards.ToListAsync();            
        }
    }
}

