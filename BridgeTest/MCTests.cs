using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLibrary;

namespace Bridge.Test
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void Price_ShouldReturn120()
        {
            var mc = new MC();
            Assert.AreEqual(120, mc.Price());
        }

        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            var mc = new MC();
            Assert.AreEqual("MC", mc.VehicleType());
        }
    }
}
