namespace DotnetBasicExercises
{
    public class Exercise9: IExercise
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el numerador del primer número: ");
                    int numerator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el denominador del primer número: ");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el numerador del segundo número: ");
                    int numerator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el denominador del segundo número: ");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (denominator1 != 0 && denominator2 != 0)
                    {
                        int diff_numerators = numerator1 * denominator2 - numerator2 * denominator1;

                        if (diff_numerators != 0)
                        {
                            int new_denominator = denominator1 * denominator2;
                        Console.WriteLine($"La diferencia de las fracciones es: {diff_numerators}/{new_denominator}");
                        }
                        else
                        {
                            Console.WriteLine("La diferencia de las fracciones es: 0");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El valor de los denominadores debe ser diferente de cero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Los valores ingresados deben ser números enteros. Por favor, intenta de nuevo.");
                }
            }
        }
    }
}
