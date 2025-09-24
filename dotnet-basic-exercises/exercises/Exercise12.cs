namespace DotnetBasicExercises
{
    public class Exercise12: IExercise
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
                    Console.WriteLine("Ingresa el tercer número: ");
                    double num3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el cuarto número: ");
                    double num4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el quinto número: ");
                    double num5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    double[] numbers = { num1, num2, num3, num4, num5 };

                    double? minimum = null;

                    for (int i = 0; i <= 4; i++)
                    {
                        if (minimum is null)
                            minimum = numbers[i];
                        else if (numbers[i] < minimum)
                            minimum = numbers[i];
                    }

                    Console.WriteLine($"El menor de los números es: {minimum}");
                    
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
