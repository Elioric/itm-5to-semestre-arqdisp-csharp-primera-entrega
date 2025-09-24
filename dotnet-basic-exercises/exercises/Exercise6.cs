namespace DotnetBasicExercises
{
    public class Exercise6: IExercise
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa tu salario anual: ");
                    double anualWage = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (anualWage > 0)
                    {
                        double tax = anualWage > 12000 ? 0.15 * (anualWage - 12000) : 0;
                        if (tax == 0)
                        {
                            Console.WriteLine("No debe impuestos.");
                            break;
                        }

                        Console.WriteLine($"El impuesto a pagar es: {Math.Round(tax, 2)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El valor del salario debe ser mayor a cero.");
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
