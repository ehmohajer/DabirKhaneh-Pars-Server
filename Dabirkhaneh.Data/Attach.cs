using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class Attach : BaseEntity<string>
    {
        public Attach()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Alt { get; set; }
        public string Description { get; set; }
        [Required]
        public byte Type { get; set; }

        [Required]
        public string LetterID { get; set; }
        public LetterIn LetterIn { get; set; }
        public LetterOut LetterOut { get; set; }
        public LetterInter LetterInter { get; set; }
    }
}
