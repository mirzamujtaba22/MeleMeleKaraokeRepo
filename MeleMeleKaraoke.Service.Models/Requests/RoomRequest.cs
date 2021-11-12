using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.Service.Models.Requests
{
   public class RoomRequest
    {
        public int MinPerson { get; set; }

        public int MaxPerson { get; set; }

        public decimal BasePrice { get; set; }
        public int RoomID { get; set; }
        public string Name { get; set; }
    }
}
