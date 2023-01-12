using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] characters = words[i].ToCharArray();
                Array.Reverse(characters);
                words[i] = new string(characters);
            }
            string reversed = string.Join(" ", words);
            Console.WriteLine(reversed);
        }
    }
}
