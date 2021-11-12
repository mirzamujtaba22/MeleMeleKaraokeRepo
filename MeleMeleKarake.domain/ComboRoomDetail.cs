using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class ComboRoomDetail
    {
        public int ID { get; set; }


        public int RoomID { get; set; }
        public Room Room;
        public int ComboProductID { get; set; }
        public ComboProduct ComboProduct;
    }
}
