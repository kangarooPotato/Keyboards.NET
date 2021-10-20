using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Keyboards.Models;

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

        public async Task OnGetAsync()
        {
            Keyboard = await _context.Keyboard.ToListAsync();
        }
    }
}
