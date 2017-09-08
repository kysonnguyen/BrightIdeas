using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity
    {
        [Key]
        public int id {get; set;}
        
        [Required]
        [MinLength(2, ErrorMessage = "Minimum 2 characters required")]
        public string name { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Minimum 1 characters required")]
        public string alias { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string email { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Password must be at least 8 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string confirmation { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        // public List<Like> likes {get;set;}
    }
}