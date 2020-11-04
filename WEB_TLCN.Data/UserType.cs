using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB_TLCN.Data
{
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
    }
}
