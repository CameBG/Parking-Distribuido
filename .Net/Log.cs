using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clienteSD
{
    class Log
    {
        private static string getFechaUTC()
        {
            return DateTime.UtcNow.ToString();
        }

        public static void EscribirSonda(String datos, String usuario, String ip)
        {
            using (System.IO.StreamWriter sw = File.AppendText(usuario + "log.txt"))
            {
                string fecha = getFechaUTC();
                sw.WriteLine("Usuario: " + usuario + ", IP de la sonda: " + ip + ", Fecha: " + fecha + datos);
            }
        }
        public static void Escribir(String datos, String usuario)
        {
            using (System.IO.StreamWriter sw = File.AppendText(usuario + "log.txt"))
            {
                string fecha = getFechaUTC();
                sw.WriteLine("Usuario: " + usuario + ", Fecha: " + fecha + ", " + datos);
            }
        }
    }
}
