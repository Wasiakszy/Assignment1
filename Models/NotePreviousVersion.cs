using System;


namespace Assignment1.Models
{
    public class NotePreviousVersion
    {
        public int Id { get; set; }
        public NoteModel NoteModel { get; set; }
        public int NoteModelId { get; set; }
        public DateTime ModificationDate { get; set; }
        public string Version { get; set; }
    }
}