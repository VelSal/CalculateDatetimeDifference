using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kansberekening.Models
{
    public class Numbers
    {
        public int RedBall { get; set; }
        public int TotalBalls { get; set; }

        public static void TerugleggingKeuze()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("Wilt u de probabiliteit rekenen ZONDER of MET teruglegging? \n\t1. Zonder teruglegging \t2. Met teruglegging \t\t3. Programma sluiten");
                string userChoiceInput = Console.ReadLine();
                switch (userChoiceInput)
                {
                    case "1":
                        //Method zonder teruglegging
                        Console.Write("Kiez een aantal pogingen (1-100): ");
                        string userPogingenInput = Console.ReadLine();
                        int userPogingenOutput;
                        if (int.TryParse(userPogingenInput, out userPogingenOutput) && userPogingenOutput < 101)
                        {
                            ///
                        }
                        break;
                    case "2":
                        //Method met teruglegging
                        break;
                    case "3":
                        Console.WriteLine("Tot ziens!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ongeldige invoer");
                        break;
                }
            }
        }
    }
}
