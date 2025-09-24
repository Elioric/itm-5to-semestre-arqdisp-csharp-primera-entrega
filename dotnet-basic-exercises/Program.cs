namespace DotnetBasicExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Menu.ShowMenu();

                    int option = int.Parse(Console.ReadLine());

                    if (option < 1 || option > 16)
                    {
                        Console.Clear();
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 16.");
                    }
                    else if (option == 16)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        ExerciseEntrypoint.RunExercise(option);
                    }

                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                }
            }
        }
    }
}
