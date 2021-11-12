using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class CartPackageItem
    {
        public int ID { get; set; }


        public int RoomID { get; set; }
        public Room Room;

        public int PackageID { get; set; }
        public Package Package;

        public decimal BasePrice { get; set; }
    }
}
