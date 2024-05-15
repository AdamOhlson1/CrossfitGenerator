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

/* Här kallar jag på de olika funktionerna beroende på valet av workout man vill göra.
Detta tycker jag gör koden mer lättläst och enkel att följa */

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
     
/* Här har jag gjort en funktion med ett antal övningar, jag ska utveckla denna ytteliggare allt eftersom.
Här vill jag även kunna utveckla så att programmet kan ge ut ett antal reps som är anpassat
efter längden på passet */
    public static List<string> Exercises(int numExercises)   
    {
        List<string> CFExercises = new List<string>
        {
            "Burpees", "Pull-ups", "Wall Balls", "Push Ups", "Handstand Walk", "Handstand Push-up", "Thursters", "Box Jumps"
        };

/* Denna delen ser väldigt kladdig ut så får fina till den senare, men den skapar tar ut ett random antal
övningar och skapar en random lista av de. Sedan kollar den helt enkelt så att övningen inte duppliceras
utan när stringen har används en gång så blir den borttagen, detta är också något sim behöver ändras
ifall man vill skapa en chipper */

        Random random = new Random();
        List<string> selectedExercises = new List<string>();
    
        for (int i = 0; i < numExercises; i++)
        {
            int index = random.Next(CFExercises.Count);
            selectedExercises.Add(CFExercises[index]);
            CFExercises.RemoveAt(index); 
        }

        return selectedExercises;
    }
/* Här kommer första funktionen för typen av "metcon", för att göra det lätt i början så har jag ett 
satt antal rundor och övningar beroende på längden på workout, men allt eftersom att jag utvecklar 
programmet så ska även det bli mer avancerat och ligga inom ett spann istället */
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

/* Här kallar jag på övnings-funktionen för att kunna skriva ut de random genererade övningarna. 
Tycker dock det skrivs ut väldigt fult så det får förfinas sen och som sagt ändra så att det inte är 
fast satta antal övningar och rundor utan randomiserat utefter ett spann */

        List<string> exercises = Exercises(numExercises);

        WriteLine($"Your workout is:\nFor time {rounds} rounds\n");

        foreach (string exercise in exercises)
        {
            WriteLine(exercise);
        }
    }

    public static void AMRAP()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());

        int amrapLength;
        int numExercises;

        switch (Duration)
        {
            case 1:
                amrapLength = 10;
                numExercises = 3; 
                break; 
            case 2:
                amrapLength = 15;
                numExercises = 5;
                break;
            case 3:
                amrapLength = 20;
                numExercises = 7;
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

            List<string> exercises = Exercises(numExercises);

            WriteLine($"Your workout is:\nAmrap {amrapLength} \n");

            foreach (string exercise in exercises)
            {
            WriteLine(exercise);
            }    
        
    }

    public static void EMOM()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10min\n 2. 15min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());

        int numExercises;
        int emomLength;

        switch (Duration)
        {
            case 1:
                emomLength = 10;
                numExercises = 3; 
                break; 
            case 2:
                emomLength = 15;
                numExercises = 5;
                break;
            case 3:
                emomLength = 20;
                numExercises = 7;
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

            List<string> exercises = Exercises(numExercises);

            WriteLine($"Your workout is:\nEMOM {emomLength} \n");

            foreach (string exercise in exercises)
            {
            WriteLine(exercise);
            } 

    }
  
}