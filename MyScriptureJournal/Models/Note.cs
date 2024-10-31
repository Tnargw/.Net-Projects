using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Entry { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
    }
}
