// See https://aka.ms/new-console-template for more information

// a.First prompt a user for an integer, n, the length of the array word list.
// Create a int variable and get user input from the keyboard and store it in the variable
using System.Text.RegularExpressions;

int n = 0;
while (n <= 0)
{   // validation
    Console.WriteLine("Please enter an integer value greater than zero:");
    n = Int32.Parse(Console.ReadLine());
}

// b.Then prompt the user for n words, one to fill each index in the array.
Console.WriteLine("Please enter " + n + " words:");

string[] wordsArray = new string[n]; // get console entered amount

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word # {i + 1}");
    string newWord = Console.ReadLine();
    if (newWord.Length > 0 && !newWord.Contains(' ') && Regex.IsMatch(newWord, @"^[a-zA-Z]+$"))
    {
        wordsArray[i] = newWord;
    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character.");
        i--;
    }
}

//c.Finally, the console should prompt the user to enter a single character to count.
//This is most easily done with Console.ReadKey().KeyChar.

char characterVal = ' '; // = Console.ReadKey().KeyChar;
while (!Char.IsLetter(characterVal))
{
    Console.WriteLine("\nPlease enter a character to count:");
    characterVal = Console.ReadKey().KeyChar;
}

Console.WriteLine($"\nYou entered the character '{characterVal}'"); // We use \n to go to the next line after reading the character value

//d. The console should then print the number of occurrences of that character within all of the strings provided.
// It should also inform the user if this number represents more than 25% of the total number of characters or not.
//Hint: A string is an array of chars.
// Get a count of how many times this character appears in all of the words
int charCount = 0;
int totalStringsChars = 0;
foreach (string word in wordsArray)
{
    char[] chars = word.ToCharArray();
    foreach (char c in chars)
    {
        if (Char.ToLower(c) == Char.ToLower(characterVal))
        {
            charCount++;
        }
        totalStringsChars++;
    }
}

// Print the value of each variable, which will display the input values
Console.WriteLine("The number is: " + n);
Console.WriteLine("The " + n + " words are: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(wordsArray[i]);
}

Console.WriteLine("The letter '" + characterVal + "' appears " + charCount + " times in the array.");
double percentage = 100 * charCount / totalStringsChars;
Console.WriteLine("Percentage is " + percentage);

if (percentage > 25)
{
    Console.WriteLine("This letter makes up more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine("This letter does not make up more than 25% of the total number of characters.");
}

