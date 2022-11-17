using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class OtroLugar
    {

        public void Procesar()
        {
            var almacenador = new AlmacenadorArchivosAzure();
            var controladorDePeliculas = new ControladorDePeliculas(almacenador);
        }


    }
}
