using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class Organ : BaseEntity<int>
    {
        public Organ()
        {
            Id = new int();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Title { get; set; }

        public ICollection<OrganPerson> OrganPersons { get; set; }
        public ICollection<LetterIn> LetterIns { get; set; }
        public ICollection<LetterOut> LetterOuts { get; set; }
    }
}
