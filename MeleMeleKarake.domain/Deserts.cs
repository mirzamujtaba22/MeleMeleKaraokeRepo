using MeleMeleKarake.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeleMeleKaraoke.domain
{
   public class Deserts:BaseEntity
    {
        public ICollection<PackageDesert> PackageDeserts;

    }
}
