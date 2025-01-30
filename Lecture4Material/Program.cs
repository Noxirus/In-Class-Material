// See https://aka.ms/new-console-template for more information

// Generate a random number from 1 - 100
int randomNumber = new Random().Next(0, 100) + 1;

// Ask the player to enter a number with this range in mind
Console.WriteLine("Guess a number between 1 and 100");
if (int.TryParse(Console.ReadLine(), out int guessedNumber))
{
    Console.WriteLine($"You Guessed: {guessedNumber}");
    if (guessedNumber > randomNumber)
    {
        Console.WriteLine("You guessed too high!");
    }
    else if (guessedNumber < randomNumber)
    {
        Console.WriteLine("You guessed too low!");
    }
    else
    {
        Console.WriteLine("Correct!");
    }
}
else
{
    Console.WriteLine("Please enter a valid number");
}

Console.WriteLine("You Guessed: " + guessedNumber);


// check to see if the guess was correct
// check if number is too high or too low
// display result of the number guess based on these conditions
// IF correct, inform the player, end the game
// IF incorrect, inform the player the number was higher or lower
// THEN loop back and get the player to guess again