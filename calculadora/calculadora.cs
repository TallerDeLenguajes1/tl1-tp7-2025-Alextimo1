// Línea 1: declaramos el espacio de nombres
namespace EspacioCalculadora
{
    public class Calculadora
    {
        // Campo privado para guardar el resultado
        private double dato;

        // Constructor opcional (inicia en cero)
        public Calculadora()
        {
            dato = 0;
        }

        // Método para sumar
        public void Sumar(double termino)
        {
            dato += termino;
        }

        // Método para restar
        public void Restar(double termino)
        {
            dato -= termino;
        }

        // Método para multiplicar
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        // Método para dividir (con validación por cero)
        public void Dividir(double termino)
        {
            if (termino != 0)
                dato /= termino;
            else
                Console.WriteLine("Error: No se puede dividir por cero.");
        }

        // Método para reiniciar el dato
        public void Limpiar()
        {
            dato = 0;
        }

        // Propiedad de solo lectura para obtener el resultado actual
        public double Resultado
        {
            get { return dato; }
        }
    }
}
