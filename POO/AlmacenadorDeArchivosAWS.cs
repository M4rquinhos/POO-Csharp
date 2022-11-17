using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class AlmacenadorDeArchivosAWS : IAlmacenadorArchivos
    {
        public void Borrar(string UrlArchivo)
        {
            Console.WriteLine("Borrando el archivo AWS");
        }

        public string Guardar(string archivo)
        {
            Console.WriteLine("Guardando archivos en AWS");
            return "URL del archivo en AWS";
        }
    }
}
