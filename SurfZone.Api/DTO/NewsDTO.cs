using SurfZone.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfZone.Api.DTO
{
    public class NewsDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public Picture Picture { get; set; }
    }
}