/***********   LAB 02   ************/
using System;
using System.Text;
/*
 * 1. A program that produces an array of all of the characters that appear more than once in a string.
 * For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t']. 
 */
Console.WriteLine("Instruction 1:");
string stringInput = "Programmatic Python";

StringBuilder auxString = new StringBuilder("");

if (stringInput.Trim().Length > 1)
{
    Console.WriteLine($"Given string is: {stringInput} ");

    stringInput = stringInput.ToLower();

    for (int i = 0; i < stringInput.Length; i++)
    {
        for (int j = i + 1; j < stringInput.Length; j++)
        {
            if (stringInput.ElementAt(i) == stringInput.ElementAt(j) && !(stringInput.ElementAt(j) == ' '))
            {
                if (!auxString.ToString().Contains(stringInput.ElementAt(j)))
                {
                    auxString.Append(stringInput.ElementAt(j));
                }
            }
        }
    }
    char[] resultToCharArray = auxString.ToString().ToCharArray();
    Console.Write("['");
    Console.Write(String.Join("','", resultToCharArray));
    Console.WriteLine("']");
}
Console.WriteLine("-------------------");

/*
 *2.  A program returns an array of strings that are unique words found in the argument.
For example, the string “To be or not to be” returns ["to","be","or","not"].
 */
Console.WriteLine("Instruction 2:");
string stringInput2 = "To be or not to be that is the question";

if (stringInput2.Trim().Length > 1)
{
    Console.WriteLine($"Given string is: {stringInput2} ");

    stringInput2 = stringInput2.ToLower();
    string[] tempString = stringInput2.Split(' ');
    //Console.Write(String.Join(", ",tempString));
    StringBuilder auxString2 = new StringBuilder("");

    auxString2.AppendLine(tempString[0]); // to initialice with "to"

    for (int i = 0; i < tempString.Length - 1; i++)
    {
        for (int j = i + 1; j < tempString.Length; j++)
        {
            if (!(tempString[i] == tempString[j]) && !(tempString[i] == " "))
            {
                if (!auxString2.ToString().Contains(tempString[j]))
                {
                    auxString2.AppendLine(tempString[j]);
                }
            }
        }
    }
    String resultToCharArray2 = auxString2.ToString();
    Console.Write("[\"");
    // Console.Write(resultToCharArray2);
    // Console.Write(String.Join("\", \"", resultToCharArray2.ReplaceLineEndings(", ")));
    Console.Write(resultToCharArray2.Trim().ReplaceLineEndings("\", \""));
    Console.WriteLine("\"]");
}
Console.WriteLine("-------------------");
/*
 * 3. A program that reverses a provided string 
 */
Console.WriteLine("Instruction 3:");
string stringInput3 = "Programming";
StringBuilder auxString3 = new StringBuilder("");

if (stringInput3.Trim().Length > 1)
{
    Console.WriteLine($"Given string is: {stringInput3} ");

    for (int i = stringInput3.Length - 1; i >= 0; i--)
    {
        auxString3.Append(stringInput3.ElementAt(i));
    }
    Console.WriteLine($"Reversed string is: {auxString3} ");
}
Console.WriteLine("-------------------");
/* 
4. A program that finds the longest unbroken word in a string and prints it
For example, the string "Tiptoe through the tulips" would print "through"
If there are multiple words tied for greatest length, print the last one
 */
Console.WriteLine("Instruction 4:");
string stringInput4 = "Tiptoe through the tulips";
StringBuilder auxString4 = new StringBuilder("");
int greatestLength = 0;

if (stringInput4.Trim().Length > 1)
{
    Console.WriteLine($"Given string is: {stringInput4} ");
    string[] tempString4 = stringInput4.Split(' ');
    // Console.Write(String.Join("','", tempString4));
    for (int i = 0; i < tempString4.Length; i++)
    {
        if (tempString4[i].Length >= greatestLength)
        {
            greatestLength = tempString4[i].Length;
            auxString4.Clear();
            auxString4.Append(tempString4[i]);
        }
    }
    Console.WriteLine($"The word with greatest length is: {auxString4} ");
}
Console.WriteLine("-------------------");
/*
 * Research and employ the StringBuilder class and explain its advantages or disadvantages over Strings.
 */
Console.WriteLine("StringBuilder allows you to manipulate strings without declaring an initial length, " +
    "which is useful when you do not know the length of the string that you want to work with. " +
    "Working with StringBuilder allows you to save memory space since it mutable, " +
    "contrary to string that is inmutable. A disadvantage is that StringBuilder" +
    " can can not be used when manipulating multiple data at the same time");
Console.WriteLine("-------------------");