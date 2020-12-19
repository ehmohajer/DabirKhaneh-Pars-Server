using Dabirkhaneh.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data
{
    public class Photo:BaseEntity<int>
    {
        public Photo()
        {
            Id = new int();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Alt { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsMain { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
