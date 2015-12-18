using System;
using Alskami.Simulators;
using HelicopterOfTestProject.Alskami.Helicopters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelicopterOfTestProject.Alskami.Test
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string namn = "Klas";

            var simulator = HelicopterFactory.GetDefaultHelicopter();
            simulator.GetSignupController().Signup(namn, "pw");
            Assert.AreEqual("Klas", namn);

        }
    }
}
