using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Keyboards.Modles;

namespace Keyboards.Pages.KeySwitchs
{
    public class CreateModel : PageModel
    {
        private readonly KeyboardContext _context;

        public CreateModel(KeyboardContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Keyboard Keyboard { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Keyboard.Add(Keyboard);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
