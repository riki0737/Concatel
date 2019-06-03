using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conquista.modelos;
namespace UnitTestConquista
{
    [TestClass]
    public class UnitPlaneta
    {
        Planeta planeta = new Planeta("Veronis");
        [TestMethod]
        public void TestGetNom()
        {
            Assert.AreEqual("venoris", planeta.GetNom());

        }

        [TestMethod]
        public void setRebel ()
        {
            planeta.SetRebel("Ricardo", System.DateTime.Now);
        }

        [TestMethod]
        public void TestBuscarRebel() {
            setRebel();
            Assert.AreEqual(true, planeta.BuscarRebel("Riacrdo"));
        }

        public void TestMostrar()
        {
            setRebel();
            planeta.MostrarRebeldes();
        }

    }
}
