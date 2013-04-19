using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Anotador_Boliche
{
    [TestClass]
    public class MarcadorUnitTesting
    {
        [TestMethod]
        public void Posee_10_frame()
        {
            Marcador jugador = new Marcador();
            string[] lanzamientos = new string[] { "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0" };
            jugador.generarLanzamientos(lanzamientos);
            Assert.AreEqual(10, jugador.Turnos.Count()); //Posee 10 Turnos?
        }
        [TestMethod]
        public void genero_acumulado()
        {
            Marcador jugador = new Marcador();
            string[] lanzamientos = new string[] { "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2" };
            jugador.generarLanzamientos(lanzamientos);
            jugador.generarAcumulado();
            Assert.AreEqual(40, jugador.Turnos[9].acumulado); //El acomulado deberia se 20 
        }
    }
}
