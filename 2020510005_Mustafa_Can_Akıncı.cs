using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miss Polly had a poor dolly, who was sick. She called for the talled doctor Solly to come quick. He knocked on the DOOR like a actor in the healthcare sector.
            string pattern = "";
            string sentence = "";
            Console.WriteLine("Please enter sentence");
            sentence = Console.ReadLine();
            string sentencelow = sentence.ToLower();
            sentencelow = sentencelow.Replace(",", "");
            sentencelow = sentencelow.Replace(".", "");
            string[] splitsentence = sentencelow.Split();
            char[] Control = pattern.ToCharArray();
            int countStar = 0;
            int countline = 0;
            for (int i = 0; i < splitsentence.Length; i++)
            {
                Control = splitsentence[i].ToCharArray();
                for (int j = 0; j < Control.Length; j++)
                {
                    if ((Control[j] == 'a' || Control[j] == 'b' || Control[j] == 'c' || Control[j] == 'd' || Control[j] == 'e' || Control[j] == 'f' || Control[j] == 'g' || Control[j] == 'h' || Control[j] == 'i' || Control[j] == 'j' || Control[j] == 'k' || Control[j] == 'l' || Control[j] == 'm' || Control[j] == 'n' || Control[j] == 'o' || Control[j] == 'p' || Control[j] == 'q' || Control[j] == 'r' || Control[j] == 's' || Control[j] == 't' || Control[j] == 'u' || Control[j] == 'v' || Control[j] == 'w' || Control[j] == 'x' || Control[j] == 'y' || Control[j] == 'z' || Control[j] == ',' || Control[j] == '.'))
                    {
                        Console.WriteLine(Control);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong char");
                        break;
                    }
                }
            }
            Console.ReadLine();
            Console.WriteLine("Please enter pattern");
            pattern = Console.ReadLine();
            string patternlow = pattern.ToLower();
            patternlow = patternlow.Replace(" ", "");
            Control = patternlow.ToCharArray();
            string[] splitpattern = patternlow.Split();
            splitsentence = sentencelow.Split();
            for (int k = 0; k < Control.Length; k++)
            {
                if ((Control[k] == 'a' || Control[k] == 'b' || Control[k] == 'c' || Control[k] == 'd' || Control[k] == 'e' || Control[k] == 'f' || Control[k] == 'g' || Control[k] == 'h' || Control[k] == 'i' || Control[k] == 'j' || Control[k] == 'k' || Control[k] == 'l' || Control[k] == 'm' || Control[k] == 'n' || Control[k] == 'o' || Control[k] == 'p' || Control[k] == 'q' || Control[k] == 'r' || Control[k] == 's' || Control[k] == 't' || Control[k] == 'u' || Control[k] == 'v' || Control[k] == 'w' || Control[k] == 'x' || Control[k] == 'y' || Control[k] == 'z' || Control[k] == '*' || Control[k] == '-'))
                {
                    Console.WriteLine(Control);
                    bool flag = false;
                    if (Control[k] == '*')
                    {
                        for (int j = 0; j < splitsentence.Length; j++)
                        {
                            if (patternlow.Length <= splitsentence[j].Length)
                            {
                                string[] patternstar = patternlow.Split('*');

                                for (int y = 0; y < patternstar.Length; y++)
                                {
                                    if (patternstar[y] == "")
                                    {

                                    }
                                    else
                                    {
                                        if (splitsentence[j].Contains(patternstar[y]))
                                        {
                                            flag = true;
                                        }
                                        else
                                        {
                                            flag = false;
                                        }
                                    }
                                }
                                if (flag == true)
                                {
                                    Console.WriteLine(splitsentence[j]);
                                }
                            }
                        }

                        Console.ReadLine();
                    }
                    
                    
                    bool flag1 = false;
                    if (Control[k] == '-')
                    {
                        for (int j = 0; j < splitsentence.Length; j++)
                        {
                            if (patternlow.Length <= splitsentence[j].Length)
                            {
                                string[] patternstar = patternlow.Split('-');

                                for (int y = 0; y < patternstar.Length; y++)
                                {
                                    if (patternstar[y] == "")
                                    {

                                    }
                                    else
                                    {
                                        if (splitsentence[j].Contains(patternstar[y]))
                                        {
                                            flag1 = true;
                                        }
                                        else
                                        {
                                            flag1 = false;
                                        }
                                    }
                                }
                                if (flag1 == true)
                                {
                                    Console.WriteLine(splitsentence[j]);
                                }
                            }
                        }

                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("Wrong char");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}

