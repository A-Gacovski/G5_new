using System;

namespace homework_4_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of wins:");
            string strWins = Console.ReadLine();
            int wins = int.Parse(strWins);

            Console.WriteLine("Enter no. of draws:");
            string strDraws = Console.ReadLine();
            int draws = int.Parse(strDraws);

            Console.WriteLine("Enter no. of losses:");
            string strLosses = Console.ReadLine();
            int losses = int.Parse(strLosses);

            int result = Count(wins, draws, losses);

            Console.WriteLine($"{result} points scored by the team");
        }
        public static int Count(int wins, int draws, int losses)
        {
            int winPoints = 3;
            int drawPoints = 1;
            int lossPoints = 0; 
            int points = wins * winPoints + draws * drawPoints + losses * lossPoints;

            return points;
        }
    }
}
