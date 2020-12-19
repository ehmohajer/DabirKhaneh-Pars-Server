﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dabirkhaneh.Data.DataBaseContext
{
    public class User:BaseEntity<string>
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        [Required]
        public string Role { get; set; }

        [Required]
        public bool IsActive { get; set; }
        public bool Status { get; set; }

        [Required]
        public short SectionId { get; set; }
        public Section Section { get; set; }

        public ICollection<Photo> Photos { get; set; }
        public ICollection<LetterIn> LetterIns { get; set; }
        public ICollection<LetterOut> LetterOuts { get; set; }
        public ICollection<LetterInter> LetterInters { get; set; }

    }
}
