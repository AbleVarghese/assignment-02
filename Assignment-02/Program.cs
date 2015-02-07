/* Assigment 02
 * Name: Able Varghese
 * Student No: 300 806 906
 * 
 * This program is a game where we have a hero who is set out to hit a villan. He/she will have 3 major
 * super powers. Each super power will be unique and different all the time. This hero will fight the villan, and 20% of
 * the time our hero will be successful and hits the villan, but rest of the time he'll miss it. Our program has the
 * ability to evaluate the damage caused by a hit if our hero manage to hit the villan. There are 5 properties and 
 * 8 methods and 2 contructors implemented in the Hero class and SuperHero base class associated with this program.
 
 */


using System;

namespace Assignment_02
{
	class Program
	{
		static void Main(string[] args)
        {
            string hero;

            start:
            Console.Write("Please enter the name of the hero: ");
            hero=Console.ReadLine();

            if (hero != "")
            {

                SuperHero superhero = new SuperHero(hero);
                superhero.showPowers();
                superhero.fight();

                //	Here the show() method in class Hero is called for displaying the name and status of this Hero
                superhero.show();
            }
            else
                  goto start;

            Console.WriteLine("\nPlease press enter to EXIT");
			Console.ReadKey();


            
                  
            {

            }


		}
	}
}
