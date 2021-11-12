using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class PackageDesert:BaseEntity
    {
        public int RoomID;
        public int DesertID;


        public Room Room;
        public Deserts Deserts;
    }
}
