// See https://aka.ms/new-console-template for more information
using POO;
using System.Net.WebSockets;
using Utilidades;

Console.WriteLine("Hello, World!");


var carro = new Carro("Toyota");
//carro.Marca = "Toyota";
carro.EncenderRadio();


var camion = new Camion("Torton");
//camion.Marca = "Torton";
//camio.EncenderRadio(); //No se puede acceder a al metodo "EncederRadio", porque ese metodo sólo le pertence a la clase Carro

var bicicleta = new Bicicleta("Scott");
//bicicleta.Marca = "Scott";


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


var carroo = new Carro("Toyota");
var carroString = carroo.ToString();
Console.WriteLine(carroString);


AceptoCualquierParametro(carroo);
AceptoCualquierParametro(camion);
AceptoCualquierParametro(23);

void AceptoCualquierParametro(object objeto) 
{

    Console.WriteLine("---Inicio del metodo---");

    //var carro2 = objeto as Carro;   //(Carro)objeto;
    if (objeto is Carro carro2)
    {
        Console.WriteLine("El objeto es un carro");
        carro2.SonarClaxon();
    }
    else if (objeto is Camion camion)
    {
        Console.WriteLine("El objeto es un camion");
        camion.DarReversa();
    }
    else if (objeto is int entero)
    {
        Console.WriteLine("El objeto es un entero");
    }
    else
    {
        Console.WriteLine("El objeto no es un carro");
    }

    Console.WriteLine("---Fin del metodo---");

}



var clasePublicaDePrueba = new ClasePublicaDePrueba();
clasePublicaDePrueba.PropiedadPublica = 1;
//clasePublicaDePrueba.MetodoPublico(); //No se puede acceder debido a su proteccion (desde la misma clase si se puede)




  