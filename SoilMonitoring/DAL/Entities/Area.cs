using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Area
    {
        public int IdArea { get; set; }
        public string Type { get; set; }
        public string Condition { get; set; }
        public int IdSoilMonitoring { get; set; }
        public SoilMonitoring SoilMonitoring { get; set; }

    }
}
