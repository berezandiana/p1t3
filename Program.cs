using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть речення:");
        string sentence = Console.ReadLine();

        int maxSpaces = 0;
        int currentSpaces = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                currentSpaces++;
                if (currentSpaces > maxSpaces)
                {
                    maxSpaces = currentSpaces;
                }
            }
            else
            {
                currentSpaces = 0;
            }
        }

        Console.WriteLine("Найбiльша кiлькiсть пробiлiв, що розташованi пiдряд: " + maxSpaces);
        Console.ReadLine();
    }
}
