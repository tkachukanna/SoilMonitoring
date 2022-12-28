using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class SoilMonitoring
    {
        public int IdSoilMonitoring { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Director { get; set; }
        public IEnumerable<Area> Areas { get; set; }

    }
}
