using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
   public class Package:BaseEntity
    {
        public decimal Price { get; set; }

        public string Letters { get; set; }
        public string Package_Description { get; set; }

        public BookingDetails BookingDetails;
    }
}
