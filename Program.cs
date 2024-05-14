using System;
using System.Collections.Generic;
using static System.Console;

public class Program {

    static void Main() 
    {
        /* Här får man välja vilken stil man vill ha på sin workout för att sedan hamna 
        i en specifik funktion som bygger den åt en */
        WriteLine("What style workout would you like today?\n 1. For time\n 2. AMRAP\n 3. EMOM\n");
        int WorkoutStyle = Convert.ToInt32(ReadLine());

       switch (WorkoutStyle)
       {
           case 1:
               ForTime();
               break;
           case 2:
               AMRAP();
               break;
           case 3:
               EMOM();
               break;
           default:
               WriteLine("Error invalid choice. Press enter to continue");
               ReadLine();
               Main();
               break;
       }
    }    
     
    public static List<string> Exercises(int numExercises)   
    {
        List<string> CFExercises = new List<string>
        {
            "Burpees", "Pull-ups", "Wall Balls", "Push Ups", "Handstand Walk", "Handstand Push-up", "Thursters", "Box Jumps"
        };

        Random random = new Random();
        List<string> selectedExercises = new List<string>();
    
        for (int i = 0; i < numExercises; i++)
        {
            int index = random.Next(CFExercises.Count);
            selectedExercises.Add(CFExercises[index]);
            CFExercises.RemoveAt(index); // Undvik dubbletter
        }

        return selectedExercises;
    }

    public static void ForTime()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());

        int rounds;
        int numExercises;
        
        switch (Duration)
        {
            case 1:
                rounds = 3;
                numExercises = 3; 
                break; 
            case 2:
                rounds = 5;
                numExercises = 5;
                break;
            case 3:
                rounds = 10;
                numExercises = 7;
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

        List<string> exercises = Exercises(numExercises);

        WriteLine($"Your workout is:\n For time {rounds} rounds\n");

        foreach (string exercise in exercises)
        {
            WriteLine(exercise);
        }
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
  
}