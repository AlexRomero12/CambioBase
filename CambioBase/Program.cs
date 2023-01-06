namespace BaseConversion
{
    class Program
    {
        static void Main()
        {
            int x, k;

            // Obtener y validar el valor de x
            Console.WriteLine("Ingresa el valor de x en base 10: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Por favor, ingresa un número válido para x.");
            }

            // Obtener y validar la base k
            Console.WriteLine("Ingresa la base k a la que quieres convertir x: ");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Por favor, ingresa un número válido para k.");
            }

            // Realizar la conversión a base k
            List<int> conversion = new List<int>();
            while (x > 0)
            {
                conversion.Add(x % k);
                x /= k;
            }

            // Mostrar el resultado
            conversion.Reverse();
            Console.WriteLine("La representación de x en base " + k + " es: " + string.Join("", conversion));
        }
    }
}