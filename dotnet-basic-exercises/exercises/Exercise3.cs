namespace DotnetBasicExercises
{
    public class Exercise3
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa un número: ");
                    double input = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (input >= 0)
                    {
                        Console.WriteLine($"La raíz del número {input} es: {Math.Sqrt(input) }");
                    }
                    else
                    {
                        Console.WriteLine($"El cuadrado del número {input} es: {Math.Pow(input, 2) }");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado es inválido. Por favor, intenta de nuevo.");
                }
            }
        }
    }
}