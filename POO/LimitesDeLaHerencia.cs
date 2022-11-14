using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /*
        No se pude herdar de 2 clases diferentes
        public class Derivada: Base1, Base2.

        A menos que se haga una cadena de herencia, pero no se recomienda

     */

    public class Base1 
    {
        public int PropiedadBase1 { get; set; }
    }  


    public class Base2 : Base1
    {
        public int PropiedadBase2 { get; set; }
    }

    public class Derivada : Base2
    {
        void Metodo() 
        {
            PropiedadBase1 = 2;
            PropiedadBase2 = 1;
        }   
    }
}
