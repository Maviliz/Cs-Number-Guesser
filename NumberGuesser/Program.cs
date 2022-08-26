// See https://aka.ms/new-console-template for more information
using System;

    //TODO: Random answer maker works and outputs a string answer. Need to work on the comparison method, and the statusCheck method. 

Random rnd = new Random();
string answer = "";

string answerMaker() { return Convert.ToString(rnd.Next(1, 7)); }

bool IsAllDigits(string uG)
{
    foreach (char c in uG)
    {
        if (!char.IsDigit(c))
            return false;
    }
    return true;
}

for (int i =0; i<4; i++)
{
    answer += answerMaker();
}
int attemptsTaken = 0;
int maxAttempts = 10;
string userGuess;


//Console.WriteLine(answer);

 string TakeAGuess () { 
    Console.Write("Please enter a 4-digit number. All digits must be between the numbers 1-6: ");
    userGuess = Console.ReadLine();
 
    while (userGuess.Length != 4)
    {
        Console.WriteLine("Your guess must be 4 digits long. Please enter a 4-digit number made up of numbers between 1-6: ");
        userGuess = Console.ReadLine();
        
    }
    while (IsAllDigits(userGuess) == false)
    {
        Console.WriteLine("Your guess must be 4 digits, each a number between 1-6: ");
        userGuess = Console.ReadLine();
    }

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
            Console.WriteLine("\nTry again! You have " + attemptsLeft + " remaining attempt(s).");
        } else
        {
            Console.WriteLine("Max of 10 attempts reached. Game over :(");
        }
    }
}

string compareNumber(string answer, string userGuess)
{
    string result = "";
    for (int i = 0; i < answer.Length; i++)
    {
        char current = userGuess[i];
        if (userGuess[i] == answer[i])
        {
            result = result + "+";
        }
        else
        {
            bool contains = false;
            for (int j = 0; j < answer.Length; j++)
            {
                if (current == answer[j])
                {
                    result = result + "-";
                    contains = true;
                    break;
                    
                }
            }
            if (!contains)
            {
                result = result + " ";
            }
        }

    }
    Console.WriteLine(result);
    return result;
}

statusCheck(compareNumber(answer, TakeAGuess()));

while (attemptsTaken < maxAttempts)
{
    statusCheck(compareNumber(answer, TakeAGuess()));
}