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
            "Burpees", "Pull-ups", "Wall Balls", "Push Ups", "Handstand Walk", "Handstand Push-up", "Thursters", "Box Jumps", "Rodd", "BMU"
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

/* Ändrade om här så att det slumpas mellan antalet rundor och antalet övningar, det krävs ytteliggare
fin justering för att det verkligen ska passa tidsdomänen. Men hittills funkar det hyfsat. Jag vill 
tillsist att antalet rundor ska anpassa antalet övningar och vise versa för att få den så korrekt 
som möjligt */

        int minRounds, maxRounds, minExercises, maxExercises;
        Random random = new Random();
        
        switch (Duration)
        {
            case 1:
                minRounds = 2;
                maxRounds = 4;
                minExercises = 2; 
                maxExercises = 5;
                break; 
            case 2:
                minRounds = 3;
                maxRounds = 6;
                minExercises = 4; 
                maxExercises = 6;
                break;
            case 3:
                minRounds = 7;
                maxRounds = 10;
                minExercises = 7; 
                maxExercises = 10;
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

        int rounds = random.Next(minRounds, maxRounds + 1); 
        int numExercises = random.Next(minExercises, maxExercises + 1);

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
        WriteLine("How long would you like the workout to be?\n 1. 5-10min\n 2. 10-15min\n 3. 15-20min\n");
        int Duration = Convert.ToInt32(ReadLine());

        int minAmrapLength, maxAmrapLength, minExercises, maxExercises;
        Random random = new Random();

        switch (Duration)
        {
            case 1:
                minAmrapLength = 5;
                maxAmrapLength = 10;
                minExercises = 2;
                maxExercises= 4; 
                break; 
            case 2:
                minAmrapLength = 10;
                maxAmrapLength = 15;
                minExercises = 3;
                maxExercises= 5; 
                break;
            case 3:
                minAmrapLength = 15;
                maxAmrapLength = 20;
                minExercises = 5;
                maxExercises= 7; 
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

            int amrapLength = random.Next(minAmrapLength, maxAmrapLength + 1); 
            int numExercises = random.Next(minExercises, maxExercises + 1);

            List<string> exercises = Exercises(numExercises);

            WriteLine($"Your workout is:\nAmrap {amrapLength} \n");

            foreach (string exercise in exercises)
            {
            WriteLine(exercise);
            }    
        
    }

    public static void EMOM()
    {
        WriteLine("How long would you like the workout to be?\n 1. 10-14min\n 2. 15-20min\n 3. 20+min\n");
        int Duration = Convert.ToInt32(ReadLine());

        int minEmomLength, maxEmomLength, minExercises, maxExercises;
        Random random = new Random();

        switch (Duration)
        {
            case 1:
                minEmomLength = 10;
                maxEmomLength = 14;
                minExercises = 2;
                maxExercises = 4; 
                break; 
            case 2:
                minEmomLength = 15;
                maxEmomLength = 18;
                minExercises = 3;
                maxExercises = 5; 
                break;
            case 3:
                minEmomLength = 20;
                maxEmomLength = 40;
                minExercises = 4;
                maxExercises = 6; 
                break;
            default:
                WriteLine("Error invalid choice. Press enter to continue");
                ReadLine();
                Main();
                return;
        }

            int emomLength = random.Next(minEmomLength, maxEmomLength + 1); 
            int numExercises = random.Next(minExercises, maxExercises + 1);

            List<string> exercises = Exercises(numExercises);

            WriteLine($"Your workout is:\nEMOM {emomLength} \n");

            foreach (string exercise in exercises)
            {
            WriteLine(exercise);
            } 

    }
  
}