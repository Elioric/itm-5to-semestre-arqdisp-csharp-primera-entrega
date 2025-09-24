namespace DotnetBasicExercises
{
    public class Exercise13: IExercise
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa una cadena de texto: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("");

                    string[] VOWELS = { "a", "e", "i", "o", "u" };

                    word = word.ToLower();
                    int vowelCount = 0;

                    foreach (char vowel in word)
                    {
                        if (VOWELS.Contains(vowel.ToString()))
                        {
                            vowelCount++;
                        }
                    }

                    Console.WriteLine($"La cantidad de vocales en la cadena es: {vowelCount}");

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
