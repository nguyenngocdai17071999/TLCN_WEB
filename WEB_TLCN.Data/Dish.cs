using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WEB_TLCN.Data
{
    public class Dish
    {
        [Key]
        public int Dish_ID       {get;set;}
        public string DishName      {get;set;}
        public int DishPrice     {get;set;}
        public string DishPicture   {get;set;}
        public int DishType_ID   {get;set;}
        [ForeignKey("DishType_ID")]
        public DishType DishType { get; set; }
        public int Menu_ID       { get; set; }
        [ForeignKey("Menu_ID")]
        public Menu Menu { get; set; }
    }
}
