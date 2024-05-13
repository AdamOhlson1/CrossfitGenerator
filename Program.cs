using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

class Program {
    static void Main() 
    {
        /* Här får man välja vilken stil man vill ha på sin workout för att sedan hamna 
        i en specifik funktion som bygger den åt en */
        WriteLine("What style workout would you like today?\n 1. For time\n 2. AMRAP\n 3. EMOM\n");
        int WorkoutStyle = Convert.ToInt32(ReadLine());

       switch (WorkoutStyle)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:

                    break;
                default:
                    WriteLine("Error invalid choice. Press enter to continue");
                    ReadLine();
                    Main();
                    break;
            }
        
        WriteLine("This is your workout:\n ");
    
    }
} 

    public static void Exercises() 
    {
        List<string> CFExercises = new List<string>
        {
            "Burpees", "Pull-ups", "Wall Balls", "Push Ups", "Handstand Walk", "Handstand Push-up", "Thursters", "Box Jumps"
        };
    }

    public static void ForTime()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());
    }

    public static void AMRAP()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());
    }

    public static void EMOM()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());
    }