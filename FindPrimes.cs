using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tag = Console.ReadLine();

            if (TagValidator(tag))
                Safe();
            else Danger();
        }

        public static bool TagValidator(string tag)
        {
            var safeOrDanger = false;
            var tagArray = tag.ToArray();

            if (tag.Length != 9)
                safeOrDanger = false;

            else
            {
                for (var i = 0; i < tag.Length - 1; i++)
                {
                    if (i == 2)
                    {
                        if ((int)Char.GetNumericValue(tag[i]) > 0)
                        {
                            safeOrDanger = false;
                            break;
                        }

                        else if (Char.IsLower(tag[i]))
                        {
                            safeOrDanger = false;
                            break;
                        }

                        else if (tag[i].Equals('A') || tag[i].Equals('E') || tag[i].Equals('I') || tag[i].Equals('O') || tag[i].Equals('U') || tag[i].Equals('Y'))
                        {
                            safeOrDanger = false;
                            break;
                        }
                    }

                    else if (i == 6)
                    {
                        if (tag[i] != '-')
                        {
                            safeOrDanger = false;
                            break;
                        }
                    }

                    else if ((int)Char.GetNumericValue(tag[i]) < 0)
                    {
                        safeOrDanger = false;
                        break;
                    }

                    else if (i != 5 && i != 8)
                    {
                        if (((int)Char.GetNumericValue(tag[i]) + (int)Char.GetNumericValue(tag[i + 1])) % 2 == 0)
                            safeOrDanger = true;

                        else
                        {
                            safeOrDanger = false;
                            break;
                        }
                    }
                }
            }

            return safeOrDanger;
        }

        public static void Danger()
        {
            Console.WriteLine("invalid");
        }

        public static void Safe()
        {
            Console.WriteLine("valid");
        }
    }
}
















