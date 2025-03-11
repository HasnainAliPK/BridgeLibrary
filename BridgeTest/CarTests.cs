using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using BridgeLibrary;

namespace Bridge.Test
{
    [TestClass]
    public class CarTests
    {

        [TestMethod]
        public void Price_ShouldReturn230() 
        {
            var car = new Car();
            Assert.AreEqual(230, car.Price());
        }

        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        { 
            var car = new Car();
            Assert.AreEqual("Car", car.VehicleType());
        }
    }
}
