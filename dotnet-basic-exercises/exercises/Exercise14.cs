namespace DotnetBasicExercises
{
    public class Exercise14: IExercise
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa un número: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    int factorial = 1;

                    if (num >= 0)
                    {
                        for (int i = num; i > 0; i--)
                            factorial *= i;

                        Console.WriteLine($"El factorial de {num} es: {factorial}");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("el número debe ser un entero positivo.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado debe ser un entero positivo.");
                }
            }
        }
    }
}
