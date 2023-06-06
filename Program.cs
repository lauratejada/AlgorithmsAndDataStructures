/************ LAB 03 **************/
/*Lab - Complexity
Create new methods to solve each of the following problems.

1. We have a list of integers where elements appear either once or twice. 
Find the elements that appeared twice in O(n) time.
example: {1, 2, 3, 4, 7, 9, 2, 4} returns '{2, 4}
The solution time complexity is: O3n or On
*/
Console.WriteLine("Instruction 1:");

int[] input = { 1, 2, 3, 4, 7, 9, 2, 4 };

HashSet<int> uniqueValues = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

Dictionary<int, int> intCounter = new Dictionary<int, int>();

// if the give input has content of integers
if (input.Length > 0)
{
    Console.WriteLine("Given array is: ");
    Console.WriteLine(string.Join(", ", input));
    //Console.WriteLine(String.Join(", ", uniqueValues.ToArray()));

    // first, we fill our dictionary with unique integers [0 -9];
    foreach (int integer in uniqueValues)
    {
        intCounter.Add(integer, 0);
    }
    // second, we fill our dictionary with the number of integers in the given array;
    foreach (int integer in input)
    {
        intCounter[integer]++;
    }
    //  third, print the integer that appear twice;
    Console.WriteLine("The result is:");
    foreach (KeyValuePair<int, int> element in intCounter)
    {
        if (element.Value == 2)
            Console.Write($"{element.Key}, ");
    }

}
else
{
    Console.WriteLine("The input should be an array of integers");
}

Console.WriteLine();
Console.WriteLine("-------------------");

/*
2. We have two sorted int arrays which could be with different sizes. 
We need to merge them in a third array while keeping this result array sorted. 
Can you do that in O(n) time? 
Don't use any extra structures like Sets or Dictionaries
example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}}
returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
*/

Console.WriteLine("Instruction 2:");

int[] intArray1 = new int[] { 1, 2, 3, 4, 5 };
int[] intArray2 = new int[] { 2, 5, 7, 9, 13 };

if (intArray1.Length <= 0 && intArray2.Length <= 0)
{
    throw new Exception("The input is not valid, please enter two arrays of integers");
}

Console.WriteLine("Given arrays are:");
Console.WriteLine(string.Join(", ", intArray1));
Console.WriteLine(string.Join(", ", intArray2));

int[] intArray3 = new int[intArray1.Length + intArray2.Length];
int index1 = 0;
int index2 = 0;
int index3 = 0;
// Compare and assign the values of each array into the new array
// until the lower array length is reached
while (index1 < intArray1.Length && index2 < intArray2.Length)
{
    if (intArray1[index1] < intArray2[index2])
    {
        intArray3[index3] = intArray1[index1];
        index1++;
        index3++;
    }
    else if (intArray1[index1] >= intArray2[index2])
    {
        intArray3[index3] = intArray2[index2];
        index2++;
        index3++;
    }
}

//Console.WriteLine("First while");
// If the length of this array is higher than the other array(intArray1.Length > intArray2.Length),
// so save the rest of its values in the new array
while (index1 < intArray1.Length)
{
    intArray3[index3] = intArray1[index1];
    index1++;
    index3++;
}
//Console.WriteLine("Second while");
// If the length of this array is higher than the other array(intArray2.Length > intArray1.Length),
// so save the rest of its values in the new array
while (index2 < intArray2.Length)
{
    intArray3[index3] = intArray2[index2];
    index2++;
    index3++;
}
//Console.WriteLine("Third while");
Console.WriteLine("The result is: ");
Console.Write(string.Join(", ", intArray3));
//Console.Write("} ");

Console.WriteLine();
Console.WriteLine("This solution has a time complexity of O3n or O(n)");
Console.WriteLine("-------------------");
/*
3. Given an integer, reverse the digits of that integer, 
e. g. input is 3415, output is 5143. 
What is the time complexity of your solution?
 */
Console.WriteLine("Instruction 3:");
int input3 = 3415;
if (input3 <= 0)
{
    throw new Exception("The input is not an valid integer");
}

Console.WriteLine("Given input is: ");
Console.WriteLine($"{input3}");
// convert integer into an array of chars
char[] temp3 = input3.ToString().ToCharArray();
Console.WriteLine("The result is: ");
for (int i = temp3.Length - 1; i >= 0; i--)
{
    //printing each value reversed
    Console.Write(temp3[i]);
}
Console.WriteLine("");
Console.WriteLine("The time complexity is On");
Console.WriteLine("-------------------");