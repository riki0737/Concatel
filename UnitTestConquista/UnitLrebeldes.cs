using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conquista.modelos;
namespace UnitTestConquista
{
    [TestClass]
    public class UnitLrebeldes
    {
        Lrebeldes lre = new Lrebeldes();
        [TestMethod]
        public void TestAddrebel()
        {
            Rebeldes r = new Rebeldes("Ricardo");
            lre.AddRebel(r);
        }

        [TestMethod]
        public void TestFind()
        {
            TestAddrebel();
            Assert.AreEqual(true, lre.FindRebel("Ricardo"));
        }

        [TestMethod]
        public void Mostrar()
        {
            TestAddrebel();
            lre.MostrarRebeldes();
        }
    }
}
