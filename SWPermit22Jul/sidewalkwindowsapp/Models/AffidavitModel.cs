using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkWindowsApp.Models
{
    public class AffidavitDocHistory
    {
        public string Type { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string User { get; set; }
    }


    public class RepairItemModel
    {
        public string Action { get; set; }
        public string Print { get; set; }
        public string UnitDescription { get; set; }
        public string ShortDescription { get; set; }
        public bool Flag { get; set; }
    }
}
