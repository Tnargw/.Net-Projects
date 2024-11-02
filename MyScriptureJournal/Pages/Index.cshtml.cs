using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        public int NoteCount { get; set; }
        public DateTime? MostRecentNoteDate { get; set; }

        public async Task OnGetAsync()
        {
            NoteCount = await _context.Note.CountAsync();
            MostRecentNoteDate = await _context.Note
                .OrderByDescending(n => n.DateAdded)
                .Select(n => n.DateAdded)
                .FirstOrDefaultAsync();
        }
    }
}