using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class BookingDetails
    {
        public int ID { get; set; }
        public int BookingID { get; set; }

        public int PackageID { get; set; }
        public Booking Booking { get; set; }
        public Package Package { get; set; }
    }
}
