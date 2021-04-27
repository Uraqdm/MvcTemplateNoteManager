using System;
using System.Collections.Generic;

namespace MvcTemplateNoteManager.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Models.Task> Tasks { get; set; }
        public DateTime Date { get; set; }
    }
}
