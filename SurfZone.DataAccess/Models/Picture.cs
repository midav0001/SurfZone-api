using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SurfZone.DataAccess.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public byte[] Data { get; set; }

        public int? ProductId { get; set; }

        public Product Product { get; set; }
    }
}
