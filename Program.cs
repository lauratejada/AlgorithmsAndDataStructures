/************ LAB 05 - Stacks, Queues *******************
* Using Stacks and Queues where appropriate, create a simple command line playlist app 
* that allows a user to add a song to a playlist. Provide commands to play the next song, 
* skip the upcoming song, or add a new song to the playlist. 
* Users should be able to rewind by one song many times to play a previous track.
* Example user experience:
* 
* Choose an option:
* 1. Add a song to your playlist
* 2. Play the next song in your playlist
* 3. Skip the next song
* 4. Rewind one song
* 5. Exit
* 
* > 1
*/
using System;
using System.IO;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

Console.WriteLine("Instructions 1");
Console.WriteLine();

Queue<string> playList = new Queue<string>();
// initializing queque with 3 songs
//playList.Enqueue("A Sky Full of Stars");
//playList.Enqueue("Hymn for the Weekend");
//playList.Enqueue("Viva la Vida");

Queue<string> tempPlayList = new Queue<string>();
Stack<string> tempStackPlayList = new Stack<string>(); // for rewind
string temp = ""; // temporal variable to save previous song
tempPlayList = playList; // copy values and work with tempPlayList
// function for 1. Add a song to your playlist
void addASong(string songName)
{
    if (playList.Count == 0)
    {
        temp = songName;
    }
    else
    {
        temp = tempStackPlayList.Peek();
    }

    playList.Enqueue(songName); // create a queque
    tempStackPlayList.Push(songName); // create a stack , for knowing next song
    tempPlayList = playList;

    // Console.Write($"length in playList {playList.Count}, "); ////////
    // Console.Write($"length in TEMPplayList {tempStackPlayList.Count}, "); /////

    Console.WriteLine();
    Console.WriteLine($"\"{songName}\" added to your playlist.");
    Console.WriteLine($"Next song \"{temp}\"");
}

// function for option 2
void playNextSong()
{
    if (playList.Count > 0)
    {
        if (tempPlayList.Count == 0)
        {
            tempPlayList = playList;
        }
        Console.WriteLine($"Now playing \"{tempPlayList.Dequeue()}\"");
        Console.WriteLine($"Next song \"{tempPlayList.Peek()}\"");
    }
    else
    {
        Console.WriteLine("The playList is empty and/or need to add more songs to perform this operation");
    }
}

// function for 3.Skip the next song
void skipNextSong()
{
    if (playList.Count > 2)
    {
        if (tempPlayList.Count == 0)
        {
            tempPlayList = playList;
        }
        Console.WriteLine($"Now Playing \"{tempPlayList.Dequeue()}\""); // song1
        tempPlayList.Dequeue();// song 2, skip thi song
        Console.WriteLine($"Next Song: \"{tempPlayList.Peek()}\""); // song 3
    }
    else
    {
        Console.WriteLine("The playList is empty and/or need to add more songs to perform this operation");
    }
}
// function for  4. Rewind one song
void rewindOneSong()
{
    if (playList.Count > 1)
    {
        if (tempPlayList.Count == 0)
        {
            tempPlayList = playList;
        }
        //tempPlayList.Reverse();
        tempStackPlayList.Clear();
        while (!(tempPlayList.Count == 0))
        { tempStackPlayList.Push(tempPlayList.Dequeue()); }

        Console.WriteLine($"Now Playing \"{tempStackPlayList.Pop()}\""); // song1
        Console.WriteLine($"Next Song: \"{tempStackPlayList.Peek()}\""); // song 3
    }
    else
    {
        Console.WriteLine("The playList is empty and/or need to add more songs to perform this operation");
    }
}

// Show the options
bool exit = false;
while (!exit)
{   // Showing the list of options and validating the selected option with switch
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
    Console.Write("Write the number of your option >  ");

    string choosedOption = Console.ReadLine();
    Console.WriteLine();
    switch (choosedOption)
    {
        case "1":
            {
                Console.WriteLine("1. Add a song");
                Console.Write("Enter Song Name: > ");
                string tempName = Console.ReadLine();
                addASong(tempName);
                Console.WriteLine();
                //Console.ReadLine();
                break;
            }
        case "2":
            {
                Console.WriteLine("2. Playing next song");
                playNextSong();
                Console.WriteLine();
                break;
            }
        case "3":
            {
                Console.WriteLine("3. Skip the next song");
                skipNextSong();
                Console.WriteLine();
                break;
            }
        case "4":
            {
                Console.WriteLine("4. Rewind one song");
                rewindOneSong();
                Console.WriteLine();
                break;
            }
        case "5":
            {
                Console.WriteLine("5. Exit");
                exit = true;
                break;
            }
        default:
            {
                Console.WriteLine("Type a valid integer (1, 2, 3, 4, 5) for your option");
                Console.WriteLine();
                break;
            }
    }

}