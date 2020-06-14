using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Darbbas4.Models
{
    public class Place
    {
        public string startPoint { get; set; }
        public string startLink { get; set; }
        public string endPoint { get; set; }
        public string endLink { get; set; }

        public double distance { get; set; }

        public ArrayList itemList = new ArrayList();

        public Place()
        {

        }
        public Place(string startPoint, string endPoint, double distance)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.distance = distance;

        }
    }
}