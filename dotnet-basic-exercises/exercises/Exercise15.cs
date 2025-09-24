namespace DotnetBasicExercises
{
    public class Exercise15
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa un número: ");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (num >= 10 && num <= 20)
                        Console.WriteLine($"El número {num} está en el rango de 10 a 20.");
                    else
                        Console.WriteLine($"El número {num} está fuera del rango de 10 a 20.");

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
