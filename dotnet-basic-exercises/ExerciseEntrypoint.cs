namespace DotnetBasicExercises
{
    public class ExerciseEntrypoint
    {
        public static void RunExercise(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Exercise1.Run();
                    break;
                case 2:
                    Console.Clear();
                    Exercise2.Run();
                    break;
                case 3:
                    Console.Clear();
                    Exercise3.Run();
                    break;
                case 4:
                    Console.Clear();
                    Exercise4.Run();
                    break;
                case 5:
                    Console.Clear();
                    Exercise5.Run();
                    break;
                case 6:
                    Console.Clear();
                    Exercise6.Run();
                    break;
                case 7:
                    Console.Clear();
                    Exercise7.Run();
                    break;
                case 8:
                    Console.Clear();
                    Exercise8.Run();
                    break;
                case 9:
                    Console.Clear();
                    Exercise9.Run();
                    break;
                case 10:
                    Console.Clear();
                    Exercise10.Run();
                    break;
                case 11:
                    Console.Clear();
                    Exercise11.Run();
                    break;
                case 12:
                    Console.Clear();
                    Exercise12.Run();
                    break;
                case 13:
                    Console.Clear();
                    Exercise13.Run();
                    break;
                case 14:
                    Console.Clear();
                    Exercise14.Run();
                    break;
                case 15:
                    Console.Clear();
                    Exercise15.Run();
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}