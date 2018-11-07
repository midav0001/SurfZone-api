using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurfZone.DataAccess.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public Picture Picture { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }
    }
}
