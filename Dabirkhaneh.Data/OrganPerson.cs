using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class OrganPerson : BaseEntity<int>
    {
        public OrganPerson()
        {
            Id = new int();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string PersonName { get; set; }

        public int OrganId { get; set; }
        public Organ Organ { get; set; }
    }
}
