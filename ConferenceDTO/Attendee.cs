﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Attendee : BaseEntity
    {

        [Required]
        [StringLength(200)]
        public virtual string FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public virtual string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(256)]
        public virtual string EmailAddress { get; set; }
    }

}
