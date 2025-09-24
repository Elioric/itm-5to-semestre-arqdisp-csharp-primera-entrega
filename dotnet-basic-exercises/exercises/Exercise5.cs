namespace DotnetBasicExercises
{
    public class Exercise5
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el número del día 1 - 7: ");
                    int dayNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (dayNum >= 1 && dayNum <= 5)
                    {
                        string[] weekDays = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                        Console.WriteLine($"El día {dayNum} de la semana laboral es: {weekDays[dayNum - 1]}");
                    }
                    else if (dayNum == 6 || dayNum == 7)
                    {
                        Console.WriteLine("Número fuera del rango laboral.");
                    }
                    else
                    {
                        Console.WriteLine("El número del día debe estar entre 1 y 7 inclusivo.");
                    }
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
