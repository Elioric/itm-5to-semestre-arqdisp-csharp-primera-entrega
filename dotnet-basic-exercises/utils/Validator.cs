namespace DotnetBasicExercises
{
    public class Validator
    {
        public static int StringIsInt(string input)
        {
            while (true)
            {
                int result;
                if (int.TryParse(input, out result))
                    return result;
                else
                    Console.WriteLine("El valor ingresado no es un entero válido.");

                Console.Write("Ingrese un entero válido: ");
                input = Console.ReadLine();
            }
        }

        public static double StringIsDouble(string input)
        {
            while (true)
            {
                double result;
                if (double.TryParse(input, out result))
                    return result;
                else
                    Console.WriteLine("El valor ingresado no es un número válido.");

                Console.Write("Ingrese un número válido: ");
                input = Console.ReadLine();
            }
        }
    }
}
