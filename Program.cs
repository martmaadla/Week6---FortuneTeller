using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm ennustab, mis juhtub kasutajaga täna ja homme

            string chosenElement = "";
            Random rnd = new Random();
            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the dark side for cookies" };

            int userNumber = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Today you will have {predictions[userNumber]}");

            switch (rnd.Next(4))
            {
                case 0:
                    chosenElement = predictions[0];
                    break;
                case 1:
                    chosenElement = predictions[1];
                    break;
                case 2:
                    chosenElement = predictions[2];
                    break;
                case 3:
                    chosenElement = predictions[3];
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine($"Tomorrow you will {chosenElement}");
            Console.ReadLine();
        }
    }
}
