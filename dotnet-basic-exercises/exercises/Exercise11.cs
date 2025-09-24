namespace DotnetBasicExercises
{
    public class Exercise11
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
                    Console.WriteLine("");

                    Console.WriteLine($"El promedio de los números es: {(num1 + num2 + num3 + num4) / 4}");

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
