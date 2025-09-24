namespace DotnetBasicExercises
{
    public class Exercise8: IExercise
    {
        public static void Run()
        {
            try
            {
                int sum = 0;

                for (int i = 1; i <= 50; i++)
                {
                    if (i % 2 == 0)
                        sum += i;

                }
                Console.WriteLine($"La suma de los números pares del 1 al 50 es: {sum}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error en la ejecucion.");
            }
        }
    }
}
