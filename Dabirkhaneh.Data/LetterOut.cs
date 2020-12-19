using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class LetterOut : BaseEntity<string>
    {
        public LetterOut()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime Date_Enter { get; set; }
        public DateTime Date_Reg { get; set; }
        public string Details { get; set; }
        public bool Remove { get; set; }
        public int SectionId_In { get; set; }

        public int SectionId_Out { get; set; }
        public Section Section { get; set; }

        public int TArchiveId { get; set; }
        public TArchive TArchive { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Attach> Attaches { get; set; }
    }
}
