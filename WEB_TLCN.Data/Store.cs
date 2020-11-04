using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WEB_TLCN.Data
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }

        public int StoreAddress { get; set; }

        public int StorePicture { get; set; }

        public int OpenTime { get; set; }

        public int CLoseTime { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("ProvinceID")]
        public Province Province { get; set; }

        [ForeignKey("MenuID")]
        public Menu Menu { get; set; }

        [ForeignKey("BusinessTypeID")]
        public BusinessType BusinessType { get; set; }

        public int RatePoint { get; set; }
    }
}
