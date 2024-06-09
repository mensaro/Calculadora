namespace proyectogitmensaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: División por cero no es permitida.");
                return 0;
            }
            return a / b;
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    break;
                }

                Console.Write("Introduzca el primer operando: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca el segundo operando: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = Sumar(a, b);
                        Console.WriteLine($"Resultado: {a} + {b} = {resultado}");
                        break;
                    case 2:
                        resultado = Restar(a, b);
                        Console.WriteLine($"Resultado: {a} - {b} = {resultado}");
                        break;
                    case 3:
                        resultado = Multiplicar(a, b);
                        Console.WriteLine($"Resultado: {a} * {b} = {resultado}");
                        break;
                    case 4:
                        resultado = Dividir(a, b);
                        if (b != 0)
                        {
                            Console.WriteLine($"Resultado: {a} / {b} = {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
