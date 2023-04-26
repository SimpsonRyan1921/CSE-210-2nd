using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayNameAndNumber(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string userFavNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userFavNumber);

        return favoriteNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayNameAndNumber(string userName, int square)
    {
        Console.WriteLine($"{userName}, your number squared is {square}");
    }
}