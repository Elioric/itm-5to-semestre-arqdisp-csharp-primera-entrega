namespace DotnetBasicExercises
{
    public class Exercise4
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el radio del círculo: ");
                    double radio= double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (radio >= 0)
                    {
                        Console.WriteLine($"El perímetro del círculo de radio {radio} es: {Math.Round(2 * Math.PI * radio, 2)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El radio debe ser un valor positivo.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado es inválido. Por favor, intenta de nuevo.");
                }
            }
        }
    }
}
