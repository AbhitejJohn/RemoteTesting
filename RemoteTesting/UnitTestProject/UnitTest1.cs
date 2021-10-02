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
            // Temporarily workaround to ensure that the debugger has enough time to attach to the process.
            Thread.Sleep(2 * 1000);

            Assert.AreEqual("Unix", Environment.OSVersion.Platform.ToString());
        }
    }
}
