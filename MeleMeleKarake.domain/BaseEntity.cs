using System;

namespace MeleMeleKarake.domain
{
    public class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
