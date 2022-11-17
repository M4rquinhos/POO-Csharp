using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class AlmacenadorArchivosAzure : IAlmacenadorArchivos  
    {
        public void Borrar(string UrlArchivo)
        {
            Console.WriteLine("Borrando el archivo Azure");
        }

        public string Guardar(string archivo)
        {
            Console.WriteLine("Guardando archivos en Azure");
            return "URL del archivo";
        }
    }
}
