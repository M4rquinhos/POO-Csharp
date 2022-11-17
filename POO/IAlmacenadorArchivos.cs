using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IAlmacenadorArchivos
    {
        public string Guardar(string archivo);
        void Borrar(string UrlArchivo);
       
    }
}
