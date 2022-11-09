using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vehiculo
    {
        public string? Marca { get; set; }
        public int AñoCreacion { get; set; }
    }

    internal class Carro : Vehiculo
    {
        public void EncenderRadio() 
        {
            Console.WriteLine("Encendiendo la Radio, pa");
        }

    }

    internal class Camion : Vehiculo
    {

    }

}
