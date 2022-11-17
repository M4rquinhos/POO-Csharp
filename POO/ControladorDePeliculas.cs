﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ControladorDePeliculas
    {
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        public ControladorDePeliculas(IAlmacenadorArchivos almacenadorArchivos)
        {
            this.almacenadorArchivos = almacenadorArchivos;
        }

        public void GuardarPoster(string poster)
        {
            
            almacenadorArchivos.Guardar(poster);
        }

        public void BorrarPoster(string UrlPoster)
        {
            almacenadorArchivos.Borrar(UrlPoster);
        }
    }
}
