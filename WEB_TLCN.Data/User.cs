using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WEB_TLCN.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int Phone { get; set; }
        public int Address { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public int Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public int Email { get; set; }
        public int Picture { get; set; }
        public int Sex { get; set; }
        public int Birthday { get; set; }
        [ForeignKey("UserTypeID")]
        public UserType UserType { get; set; }
    }
}
