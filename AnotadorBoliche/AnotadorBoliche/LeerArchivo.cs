using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anotador_Boliche
{
    [Serializable()]
    public class InvalidFIleException : System.Exception
    {
        public InvalidFIleException() : base() { }
        public InvalidFIleException(string message) : base(message) { }
        public InvalidFIleException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an 
        // exception propagates from a remoting server to the client.  
        protected InvalidFIleException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
    class LeerArchivo
    {
        private LeerArchivo()
        {

        }
        static public string[] Leer_Archivo(string FileName)
        {
            List<string> Scores = new List<string>();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace(" ", "");
                    if (line_valid(line))
                    {
                        if (Convert.ToInt32(line) <= 10)
                        {
                            Scores.Add(line);
                        }
                    }
                }
            }
            try
            {
                if (Scores.Count() != 42)
                    throw new InvalidFIleException("El archivo no es valido");
            }
            catch (InvalidFIleException exp)
            {
                MessageBox.Show(exp.Message);
                return null;
            }
            return Scores.ToArray();
        }
        private static bool line_valid(string line)
        {
            string aceptado = "1234567890";
            for (int i = 0; i < line.Length; i++)
                if (!aceptado.Contains(line[i].ToString()))
                    return false;
            return true;
        }
    }
}
