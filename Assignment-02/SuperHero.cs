using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{

    class SuperHero : Hero
    {

        //Private Properties -------------------------------------------------
        private string[] superPowers = new string[3];

        //Constructor ---------------------------------------------------------
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        }

        private void generateRandomPowers()
        {
            int randomSuperPower, counter = 0;
        //All available super powers including extra powers
            string[] allSuperPowersList = { "Super Speed", "Super Strength", "Body Armor", "Fight", "Fire Generation", "Weather Control", "Magnetic Power" };
     
        //Logic behind randomly selecting unique super powers  
            Random randomPower = new Random();
            for (int index = 0; counter < 3; index++)
            {

                randomSuperPower = randomPower.Next(0, 7);
       
        //Exists() method in the array class is used for finding an element in an array
                if (Array.Exists(superPowers, element => element == allSuperPowersList[randomSuperPower]))
                    continue;
                else
                {
                    superPowers[counter] = allSuperPowersList[randomSuperPower];
                    counter = counter + 1;
                }
            }

        }

        public void showPowers()
        {
        //Printing the superPowers on to the screen.
            for (int index = 0; index < 3; index++)
                Console.WriteLine("\nSuper Power No. " + (index + 1) + " is: {0}\n", superPowers[index]);
        }

    }

}
