namespace DotnetBasicExercises
{
    public class Exercise1: IExercise
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa un número positivo: ");
                    double input = Validator.StringIsDouble(Console.ReadLine());
                    Console.WriteLine("");
                    
                    if (input >= 0)
                    {
                        double result = Math.Pow(input, 2);
                        Console.WriteLine($"El número {input} elevado al cuadrado es: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Número negativo.");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado es inválido. Por favor, ingresa un número positivo.");
                }
            }
        }
    }
}