// See https://aka.ms/new-console-template for more information

using Lecture4Material;
using Lecture4Material.TextAdventure;
TextGame newGame = new TextGame();
newGame.PlayGame();
return;

int randomNumber = new Random().Next(0, 100) + 1;
bool playingGame = true;
int guessesRemaining = 10;

while (playingGame)
{
    Console.WriteLine("Guess a number between 1 and 100");
    if (int.TryParse(Console.ReadLine(), out int guessedNumber))
    {
        guessesRemaining--;
        Console.WriteLine($"You Guessed: {guessedNumber}");
        if (guessedNumber > randomNumber)
        {
            Console.WriteLine("You guessed too high!");
            CheckGuessesRemaining();
        }
        else if (guessedNumber < randomNumber)
        {
            Console.WriteLine("You guessed too low!");
            CheckGuessesRemaining();
        }
        else
        {
            Console.WriteLine($"You guessed correct with {guessesRemaining} guesses remaining");
            playingGame = false;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number");
    }
}

void CheckGuessesRemaining()
{
    if (guessesRemaining == 0)
    {
        Console.WriteLine("Out of guesses!");
        playingGame = false;
    }
    else
    {
        Console.WriteLine($"You have {guessesRemaining} guesses left");
    }
}
// IF correct, inform the player, end the game
// IF incorrect, inform the player the number was higher or lower
// THEN loop back and get the player to guess again