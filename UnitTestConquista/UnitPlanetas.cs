using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conquista.modelos;
namespace UnitTestConquista
{
    [TestClass]
    public class UnitPlanetas
    {
        Planetas planetas = new Planetas();
        [TestMethod]
        public void AddPlaneta() 
        {
            planetas.AddPlaneta("veronis");

        }

        public void AddRebel()
        {
            planetas.AddRebelde();
        }

        [TestMethod]
        public void TestMostrar() {
            AddPlaneta();
            planetas.MostrarPlanetas();
        }

        [TestMethod]
        public void TestFind() {
            AddRebel();
            planetas.findRebel();
        }
    }
}
