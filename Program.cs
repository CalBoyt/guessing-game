using System;
using System.Globalization;
namespace GuessingGame

{
class Program
{
    static void Main(string[] args)
    {
//Sarah's Review Code:
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2
// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.
// Use a random number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.
// Inform the user if their guess was too high or too low, when they guess incorrectly.
// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.
// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

            Console.WriteLine("Wanna play a game?");
            Console.WriteLine("Choose your difficulty level");
            Console.WriteLine("Press 1: Easy Peasy Lemon Squeezy");
            Console.WriteLine("Press 2: Sure, Jan");
            Console.WriteLine("Press 3: Difficult difficult lemon difficult");
            Console.WriteLine("Press 4: So you've chosen death");
            string level = Console.ReadLine();
            switch(level) {
                case "1":
                gameTime(8);
                break;
                case "2":
                gameTime(6);
                break;
                case "3": 
                gameTime(4);
                break;
                case "4":
                Console.WriteLine("Cheater Cheater Pumpkin Eater");
                gameTime(Int32.MaxValue);
                break;
            }



            void gameTime (int attempts)
            {    
                int secretNumber = new Random().Next(0, 100);
                int i = 0;

            while (i < attempts)
            {
            Console.WriteLine("Guess the number");
            Console.WriteLine($"You have {attempts - i} guess(es) remaining");

            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            if(parsedUserInput == secretNumber) 
            {
                Console.WriteLine("Great job. You did it. WOW.");
                break;
            }
            else 
            {
                string help = parsedUserInput > secretNumber ? "The rent is too damn high" : "Too low. Cockroaches and bedbugs"; 
                Console.WriteLine($"WRONG-O! TRY AGAIN! {help}");
                i++;
            }
            }

            }

// //Phase 1 and 2
// Console.Write("Please guess the secret number: ");

// int guess = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Your guess is: {guess}!");

// int secNum = 42;

// if (guess != secNum)
// {
//     Console.WriteLine("fail!");

// }
// else
// {
//     Console.WriteLine("success!");
// }


// Phase 3-6
// class Program
// {
//     static void Main(string[] args)
//     {
//         Random random = new Random();
//         bool playAgain = true;
//         int min = 1;
//         int max = 100;
//         int guess;
//         int number;
//         int guesses;
//         int maxGuesses = 4;
//         String response;

//         while (playAgain)
//         {
//             guess = 0;
//             guesses = 0;
//             response = "";
//             number = random.Next(min, max + 1);

//             while (guess != number && guesses < maxGuesses)
//             {
//                 Console.WriteLine("GUESS THE SECRET NUMBER!");
//                 Console.WriteLine("This is guess # " +(guesses + 1) + ". Maximum guesses allowed: 4. " + "Guess a number between " + min + " - " + max + " : ");
//                 guess = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Guess: " + guess);

//                 if (guess > number)
//                 {
//                     Console.WriteLine(guess + " is too high!");
//                 }
//                 else if (guess < number)
//                 {
//                     Console.WriteLine(guess + " is too low!");
//                 }
//                 else if (guess == number)
//                 {
//                     Console.WriteLine("YOU WIN!");
//                     playAgain = false;    
//                 }
//                 guesses++;
//             }
//             Console.WriteLine("Number: " + number);
//             Console.WriteLine("Maximum guesses allowed: 4");

//             Console.WriteLine("Would you like to play again?(Y/N): ");
//             response = Console.ReadLine();
//             response = response.ToUpper();

//             if (response == "Y")
//             {
//                 playAgain = true;
//             }
//             else
//             {
//                 playAgain = false;
//             }
//         }

//         Console.WriteLine("Thanks for playing! ... I guess");

//         Console.ReadKey();
//     }
// }


// //My attmpt at Phase 7, but it's broken

//         Random random = new Random();
//         bool playAgain = true;
//         int min = 1;
//         int max = 100;
//         int guess;
//         int number;
//         int guesses;
//         int maxGuesses = 4;
//         String response;

//             Console.WriteLine("GUESS THE SECRET NUMBER!");
//              Console.WriteLine("Press button to choose difficulty level: ");
//              Console.WriteLine("Press 1: Easy");
//              Console.WriteLine("Press 2: Medium");
//              Console.WriteLine("Press 3: Difficult");

//              string level = Console.ReadLine();
//              switch(level) {
//                 case "1":
//                 gameTime(8);
//                 break;
//                 case "2":
//                 gameTime(6);
//                 break;
//                 case "3":
//                 gameTime(4);
//                 break;                  

//         void gameTime (int guesses)
//         {
//             while (playAgain)
//             {
//             guess = 0;
//             guesses = 0;
//             response = "";
//             number = random.Next(min, max + 1);

             
//              }

//             while (guess != number)
//             {
               
//                 Console.WriteLine("This is guess # " + (guesses + 1) + ". " + (maxGuesses - (guesses + 1)) + " guess(es) remaning. " + "Guess again: ");
                
//                 guess = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Guess: " + guess);

//                 if (guess > number)
//                 {
//                     Console.WriteLine(guess + " is too high!");
//                 }
//                 else if (guess < number)
//                 {
//                     Console.WriteLine(guess + " is too low!");
//                 }
//                 else if (guess == number)
//                 {
//                     Console.WriteLine("YOU WIN!");
//                     playAgain = false;    
//                 }
//                 guesses++;
//             }
//             Console.WriteLine("Number: " + number);
//             Console.WriteLine("Maximum guesses allowed: 4");

//             Console.WriteLine("Would you like to play again?(Y/N): ");
//             response = Console.ReadLine();
//             response = response.ToUpper();

//             if (response == "Y")
//             {
//                 playAgain = true;
//             }
//             else
//             {
//                 playAgain = false;
//             }
//         }

//         Console.WriteLine("Thanks for playing! ... I guess");

//         Console.ReadKey();
//         }
    }
}



 

}