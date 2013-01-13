using System;
using System.Collections.Generic;
using System.Text;

namespace check_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomlimit = 10;
            int[] usedfort = new int[randomlimit];
            int usedfortcount = 0;
            int fortnum;

            Random randnum = new Random();
            
            for (int bigcounter = 0; bigcounter < 11; bigcounter++)
            {
                
                fortnum = randnum.Next(randomlimit) + 1;
                Console.WriteLine(fortnum);
                int usedcount = 0;

                for (int counter = 0; counter < randomlimit; counter++)
                {
                    if (usedcount > randomlimit)
                    {
                        Console.WriteLine("All fortunes used");
                        Console.ReadLine();
                        break;
                    }
                    
                    foreach (int fortune in usedfort)
                    {
                        if (fortnum == fortune)
                        {
                            Console.WriteLine("{0} {1}", fortune, fortnum);
                            fortnum = randnum.Next(randomlimit) + 1;
                            Console.WriteLine("{0} {1}", fortune, fortnum);
                            counter = 0;
                            usedcount++;
                        }
                    }
                }

                usedfort[usedfortcount] = fortnum;
                foreach (int fortune in usedfort)
                    Console.Write("{0} ",fortune);
                Console.WriteLine("\n");
                usedfortcount++;
                Console.WriteLine(fortnum);
                Console.WriteLine(usedfortcount);
                Console.ReadLine();
            }
        }
    }
}
