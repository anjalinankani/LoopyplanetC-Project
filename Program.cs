using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            Console.WriteLine("Menu of Planets"); 
            Console.WriteLine("==== == =======");
            Console.WriteLine("1. Jupiter, 2. Mars, 3. Mercury, 4. Neptune, 5. Pluto, 6. Saturn, 7. Uranus, 8. Venus, 9. <Quit>");

            double num01 = 2.64; //values for planetweight
            double num02 = 0.38;
            double num03 = 0.37;
            double num04 = 1.12;
            double num05 = 0.04;
            double num06 = 1.15;
            double num07 = 1.15;
            double num08 = 0.88;

            var planet = ""; 


            double menuChoice;
            double earthWeight;
            double planetWeight = 0;
            Console.WriteLine("Enter your menu choice");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            while (menuChoice != 9) //loop to check if the menuchoice is equal to nine or not
            {
                while (menuChoice < 1 || menuChoice > 9) //loop to check if menuchoice is less than 1 or greater than 9
                {
                    Console.Write("Please enter one of the digits from 1-9" + "\n");
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter your weight on earth");
                earthWeight = Convert.ToDouble(Console.ReadLine()); //storing the values in decimal for earthweight


                if (menuChoice == 1)
                {
                    planetWeight = num01 * earthWeight;
                    planet = "Jupiter";
                }
                if (menuChoice == 2)
                {
                    planetWeight = num02 * earthWeight;
                    planet = "Mars";
                }
                if (menuChoice == 3)
                {
                    planetWeight = num03 * earthWeight;
                    planet = "Mercury";
                }
                if (menuChoice == 4)
                {
                    planetWeight = num04 * earthWeight;
                    planet = "Neptune";
                }
                if (menuChoice == 5)
                {
                    planetWeight = num05 * earthWeight;
                    planet = "Pluto";
                }
                if (menuChoice == 6)
                {
                    planetWeight = num06 * earthWeight;
                    planet = "Saturn";
                }
                if (menuChoice == 7)
                {
                    planetWeight = num07 * earthWeight;
                    planet = "Uranus";
                }
                if (menuChoice == 8)
                {
                    planetWeight = num08 * earthWeight;
                    planet = "Venus";
                }

                string planetWeight2 = string.Format("{0:F1}", planetWeight); //planetweight2 stores the value in first decimal place

                Console.WriteLine("");
                Console.WriteLine("Your weight of " + earthWeight + " pounds on Earth would be " + planetWeight2 + " pounds on " + planet + "."); //concatenation
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter your menu choice");
                menuChoice = Convert.ToInt32(Console.ReadLine()); 
            }

            if (menuChoice == 9) //if menuchoice is equal to nine then it will show following line
            {
                Console.WriteLine("Okay! Goodbye, have a great day.");
                Console.Read();
            }


        }
    }
}


