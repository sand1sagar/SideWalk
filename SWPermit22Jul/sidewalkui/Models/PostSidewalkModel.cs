﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SidewalkUI.Models
{
    public class PostSidewalkModel
    {
        public Guid PropertyID { get; set; }
        public string OwnerName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string PropertyType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    //public partial class sw_posting
    //{
    //    public string fname { get; set; }
    //    public string inspector_name { get; set; }
    //}
}