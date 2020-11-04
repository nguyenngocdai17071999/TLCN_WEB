using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB_TLCN.Data
{
    public class BusinessType
    {
        [Key]
        public int BusinessTypeID { get; set; }
        public string BusinessTypeName { get; set; }
    }
}
