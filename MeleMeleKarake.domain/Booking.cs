using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class Booking:BaseEntity
    {
        public int RoomID;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Room Room;

    }
}
