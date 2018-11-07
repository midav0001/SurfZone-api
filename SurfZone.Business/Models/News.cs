using System;
using System.Collections.Generic;
using System.Text;

namespace SurfZone.Business.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public byte[] Picture { get; set; }

        public DateTime CreateionDate { get; set; } 

        //public User USer { get; set; }
    }
}
