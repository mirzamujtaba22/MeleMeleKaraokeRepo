using MeleMeleKaraoke.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKarake.domain
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Min_Person { get; set; }

        public int Max_Person { get; set; }

        public decimal base_price { get; set; }

        public ICollection<RoomDetails> RoomDetails;

        public ICollection<PackageDesert> RoomPackageDeserts;
    }
}
