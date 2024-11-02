using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Notes
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteBook { get; set; }

        // For sorting
        public string DateSort { get; set; }
        public string BookSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // Set sorting parameters
            DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            BookSort = sortOrder == "Book" ? "book_desc" : "Book";
            //CurrentSort = sortOrder;

            IQueryable<string> bookQuery = from b in _context.Note
                                            orderby b.Book
                                            select b.Book;

            var notes = from n in _context.Note
                        select n;

            if (!string.IsNullOrEmpty(SearchString))
            {
                notes = notes.Where(s => s.Entry.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(NoteBook))
            {
                notes = notes.Where(s => s.Book.Contains(NoteBook));
            }

            switch (sortOrder)
            {
                case "book_desc":
                    notes = notes.OrderByDescending(n => n.Book);
                    break;
                case "Book":
                    notes = notes.OrderBy(n => n.Book);
                    break;
                case "date_desc":
                    notes = notes.OrderByDescending(n => n.DateAdded);
                    break;
                default:
                    notes = notes.OrderBy(n => n.DateAdded);
                    break;
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Note = await notes.ToListAsync();
        }
    }
}
