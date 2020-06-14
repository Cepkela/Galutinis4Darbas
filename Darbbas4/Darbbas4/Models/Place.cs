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

        public string endPoint { get; set; }

        public double distance { get; set; }

        public ArrayList itemList = new ArrayList();

        public Place()
        {

        }
        public Place(string startPoint, string endPoint, double distance, string startPointID, string endPointID)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.distance = distance;

        }
    }
}