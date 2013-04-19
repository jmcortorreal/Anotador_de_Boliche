using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Anotador_Boliche
{
     [TestClass]
    public class ManejadorUnitTesting
    {
         string s = "C:\\Users\\jmcor_000\\Documents\\GitHub\\Anotador_de_Boliche\\AnotadorBoliche\\AnotadorBoliche\\prueba_3_Archivo_Lleno.txt";
         [TestMethod]
         public void Split_Arr()
         {
            Manejador manejador = new Manejador(s);
            for (int i = 0; i < manejador.PrimerJugador.Turnos.Count(); i++)
            {
                for (int j = 0; j < manejador.PrimerJugador.Turnos[i].Lanzamientos.Count(); j++)
                {
                    Assert.AreEqual(manejador.PrimerJugador.Turnos[i].Lanzamientos[j].lanzamiento, "1");
                }
            }
            for (int i = 0; i < manejador.SegundoJugador.Turnos.Count(); i++)
            {
                for (int j = 0; j < manejador.SegundoJugador.Turnos[i].Lanzamientos.Count(); j++)
                {
                    Assert.AreEqual(manejador.SegundoJugador.Turnos[i].Lanzamientos[j].lanzamiento, "2");
                }
            }
         }
         [TestMethod]
         public void Comprobar_Acomulado()
         {
             string s = "C:\\Users\\jmcor_000\\Documents\\GitHub\\Anotador_de_Boliche\\AnotadorBoliche\\AnotadorBoliche\\prueba_2_Archivo_Lleno.txt";
             Manejador manejador = new Manejador(s);
             Assert.AreEqual(manejador.PrimerJugador.Turnos[9].acumulado, 130);
             Assert.AreEqual(manejador.SegundoJugador.Turnos[9].acumulado, 152);
         }
    }
}
