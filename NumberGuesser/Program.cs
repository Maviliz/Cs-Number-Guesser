// See https://aka.ms/new-console-template for more information
using System;

    //TODO: Random answer maker works and outputs a string answer. Need to work on the comparison method, and the statusCheck method. 

Random rnd = new Random();
string answer = "";

string answerMaker() { return Convert.ToString(rnd.Next(1, 7)); }

for (int i =0; i<4; i++)
{
    answer += answerMaker();
}
int attemptsTaken = 0;
int maxAttempts = 10;
string userGuess;

Console.WriteLine(answer);

 string takeAGuess () { 
    Console.Write("Please enter a 4-digit number. All digits must be between the numbers 1-6: ");
    userGuess = Console.ReadLine();
    Console.WriteLine(userGuess + " is the user's guess");
    attemptsTaken++;
    return userGuess;
}

 void statusCheck(string result)
{
    if (result.Equals("++++"))
    {
        Console.WriteLine("Congratulations! You have correctly guessed the code and won the game!");
        Environment.Exit(0);
    }
    else
    {
        if (attemptsTaken < maxAttempts)
        {
            int attemptsLeft = maxAttempts - attemptsTaken;
            Console.WriteLine("Try again! You have " + attemptsLeft + " remaining attempt(s).");
        }
        Console.WriteLine(answerMaker + " is the code to guess");
    }
}

//string compareNumber(string answer)
//{
//    //Done: write function to compare numbers: loop through each digit, return -,+, or " " depending on comparison result
//    //String comparison for '-' check was not working, switched to char for easier comparison
//    string result = "";
//    for (int i = 0; i < answer.Length(); i++)
//    {
//        char current = userGuess.charAt(i);
//        if (number.charAt(i) == answer.charAt(i))
//        {
//            result = result + "+";
//        }
//        else
//        {
//            boolean contains = false;
//            for (int j = 0; j < answer.Length(); j++)
//            {
//                if (current == answer.charAt(j))
//                {
//                    result = result + "-";
//                    contains = true;
//                    break;
//                    //fixed: fix this logic because it's still printing " " for all other digits of target
//                }
//            }
//            if (!contains)
//            {
//                result = result + " ";
//            }
//        }

//    }
//    Console.WriteLine(result);
//    return result;
//}

TakeAGuess();