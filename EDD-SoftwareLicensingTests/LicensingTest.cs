using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EDDSoftwareLicensingTests
{
    [TestClass]
    public class LicensingTest
    {
        [TestMethod]
        public void ActivateKeyTest()
        {
            EDDSoftwareLicensing.Licensing licensingModule = new EDDSoftwareLicensing.Licensing();

            licensingModule.Activate();

        }
    }
}
