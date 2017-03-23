using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseStringAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the string you want to reverse:");
                string splitThis = Console.ReadLine();
                char[] arr = splitThis.ToCharArray();

                Console.WriteLine(reverse(arr));
            }
        }
        public static string reverse(char[] s)
        {
            List<char> nee = new List<char>();
            Console.WriteLine(s[1]);
            string rtr = "";
            for(int i = s.Count() - 1; i >= 0; i--)
            {
                rtr += s[i];
            }
            //char[] temp = nee.ToArray();
            
            return rtr;
        }
    }
}
