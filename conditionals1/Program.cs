using System;

namespace conditionals1
{
    class MainClass
    {
        //static int highscore = 100;
        //static string highscorePlayer = "Larry";

        //public static void clarifyScore(int score, string playerName)
        //{
        //    if(score > highscore)
        //    {
        //        highscore = score;
        //        Console.WriteLine("New highscore is " + score + "!");
        //        highscorePlayer = playerName;
        //        Console.WriteLine("New highscore holder is " + playerName + "!");
        //    } else
        //    {
        //        Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer + ".");
        //    }
        //}

        public static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            //stateOfMatter = (temperature < 0) ? "solid" : "liquid";
            stateOfMatter = (temperature < 0) ? "solid" : (temperature > 70) ? "gas" : "liquid";
            Console.WriteLine("The state of matter at " + temperature + " degrees Celcius is: " + stateOfMatter);
            temperature += 30;
            //stateOfMatter = (temperature < 0) ? "solid" : "liquid";
            stateOfMatter = (temperature < 0) ? "solid" : (temperature > 70) ? "gas" : "liquid";
            Console.WriteLine("The state of matter at " + temperature + " degrees Celcius is: " + stateOfMatter);
            temperature += 80;
            stateOfMatter = (temperature < 0) ? "solid" : (temperature > 100) ? "gas" : "liquid";
            Console.WriteLine("The state of matter at " + temperature + " degrees Celcius is: " + stateOfMatter);


            ////////////////////////////
            ///// High Score Check /////
            ////////////////////////////
            //clarifyScore(75, "Charles");
            //clarifyScore(175, "Bob");
            //clarifyScore(150, "Lucy");
            //clarifyScore(200, "Matt");

            //int age = 15;
            ///////////////////////////////
            //////// If - Else ////////////
            ///////////////////////////////
            //if(age == 15)
            //{
            //    Console.WriteLine("Sorry, you're too young.");
            //} else if (age == 25)
            //{
            //    Console.WriteLine("You're good to go!");
            //} else
            //{
            //    Console.WriteLine("How old are you, then?");
            //}

            ///////////////////////////////
            //////// Switch - Case ////////
            ///////////////////////////////
            //switch(age)
            //{
            //    case 15:
            //        Console.WriteLine("Sorry, you're too young.");
            //        break;
            //    case 25:
            //        Console.WriteLine("You're good to go!");
            //        break;
            //    default:
            //        Console.WriteLine("How old are you, then?");
            //        break;
            //}
        }
    }
}
