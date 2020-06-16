using Microsoft.VisualStudio.TestTools.UnitTesting;
using Darbbas4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbbas4.Models.Tests
{
    [TestClass()]
    public class PlaceTests
    {
        [TestMethod()]
        public void PlaceTest()
        {
            Place p = new Place();
            p.StartPoint = "Vilnius";
            string xpResult = "Vilnius";
            Assert.AreEqual(p.StartPoint, xpResult);
            return;
        }
        [TestMethod()]
        public void PlaceTest1()
        {
            Place p = new Place();
            p.StartLink = "http";
            string xpResult = "http";
            Assert.AreEqual(p.StartLink, xpResult);
            return;
        }
        [TestMethod()]
        public void PlaceTest2()
        {
            Place p = new Place();
            p.EndPoint = "Kaunas";
            string xpResult = "Kaunas";
            Assert.AreEqual(p.EndPoint, xpResult);
            return;
        }
        [TestMethod()]
        public void PlaceTest3()
        {
            Place p = new Place();
            p.EndLink = "s/";
            string xpResult = "s/";
            Assert.AreEqual(p.EndLink, xpResult);
        }
        [TestMethod()]
        public void PlaceTest4()
        {
            Place p = new Place();
            p.Distance = 1000;
            double xpResult = 1000;
            Assert.AreEqual(p.Distance, xpResult);
        }
        [TestMethod()]
        public void PlaceTest5()
        {
            bool testas = false;
            Place p = new Place();
            p.ItemList.Add("Vingio.g");
            List<string> Gatves = new List<string>();
            Gatves.Add("Vingio.g");
            for (int i = 0; i < p.ItemList.Count; i++)
            {
                if (p.ItemList[i]!=Gatves[i])
                {
                    testas = true;
                }
            }
            Assert.AreEqual(false, testas);
        }
    }
}