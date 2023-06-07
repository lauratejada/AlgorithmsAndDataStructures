/************ LAB 4 - LISTS **********/
/*
 * 1. List<int> MaxNumbersInLists(List<List<int>>) 
 * accepts as a parameter a List of Lists of Integers. 
 * It returns a new list with each element representing 
 * the maximum number found in the corresponding original list. 
 * For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}. 
 * Output the results with a message like: “List 1 has a maximum of 5. 
 * List 2 has a maximum of 9. List 3 has a maximum of 2.”
 */
using System.Collections.Generic;

Console.WriteLine("Instruction 1:");

List<List<int>> input = new List<List<int>> { new List<int>() { 1, 5, 3 }, new List<int>() { 9, 7, 3, -2 }, new List<int>() { 2, 1, 2 } };

// Create the method to get the highest values of each subList
static List<int> maxNumbersInLists(List<List<int>> list)
{
    List<int> listTemp = new List<int>();
    foreach (List<int> collection in list)
    {
        if (collection.Count > 0)
        {
            listTemp.Add(collection.Max());
        }
    }
    return listTemp;
}

// Validate length of List
if (input.Count() <= 0)
{
    throw new Exception("The datatype of the inner list has to be integers");
}

List<int> finalList = maxNumbersInLists(input);
// Printing the final results
foreach (int item in finalList)
{
    Console.Write($"List {finalList.IndexOf(item) + 1} has a maximum of ");
    Console.Write($"{item}.");
    Console.WriteLine();
}

Console.WriteLine("The time complexity of this solution is O2n or O(n)");
Console.WriteLine("-------------------");
Console.WriteLine();

/*
 * 2. String HighestGrade(List<List<int>>) 
 * accepts a list of number grades among students in different courses 
 * (where each list represents a single course), between 0 and 100. 
 * It returns the highest grade among all students in all courses.
 * For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } 
 * returns "The highest grade is 95. 
 * This grade was found in class(es) {index}".
 */
Console.WriteLine("Instruction 2:");

List<List<int>> grades = new List<List<int>> { new List<int>() { 85, 92, 67, 94, 94 }, new List<int>() { 50, 60, 57, 95 }, new List<int>() { 95 } };

// validate list of grades
if (grades.Count() <= 0)
{
    throw new Exception("The datatype of the inner list has to be integers");
}

List<int> highestGrades = maxNumbersInLists(grades);

Console.WriteLine($"The highest grade is {highestGrades.Max()}");
Console.WriteLine($"This grade was found in grade {highestGrades.IndexOf(highestGrades.Max()) + 1}");
Console.WriteLine("The time complexity of this solution is O1n or O(n)");
Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

/*
 * 3. List<int> OrderByLooping (List<int>) orders a list of integers, 
 * from least to greatest, using only basic control statements (ie. if/else, for/while).
 * For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.
 */
Console.WriteLine("Instruction 3:");

List<int> input3 = new List<int>() { 6, -2, 5, 3 };
static List<int> orderByLooping(List<int> list)
{
    int intTemp = 0;
    /* SortedList<int, int> numberNames = new SortedList<int, int>(); */
    for (int i = 0; i < list.Count(); i++)
    {
        for (int j = 0; j < list.Count(); j++)
        {
            if (list[i] < list[j])
            {
                intTemp = list[i];
                list[i] = list[j];
                list[j] = intTemp;
            }
        }
    }
    return list;
}
if (input3.Count() <= 0)
{
    throw new Exception("The datatype of the inner list has to be integers");
}
List<int> orderedList = orderByLooping(input3);
Console.WriteLine(string.Join(", ", orderedList));
Console.WriteLine("The time complexity of this solution is On2 or O(n)2");
Console.WriteLine();
Console.WriteLine("-------------------");