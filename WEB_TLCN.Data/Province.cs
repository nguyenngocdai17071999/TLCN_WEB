using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB_TLCN.Data
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
    }
}
