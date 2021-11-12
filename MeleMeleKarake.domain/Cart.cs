using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
