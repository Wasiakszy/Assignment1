using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class NoteModel
    {
        [Required(ErrorMessage = "You need to give a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to add content.")]
        public string Content { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCre { get; set; }
        [Display(Name = "Date Modified")]
        public DateTime? DateMod { get; set; }
        public int Id { get; set; }
        public List<NotePreviousVersion> NotePreviousVersions { get; set; }
        public bool IsDeleted { get; set; }
    }
}