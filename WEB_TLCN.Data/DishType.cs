using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB_TLCN.Data
{
    public class DishType
    {
        [Key]
        public int DishType_ID { get; set; }
        public string DishyTypeName { get; set; }
    }
}
