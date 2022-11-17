namespace Utilidades
{
    public class ClasePublicaDePrueba
    {
        public int PropiedadPublica { get; set; }
        internal int PropiedadInterna { get; set; }
        protected int PropiedadProtegida { get; set; }

        public void MetodoPublico()
        {
            PropiedadInterna = 1;
            PropiedadProtegida = 2;
            Console.WriteLine("Soy un método publico de otro proyecto");
            MetodoPrivate();
        }


        private void MetodoPrivate()
        {
            var claseInterna = new ClaseInterna();
        }


        private class ClaseInterna 
        {
            
        }
    }
}