using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_TopSpotsAPI.Models
{
    public class TopSpot
    {
        public object Name { get; internal set; }
        public object Description { get; internal set; }
        public object Location { get; internal set; }
    }
}