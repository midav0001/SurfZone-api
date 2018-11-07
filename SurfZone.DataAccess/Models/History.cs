using System;
using System.Collections.Generic;
using System.Text;

namespace SurfZone.DataAccess.Models
{
    public class History
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public Order Order { get; set; }
    }
}
