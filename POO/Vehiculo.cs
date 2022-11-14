using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class  Vehiculo
    {

        public Vehiculo(string marca)
        {
            Marca = marca;
        }


        public string? Marca { get; set; }
        public int AñoCreacion { get; set; }
        public int Velocidad { get; private set; }
        public abstract int VelocidadMaxima { get;  }

        public virtual void DarReversa() 
        {
            Console.WriteLine("Dando revrsa -- Implementacion por defecto");
        }

        public abstract void SonarClaxon();

        internal void Acelerar(int incremento = 1 ) 
        {
            if (Velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("La velocidad maxima ya ha sido alcanzada");
                return;
            }
            else if (Velocidad + incremento > VelocidadMaxima) 
            {
                incremento = VelocidadMaxima - Velocidad;
            }
            Velocidad += incremento;
        }

    }

    internal class Carro : Vehiculo
    {
        public Carro(string marca) : base(marca)
        {
        }

        public override int VelocidadMaxima => 80;

        public void EncenderRadio() 
        {
            Console.WriteLine("Encendiendo la Radio, pa");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("claxon de carro");
        }
    }

    internal class Camion : Vehiculo, ICamion
    {
        public Camion(string marca) : base(marca)
        {
        }

        public override int VelocidadMaxima => 70;

        public override void DarReversa()
        {
            base.DarReversa();
            Console.WriteLine("BEEP * 3");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("Claxon de camion");
        }
    }

    internal class Bicicleta : Vehiculo
    {
        public Bicicleta(string marca) : base(marca)
        {
        }

        public override int VelocidadMaxima => 20;

        public override void SonarClaxon()
        {
            Console.WriteLine("Campana de bicicleta xd");
        }
    }


}
