using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WEB_TLCN.Data
{
    public class Comment
    {
        [Key]
        public int CommentID            { get; set; }
        public int Content              { get; set; }
        public DateTime Date                 { get; set; }
        public string Image                { get; set; }

        [ForeignKey("UserID")]
        public User User                { get; set; }

        [ForeignKey("StoreID")]
        public Store Store              { get; set; }


        public int ParentComment_ID  { get; set; }


    }
}
