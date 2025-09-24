namespace DotnetBasicExercises
{
    public class Exercise2
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (num1 >= num2)
                    {
                        Console.WriteLine($"El número {num1} duplicado es: {num1 * 2}");
                    }
                    else
                    {
                        Console.WriteLine($"El número {num2} triplicado es: {num2 * 3}");
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
