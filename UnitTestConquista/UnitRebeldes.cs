using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conquista.modelos;
namespace UnitTestConquista
{
    [TestClass]
    public class UnitRebeldes
    {
        private Rebeldes rebelde = new Rebeldes("ricardo");
        [TestMethod]
        public void TestGetName()
        {
            string nomr = "ricardo";
            Assert.AreEqual(nomr, rebelde.GetName());
        }

        [TestMethod]
        public void TestSetime() {
            rebelde.SetDate(new System.DateTime(19, 02, 02, 20, 20, 20));
        }

        [TestMethod]
        public void TestGettime() {
            Assert.AreEqual(new System.DateTime(19, 02, 02, 20, 20, 20), rebelde.GetDate());
        }
    }
}
