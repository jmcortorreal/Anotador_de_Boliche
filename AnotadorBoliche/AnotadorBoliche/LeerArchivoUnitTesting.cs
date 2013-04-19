using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anotador_Boliche
{
    [TestClass]
    public class LeerArchivoUnitTesting
    {
        [TestMethod]
        public void Prueba_Leer_archivo_vacio()
        {
            string s = "C:\\Users\\jmcor_000\\Documents\\GitHub\\Anotador_de_Boliche\\AnotadorBoliche\\AnotadorBoliche\\prueba_1_Archivo_Vacio.txt";
            string[] returningData = LeerArchivo.Leer_Archivo(s);
            Assert.AreEqual(returningData, null);
        }
        [TestMethod]
        public void Prueba_Leer_archivo_lleno()
        {
            string s = "C:\\Users\\jmcor_000\\Documents\\GitHub\\Anotador_de_Boliche\\AnotadorBoliche\\AnotadorBoliche\\prueba_2_Archivo_Lleno.txt";
            string[] returningData = LeerArchivo.Leer_Archivo(s);
            Assert.AreEqual(returningData.Length, 42);
        }


    }
}
