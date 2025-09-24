namespace DotnetBasicExercises
{
    public class Exercise10
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa una cadena de texto: ");
                    string input = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine($"La longitud de la cadena de texto \"{input}\" es: {input.Length}");

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error.");
                }
            }
        }
    }
}
