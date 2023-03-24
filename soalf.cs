using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solaf_drawshe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("welcome to my game");
            char[] lines = { '_', '_', '_', '_'};
            
            string word = gettodayword();
            int heart = gettodayword().Length;
            
            while (heart> 0)
            {
                printLines(lines);
                char c = AskUser();
                int result = checklettr(word ,c ,lines);

                if(result == -1)
                {
                    // remove heart
                    heart--;
                    Console.WriteLine("you have "+ heart + " hearts!");
                }
                else
                {
                    // update lines
                    lines[result] = c;
                    
                }

                if (checkwin(lines) == 1)
                {
                    break;
                }
                
            }
            if (heart > 0)
            {
                Console.WriteLine("u win");
            }
            else
            {
                Console.WriteLine("u lose");
            }



        }
        public static char AskUser()
        {
            Console.WriteLine("please enter a char:");
            char s = Console.ReadLine()[0];
            return s;
        }
        public static string gettodayword()
        {
            string[] words = { "helo", "stlf", "loop", "bata" };
            Random rnd = new Random();
            int dd = rnd.Next(words.Length);
            return words[dd];
        }
        public static int  checklettr(string todayword, char ch , char[] lines)
        {
            for(int i =0; i < todayword.Length; i++) 
            {
                if (todayword[i]==ch && lines[i] != ch )
                {
                    return i;
                }
            }
          return -1;
        }
        public static int checkwin(char[] lines)
        {
            for(int i=0; i< lines.Length; i++)
            {
                if (lines[i] == '_')
                {
                    return -1;
                }


            }
          return 1;
        }

        public static void printLines(char[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i] + " ");
            }
            Console.WriteLine();
        } 
    }   
}
