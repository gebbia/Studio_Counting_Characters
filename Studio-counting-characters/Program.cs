using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        public static void Main(string[] args)
        
        {
           //count the number of times each character occurs in a string and then print the results to the console
            string sampleStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus";
            List<char> sampleChars = new List<char>();
            sampleChars.AddRange(sampleStr);


            Dictionary<char, int> sampleDict = new Dictionary<char, int>();
            sampleDict.Add('a', 0);
            sampleDict.Add('b', 0);
            sampleDict.Add('c', 0);
            sampleDict.Add('d', 0);
            sampleDict.Add('e', 0);
            sampleDict.Add('f', 0);
            sampleDict.Add('g', 0);
            sampleDict.Add('h', 0);
            sampleDict.Add('i', 0);
            sampleDict.Add('j', 0);
            sampleDict.Add('k', 0);
            sampleDict.Add('l', 0);
            sampleDict.Add('m', 0);
            sampleDict.Add('n', 0);
            sampleDict.Add('o', 0);
            sampleDict.Add('p', 0);
            sampleDict.Add('q', 0);
            sampleDict.Add('r', 0);
            sampleDict.Add('s', 0);
            sampleDict.Add('t', 0);
            sampleDict.Add('u', 0);
            sampleDict.Add('v', 0);
            sampleDict.Add('w', 0);
            sampleDict.Add('x', 0);
            sampleDict.Add('y', 0);
            sampleDict.Add('z', 0);


            foreach (char c in sampleChars)
            {
                if (sampleDict.ContainsKey(c))
                {
                    sampleDict[c] = sampleDict[c] + 1;
                }
            }

            foreach (char sample in sampleDict.Keys)
            {
                Console.WriteLine($" {sample} : {sampleDict[sample]} ");
            }

            Console.WriteLine(sampleChars.Count);
            Console.ReadLine();
        }
    }
}




