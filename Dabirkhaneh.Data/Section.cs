using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class Section:BaseEntity<int>
    {
        public Section()
        {
            Id = new int();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Title { get; set; }

        public int SectionId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


        public ICollection<LetterInter> LetterInters { get; set; }
    }
}
