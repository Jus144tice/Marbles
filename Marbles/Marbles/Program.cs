Console.WriteLine("Guess a random number between 1 and 10:");
int userGuess = int.Parse(Console.ReadLine());
Console.WriteLine("You guessed: " + userGuess);

Random rnd = new Random();
int computerGuess = rnd.Next() % 10 + 1;

Console.WriteLine("The computer guessed: " + computerGuess);

if (userGuess == computerGuess)
{
    Console.WriteLine("You got it right!");
}
else
{
    Console.WriteLine("That is wrong, good try");
}

String userInput;
Console.WriteLine("Enter a string:");

userInput = Console.ReadLine();
Console.WriteLine("You typed: " + userInput);

while (userInput != "Hello")
{
    Console.WriteLine("I don't understand, can you try again?");
    userInput = Console.ReadLine();
    Console.WriteLine("You typed: " + userInput);
}

Console.WriteLine("Nice to meet you");