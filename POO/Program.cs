// See https://aka.ms/new-console-template for more information
using POO;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");


var carro = new Carro();
carro.Marca = "Toyota";
carro.EncenderRadio();


var camion = new Camion();
camion.Marca = "Torton";
//camio.EncenderRadio(); //No se puede acceder a al metodo "EncederRadio", porque ese metodo sólo le pertence a la clase Carro

var bicicleta = new Bicicleta();
bicicleta.Marca = "Scott";


LeerMarca(carro);
LeerMarca(camion);
LeerMarca(bicicleta);


void LeerMarca(Vehiculo vehiculo) 
{
    var mensaje = $"Leyendo la marca {vehiculo.Marca} del vehiculo del tipo {vehiculo}";
    Console.WriteLine(mensaje);
}

Console.WriteLine("Carro: ");
carro.DarReversa();
Console.WriteLine("--");

Console.WriteLine("Camion: ");
camion.DarReversa();
Console.WriteLine("--");

Console.WriteLine("Bicicleta: ");
bicicleta.DarReversa();
Console.WriteLine("--");


//Para evitar que se pueda instanciar la clase padre que hereda a los otras, se puede convertir en una clase asbtracta (*revisar Vehiculo.cs)
//var vehiculo =  new Vehiculo(); //Error


carro.Acelerar(200);
Console.WriteLine(carro.Velocidad);
Console.WriteLine($"La velocidad del carro es: {carro.Velocidad}");