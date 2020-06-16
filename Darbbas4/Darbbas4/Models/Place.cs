using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Darbbas4.Models
{
    public class Place
    {
        public string StartPoint { get; set; }
        public string StartLink { get; set; }
        public string EndPoint { get; set; }
        public string EndLink { get; set; }

        public double Distance { get; set; }

        public ArrayList ItemList = new ArrayList();

        public Place()
        {

        }
        public Place(string startPoint, string endPoint, double distance)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Distance = distance;

        }
    }
}