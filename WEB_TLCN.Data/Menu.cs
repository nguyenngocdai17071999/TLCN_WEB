using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB_TLCN.Data
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public int Store_ID { get; set; }
        public string MenuName { get; set; }
    }
}
