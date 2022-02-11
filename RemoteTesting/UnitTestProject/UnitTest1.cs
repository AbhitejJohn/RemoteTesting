using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace UnitTestProject
{
    [TestClass]
    public class EnvironmentTests
    {
        [TestMethod]
        public void IsWindows()
        {
            Assert.AreEqual("Win32NT", Environment.OSVersion.Platform.ToString());
        }

        [TestMethod]
        public void IsLinux()
        {
            Assert.AreEqual("Unix", Environment.OSVersion.Platform.ToString());
        }
    }
}
