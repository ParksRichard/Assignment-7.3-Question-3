//Given two strings s and t, return true if t is an anagram of s, otherwise false

//two sort arrays for strings
//not user input?
//compare arrays

namespace Assignment_7._3_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hardcode
            string s = "anagram";
            string t = "nagaram";

            //check length
            if (s.Length != t.Length)
            {
                Console.WriteLine("The two words are not anagrams.");
                return;
            }

            //convert arrays to sort
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            Array.Sort(sChars);
            Array.Sort(tChars);

            //compare arrays
            for (int i = 0; i < sChars.Length; i++)
            {
                if (sChars[i] != tChars[i])
                {
                    Console.WriteLine("The two words are not anagrams.");
                    return;
                }
            }

            Console.WriteLine("The two words are anagrams.");
        }
    }

}
