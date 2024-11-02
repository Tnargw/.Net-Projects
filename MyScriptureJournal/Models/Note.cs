using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Book { get; set; }

        [Range(1, int.MaxValue)]
        public int Chapter { get; set; }

        [Range(1, int.MaxValue)]
        public int Verse { get; set; }

        public string Entry { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
    }
}
