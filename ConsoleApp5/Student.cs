using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal record Student(string Name, string ClassName, int BirthYear)
    {
        private double _average { get; set; }
        public string Grading()
        {
            switch (_average)
            {
                case < 2.0:
                    return "Fejlesztendő";
                case < 3.5:
                    return "Megfelelt";
                case < 4.5:
                    return "Jó";
                default:
                    return "Kiváló";
            }
        }
        public void Forgotten()
        {
            Console.WriteLine(".----------------------------------------------------------------------------------------------------------------------.");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                              ███████████                                             |");
            Console.WriteLine("|                                                              ███████████                                             |");
            Console.WriteLine("|                                         ██████████    ███████████                                                    |");
            Console.WriteLine("|                                         ██████████    ▓▓▓████████                                                    |");
            Console.WriteLine("|                                ▒▒▒▒▒▒███████████████████████████████████████████                                     |");
            Console.WriteLine("|                                ▒▒▒▒▒▒████████████████████▓▓▓▓▓▓▓▓███████████████                                     |");
            Console.WriteLine("|                                ▒▒▒▒▒▒████████████████████▓▓▓▓▓▓▓▓████████████▓▓▓                                     |");
            Console.WriteLine("|                       ██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓██████████████████████████████████████                             |");
            Console.WriteLine("|                       ██████████▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒█████████████████████████████████████████                             |");
            Console.WriteLine("|                          ▒▒▒▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓█████████████████████████████▓▓▓▓▓▓▓▓▓▓██                             |");
            Console.WriteLine("|                          ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████████████████████▒▒▒▓▓▓▓▓▓▓▓▓▓                               |");
            Console.WriteLine("|                          ▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████████████████████████████████▒▒▒▓▓▓▓▓▓▓▓▓▓                               |");
            Console.WriteLine("|                          ▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                   |");
            Console.WriteLine("|                                        ███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                   |");
            Console.WriteLine("|                                          ▒▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                   |");
            Console.WriteLine("|                                          ▒▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                            |");
            Console.WriteLine("|                                                 ██████████   |     |  , __-                                          |");
            Console.WriteLine("|                                                    |         '----'  |-'                                             |");
            Console.WriteLine("|                                                    |         ____---'                                                |");
            Console.WriteLine("|                                            ,------'         |                                                        |");
            Console.WriteLine("|                                           |   ,            ,'                                                        |");
            Console.WriteLine("|                                           |  |   ,  ,-----'                                                          |");
            Console.WriteLine("|                                          ,', | | | |                                                                 |");
            Console.WriteLine("|                                      ,--',-','_','-,'--__                                                            |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("˙----------------------------------------------------------------------------------------------------------------------˙");
        }
    }
}
