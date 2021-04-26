using System;
using System.Collections.Generic;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            Console.WriteLine("Please enter words, to stop enter x: ");
            string newWord = Console.ReadLine();
            while (newWord.ToLower() != "x")
            {
                words.Add(newWord);
                newWord = Console.ReadLine();
            }

            Console.WriteLine("Please enter some text: ");
            string newParagraph = Console.ReadLine();

            string midiParagraph = newParagraph.ToLower();
            string [] paragraph = midiParagraph.Split(" ");

            int count = 0;
            words.ForEach(word =>
            {
                paragraph.ForEach(cut =>
                {
                    if (word == cut)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                    
                });

            });
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
