using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    //struct notes

    struct PlayerData  //with struct you can easily add new variables and then apply them to the "groups" and change all of them at once.
                       //You can also put structs into structs
    {
        public Example example;
        public int health;
        public float mana;
        public Stats stats;
        public bool isPlayerAlive;
        public string playerName;
        public DateTime lastTimeEdited;
    }

    struct Example
    {
        public int number;
    }

    struct Stats
    {
        public int anotherExample;
    }


    internal class Notes
    {
        //struct notes
        static void Second(string[] args)
        {
            Example examplePlayer1 = new()
            {
                number = 5
            };

            PlayerData player1 = new()
            {
                health = 100,
                mana = 30.5f,
                stats = new()
                {
                    anotherExample = 4      //this is another way to do it, instead of creating a whole new layer like the "Example" above
                },
                isPlayerAlive = true,
                playerName = "Marcus",
                lastTimeEdited = DateTime.Now,
                example = examplePlayer1
            };

            Console.WriteLine(player1.example.number); //now you can write stuff from Example struct through player1
            Console.WriteLine(player1.health);

            PlayerData player2 = new()
            {
                health = 400,
                mana = 12.5f,
                isPlayerAlive = true,
                playerName = "Mira",
                lastTimeEdited = DateTime.Now
            };

            PrintPlayerName(player2);
        }

        static void PrintPlayerName(PlayerData player)
        {
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.example.number);
        }

        
        static void Main(string[] args)
        {
            string dog = "dog";

            //fucntion stuff
            TryingStuff("Master", 27, 'B', "cat" == dog); //static function can't call a non-static function
            TryingStuff("Friend", 0, 'A', true);



            string adjective = Console.ReadLine();

            string myAdLib = FormatIntoMadLib("dog", adjective, "walk");
            Console.WriteLine(myAdLib);

            string morning = PracticeFunctions("sun", adjective, "rise");
            Console.WriteLine(morning);

            System.Threading.Thread.Sleep(3000); //makes the console wait the inputted time, "3000" = 3 seconds





            Console.WriteLine("maybe in between all the fighting and writing eventually we'll be feasting and thriving\n" +
                "for the sake of out brothers and sisters this shall be the desired moment of peace");
            // \n is a,iine breaker that will move the next writing on the next console line


            //numerical data types
            float decimalPoints = 5.7f; //4 bytes
            int nameOfVariable = 3, fullNumbers = 4; //4 bytes
            double alsoDecimalPoints = 2, butTwoTimesMemory = 4.6; //8 bytes

            //text data types
            string number = "4"; //will be treated as a letter 4 not a number 4
            string anyWords = "Can be anything"; //1 byte per character
            char singleCharacterOrLetter = 'g'; //1 byte (4 bytes)

            //boolean data types
            bool trueOrFalse = false; //1 byte (4 bytes)


            //changing the variables
            nameOfVariable = 7;
            anyWords = "that you like";
            butTwoTimesMemory = 5.8;

            //read variable value
            Console.WriteLine(singleCharacterOrLetter);

            //will read the last update so "that you like" not "Can be anything"
            Console.WriteLine(anyWords);



            //variable conversion
            //casting between two numeric types, doesn't work for strings
            double my8Bytes = 30.65857645743; //only double can store this many numbers
            float my4Bytes = (float)my8Bytes; //will lose the last few numbers due to lower byte storage in float
            int myInt = (int)my8Bytes; //will lose even more since it doesn't store any decimals

            //system.convert conversion, does work for strings
            float my4ByteAgain = Convert.ToSingle(my8Bytes); //does the same exact thing as casting
            int myIntAgain = Convert.ToInt32(my8Bytes); //will catch if a value is too arge or too small in comparison to direct casting which will simply write the wrong number

            string numberString = "4675";
            int numberAsInt = Convert.ToInt32(numberString);


            //console functions
            Console.Title = "Good Game"; //changes the name of the tab of the console

            Console.WriteLine("Hello World!"); //writes whatever is in the quotes

            Console.BackgroundColor = ConsoleColor.Green; //adds a background to text

            Console.WriteLine(numberAsInt); //writes whatever is in the variable, string, int, etc.

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red; //changes color of text

            Console.WriteLine(trueOrFalse + number); //will write all variables out in one connected sequence without space if not present

            Console.Beep(); //eloctronic device beep sound
            Console.Beep(800,150); //(frequency, duration)
            Console.Beep(37,500);
            Console.Beep(32767, 500);


            string message = Console.ReadLine(); //reads what user writes in and returns it
            Console.WriteLine(message); //write out what was typed in

            try
            {
                int Age = Convert.ToInt32(Console.ReadLine()); //takes user written string and turns it into number
                Console.WriteLine(Age + "? That's pretty old");
            } //try and catch tries to catch an error and run it in a crash file, but while in there a variable will only exist inside the curly brackets and will
            //not be accesed outisde of them

            catch
            {
                Console.WriteLine("What?");
            } //will play in case the code crashed





            //Operators: the operations you are doing
            //Operands: what you are doing the operations on

            // 1 + 1,  "1" = operands and "+" = operator

            //Arithmetic operators: operators that act on numeric types( ints, floats, doubles)
            // +, -, *, /
            // +=, -=, *=, /=
            // ++, --

            int a = 15;
            int b = 2;
            int c = a + b;
            int d = a / b; //will give 7 as the answer due to it being an int, so no decimals
            float f = (float)a / b; //float f still won't give you a float unless at least one of the used values is changed to a float, like in this example

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);

            a += 7; //same as d = d + 7, just shorter

            int t = a + b;
            Console.WriteLine(t);

            b += c;
            Console.WriteLine(b);

            b++; //will make the number go up by one
            Console.WriteLine(b);



            //Comparison operators: checking two values and comparing them
            // <, >
            // <=, >=
            // !=, ==

            int myNum = 4;
            int yourNum = 6;

            bool isMyNumLarger = myNum < yourNum; //compares the numbers and check whether the statement is true
            Console.WriteLine(isMyNumLarger); //says whether it's true or not

            bool areNumsUnequal = myNum != yourNum; //checks if numbers are unequal, if yes sets bool to true
            Console.WriteLine(areNumsUnequal);

            bool areNumsEqual = myNum == yourNum; // checks if the numbers are equal, if yes sets to true
            Console.WriteLine(areNumsEqual);



            //Boolean logic operators: take two bools and give you a bool
            // &&, ||, !

            bool dogVoltBest = true;
            bool dayBad = false;
            bool dayGood = true;
            bool dogMikeBest = false;
            bool dayNeutral = true;

            bool areAllDogsBest = dogMikeBest && dogVoltBest; // && requires for both statements to be true to be set to true
            Console.WriteLine(areAllDogsBest);

            bool isDayGood = dayGood || dayBad; // || is an "or" statements so it requires only one to be true
            Console.WriteLine(isDayGood);

            bool isDayOk = (dayGood || dayBad) && dayNeutral; //first two get checked first and later go as a collective true or false
            bool isDayOkNow = dayGood || (dayBad && dayNeutral); //stuff in parenthesis gets evaluated first

            bool isDayNeutral = !dayNeutral; // ! flips the bool in front of it, so ! is like putting - in front of number or equation in math



            // Code branching
            bool userPressedSpacebar = Console.ReadKey().KeyChar.CompareTo(' ') == 0;

            if (!userPressedSpacebar) //remember that ! flips whatever is in the variable, so in this case if bool is true initially it'll become false and won't play
            {
                Console.WriteLine("Good Job!");
            }



            char letter = Console.ReadKey().KeyChar;

            switch (letter) //in switches you cannot put in a variable, you must put a concrete constant input
            {
                case 'a':
                    Console.WriteLine("yay"); //will execute when the character input is 'a'
                    break; //cuts off at the case without letting fall through to the next one. If break is in place then afte the case
                           //is executed the next code that runs will be outside of the switch

                case 'c':
                    Console.WriteLine("not yay");
                    break;

                default:
                    Console.WriteLine("huh, yeah I guess, '" + letter + "' works"); //plays this when none of the previous are true, so like an "else"
                    break;
            }

            Console.ReadKey(); //will wait until a key is pressed before doing anything after it
        }


        //function notes
        // what function returns, name of function(inputs)
        //void fucntion returns nothing and you don't need anything from it
        static void TryingStuff(string names, int numberOfKills, char letter, bool catEqualToDog)
        {
            Console.WriteLine("Hallo " + names);
            Console.WriteLine(numberOfKills + " that's what should have been the number");

            if (names == "Master")
            {
                Console.WriteLine("yes, my Master");
            }
            else if (letter == 'A')
            {
                Console.WriteLine("Hallo!");
            }
            else 
            { 
                Console.WriteLine("what?");
            }
        }

        static string FormatIntoMadLib(string noun, string adjective, string verb)
        {
            return noun + " " + verb + "ed in the garder made up of " + adjective + " flowers"; //the return simply makes this line the output of the function,
                                                                                                //so you can store it into a variable later and actively use it
        }

        static string PracticeFunctions(string noun, string adjective, string verb)
        {
            return "morning" + noun + " " + verb + "es upon the earliest signs of the " + adjective + " warmth";
        }

        /*
        static int Number(string word)
        {
            // this code will take in values of string and then output value of int, like you can input a word
            // and then function will determine the length of the word and give you the number
        }
        */

        static int getDamage(int attack, int defense) //will find the damage taken by the player depending on their defense and the attack
        {
            return attack - defense;
        }
    }
}