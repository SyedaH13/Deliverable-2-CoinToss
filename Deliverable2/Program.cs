// See https://aka.ms/new-console-template for more information
/*
The challenge should have five rounds.
During each round the program secretly picks a random number: 0 or 1
Ask the user for heads or tails. Compare it to the random number.
These won’t nicely compare. You will have to come up with how heads and tails relate to 0 and 1.
Each right answer adds one to the total.

The challenge: Create a variable that holds the score. Start it to 0. Create a loop that runs five times.
During each loop, get a random number and store that value. That should be a 0 or a 1. Ask the user to enter heads or tails and then store their response. 
You will then have to compare the random number to the user input. These values will not compare together normally. You will have to get creative to compare them. 
If the user has successfully guessed the answer, add one to their score and tell the user. Once the loop has finished, the challenge is over.
Tell the user their score.

 Welcome to the COIN FLIP CHALLENGE!
What is your name?
>Grant Chirpus
Welcome Grant Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No
>No
You are a coward Grant Chirpus

Example 2:
Welcome to the COIN FLIP CHALLENGE!
What is your name?
>Grant Chirpus
Welcome Grant Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No
>Yes
Heads or Tails?
>Heads
Correct!
Heads or Tails?
>Heads
Wrong!
(This repeats 3 more times. Pretend they got it right 2 more times)
Thank you Grant Chirpus. You got a score of 3!

GRADING CRITERIA
-Ask the user for their name and store it.
-The name is used throughout the program
-The user is called a coward if they do not agree to the COIN FLIP CHALLENGE
-Only do the COIN FLIP CHALLENGE if the user agrees.
-Loop the challenge 5 times
-The program grabs a random number between 0 and 1 (You still get this point even if nothing is done with it.)
-The user is asked for heads or tails and their value is stored.
A solution was found to compare the random number to the heads or tails input that works.
- Every correct answer adds one to the score.
The score is displayed at the end of the challenge

 */

using System.Threading.Tasks;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name??");
 String Name = Console.ReadLine();
Console.WriteLine("Welcome " + Name + ", would you like to play the COIN FLIP CHALLENGE? Answer Yes/No:");
String Answer = Console.ReadLine();

int totalScore = 0;

if (Answer == "Yes" || Answer == "yes") { 
 // Console.WriteLine("Good answer " + Name + ", Heads or Tails?");

    for (int i = 0; i <= 4; i++)
    {
        Random random = new Random();
        int RandomNumber = random.Next(0,2);

        Console.WriteLine("Good answer " + Name + ", Heads or Tails?");
        String choice = Console.ReadLine();

        if (RandomNumber == 0 && choice == "Heads")
        {
            Console.WriteLine("Correct!");
            totalScore += 1;
        } else if (RandomNumber == 1 && choice == "Tails")
        {
            Console.WriteLine("Correct!");
            totalScore += 1;
        } else if (RandomNumber == 0 && choice == "Tails")
        {
            Console.WriteLine("Wrong!");
        } else if (RandomNumber == 1 && choice == "Heads")
        {
            Console.WriteLine("Wrong!");
        }
        
    }
    Console.WriteLine("Thank you " + Name + "!! Your total score is " + totalScore + ". Come again!");





} else if (Answer == "No" || Answer == "no") {
    //Console.WriteLine("You did not answer a valid answer. Please answer Yes/No!!");
    Console.WriteLine("You are a coward " + Name + ",Try again!!");


} else
{
    Console.WriteLine("You did not answer a valid answer. Please answer Yes/No!!");
}

