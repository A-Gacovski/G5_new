using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();


            Console.WriteLine("Please enter words, to stop enter x: ");
            bool validData = true;

            while (validData)
            {

                string newWord = Console.ReadLine();

                if (newWord.ToLower() != "x")
                {
                    words.Add(newWord);
                }
                else
                {
                    validData = false;
                }
            }

            Console.WriteLine("Please enter some text: ");
            string newParagraph = Console.ReadLine();

            string [] paragraphs = newParagraph.Split(" ");
            int counter = 0;
            foreach( string paragraph in paragraphs)
            {
                foreach( string word in words)
                {
                    if(paragraph.ToLower() == word.ToLower())
                    {
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}