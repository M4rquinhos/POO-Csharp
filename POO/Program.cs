// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Hello, World!");


var carro = new Carro();
carro.Marca = "Toyota";
carro.EncenderRadio();


var camion = new Camion();
camion.Marca = "Torton";
//camio.EncenderRadio(); //No se puede acceder a al metodo "EncederRadio", porque ese metodo sólo le pertence a la clase Carro