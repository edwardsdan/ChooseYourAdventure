using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtraLab2
{
    // repo from parent folder including .sln
    // declare variables here when useful
    // implement interface (google it)
    // find a good RNG
    // separate class for each "class"
    class Validation
    {
        public static string ValidateKnightWeapon(string x)
        {
            while (!Regex.IsMatch(x, "^(sword|axe|spear)$"))
            {
                Console.WriteLine("Choose a REAL weapon, jeez (sword, axe, spear)");
                x = Console.ReadLine().ToLower();
            }
            if (x == "sword")
            {
                Console.WriteLine("A fine choice, sir! Here you go!");
            }
            else if (x == "axe")
            {
                Console.WriteLine("What are you a barbarian...?");
                Console.WriteLine("Whatever, here you go...");
            }
            else
            {
                Console.WriteLine("Keep 'em away... That's how I survived");
            }
            return x;
        }
        public static string ValidateMonkWeapon(string x)
        {
            while (!Regex.IsMatch(x, "^(staff|fist|mace)$"))
            {
                Console.WriteLine("C'mon! I'm busy! (staff, fist, mace)");
                x = Console.ReadLine().ToLower();
            }
            if (x == "staff")
            {
                Console.WriteLine("Go find your own stick...");
            }
            else if (x == "fist")
            {
                Console.WriteLine("Why'd you even come here, then?");
            }
            else
            {
                Console.WriteLine("Now THAT'S something I can make for you!");
            }
            return x;
        }
        public static string ValidateArcherWeapon(string x)
        {
            while (!Regex.IsMatch(x, "^(bow|crossbow)$"))
            {
                Console.WriteLine("Choose a weapon already, I haven't got all day!");
                x = Console.ReadLine().ToLower();
            }
            return x;
        }
        //public static void ValidateRace
    }

    class ClassAdventures
    {
        public static void KnightAdventure1()
        {

        }

        public static void MonkAdventure1()
        {

        }

        public static void ArcherAdventure1()
        {

        }

        public static void DeathEvent()
        {

        }

        public static void KnightEnd()
        {

        }

        public static void MonkEnd()
        {

        }
        
        public static void ArcherEnd()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Do you want to go on an adventure? (y/n)");
            if (Regex.Match(Console.ReadLine().ToLower(), "^(yes|y)$").Success == true)
            {
                Console.WriteLine("Choose your class! (knight, monk, archer)");
                ChooseWeapon(Console.ReadLine());
                ChooseRace();

            }
            else
            {
                Console.Write("That's a shame... ");
            }
            Console.WriteLine("Goodbye!");
        }

        public static string ChooseWeapon (string x)
        {
            x = x.ToLower();
            string Weapon;
            while (!Regex.Match(x, "^(knight|monk|archer)$").Success)
            {
                Console.WriteLine("Can you say that again? I didn't understand. (knight, monk, archer)");
                x = Console.ReadLine().ToLower();
            }
            if (x == "knight")
            {
                Console.WriteLine("Choose your weapon! (axe, sword, spear)");
                Weapon = Console.ReadLine().ToLower();
                Weapon = Validation.ValidateKnightWeapon(Weapon);
                return Weapon;
            }
            else if (x == "monk")
            {
                Console.WriteLine("Choose your weapon! (staff, fist, mace)");
                Weapon = Console.ReadLine().ToLower();
                Weapon = Validation.ValidateMonkWeapon(Weapon);
                return Weapon;
            }
            else if (x == "archer")
            {
                Console.WriteLine("Choose your weapon! (bow, crossbow)");
                Weapon = Console.ReadLine().ToLower();
                Weapon = Validation.ValidateArcherWeapon(Weapon);
                return Weapon;
            }
            return x;
        }

        public static void ChooseRace() //validate race, pass string
        {
            Console.WriteLine("Now, choose your race! (human, elf, orc)");
            string race = Console.ReadLine().ToLower();

            while (!Regex.Match(race, "^(human|elf|orc)$").Success)
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again! (human, elf, orc)");
                race = Console.ReadLine().ToLower();
            }
        }
    }
}
