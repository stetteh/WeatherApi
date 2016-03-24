using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApi;

namespace weatherapitest
{
    [TestClass]
    public class WeatherManagerTest
    {
        [TestMethod]
        public void LookUpTypeDetectsZip()
        {
            var manager = new WeatherManager();

            var result = manager.FigureOutLookupType("72223");
            Assert.AreEqual(LookupType.Zip, result);

            result = manager.FigureOutLookupType("72223-1234");
            Assert.AreEqual(LookupType.Zip, result);

            result = manager.FigureOutLookupType("722");
            Assert.AreNotEqual(LookupType.Zip, result);

            result = manager.FigureOutLookupType("");
            Assert.AreNotEqual(LookupType.Zip, result);

        }
    }
}
