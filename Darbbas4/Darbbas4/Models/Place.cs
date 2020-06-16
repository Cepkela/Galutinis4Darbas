using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Darbbas4.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Place
    {
        /// <summary>
        /// Išvykimo vieta
        /// </summary>
        public string StartPoint { get; set; }
        /// <summary>
        /// Išvykimo vietos linkas
        /// </summary>
        public string StartLink { get; set; }
        /// <summary>
        /// Galutinis taškas
        /// </summary>
        public string EndPoint { get; set; }
        /// <summary>
        /// Galutinio taško linkas
        /// </summary>
        public string EndLink { get; set; }
        /// <summary>
        /// Atstumas
        /// </summary>
        public double Distance { get; set; }
        /// <summary>
        /// Gatves
        /// </summary>
        public ArrayList ItemList = new ArrayList();

        /// <summary>
        /// Tuscias konstruktorius
        /// </summary>
        public Place()
        {
        }
        /// <summary>
        /// Kostruktorius su parametrais
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <param name="distance"></param>
        public Place(string startPoint, string endPoint, double distance)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Distance = distance;

        }
    }
}