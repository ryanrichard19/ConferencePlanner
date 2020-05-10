using System;
using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Track : BaseEntity
    {

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }

}
