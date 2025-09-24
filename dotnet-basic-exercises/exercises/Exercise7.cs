namespace DotnetBasicExercises
{
    public class Exercise7
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el primer número: ");
                    double dividend = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo número: ");
                    double divisor = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (divisor != 0)
                    {
                        double remainder = dividend % divisor;
                        Console.WriteLine($"El residuo de la división {dividend}/{divisor} es: {remainder}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El divisor debe ser diferente de cero.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Uno de los valores ingresados es inválido. Por favor, intenta de nuevo.");
                }
            }
        }
    }
}
