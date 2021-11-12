using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKarake.domain
{
    public class RoomDetails:BaseEntity
    {
        public int RoomID { get; set; }
        ///<Summary>
        /// Day of week Enum
        ///</Summary>
        public int Day { get; set; }

        public DateTime OpenTime { get; set; }

        public DateTime CloseTime { get; set; }

        public Room Room;

    }
}
