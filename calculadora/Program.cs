using EspacioCalculadora;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        string opcion;
        double valor = 0;

        do
        {
            Console.WriteLine("\n--- CALCULADORA ---");
            Console.WriteLine("Resultado actual: " + calc.Resultado);
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");
            opcion = Console.ReadLine();

            if (opcion != "0" && opcion != "5")
            {
                Console.Write("Ingrese un número: ");
                double.TryParse(Console.ReadLine(), out valor);
            }

            switch (opcion)
            {
                case "1":
                    calc.Sumar(valor);
                    break;
                case "2":
                    calc.Restar(valor);
                    break;
                case "3":
                    calc.Multiplicar(valor);
                    break;
                case "4":
                    calc.Dividir(valor);
                    break;
                case "5":
                    calc.Limpiar();
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != "0");
    }
}
