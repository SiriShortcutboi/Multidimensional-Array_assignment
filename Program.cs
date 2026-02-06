//--------------------------------- Global Variables ---------------------------------------//
using System;

Random rand = new Random();
string[] Challenges = { "Empty", "Monster", "Puzzle", "Trap", "Exit" };
bool KeepPlaying = true;
int Row;
int Column;
int Location;
int[,] Dungeon = new int[5, 5]
{
    { 0, 1, 0, 2, 0 },
    { 3, 0, 0, 1, 0 },
    { 0, 0, 4, 0, 2 },
    { 1, 3, 0, 0, 0 },
    { 2, 0, 1, 3, 0 }
};

//----------------------------- Pseudocode Section ---------------------------------------//{
//explanation of how to start and build this out//
//rought out what you can and call it good, if 2 dimesnions in your array seems
// to work for your code thats great. otherwise go just 1 dimension
//not a key skill
//--- Make Choose start position--------------//

//------- After giving a starting position, loop a method every turn  ------------------//

//------- that moves the player around the array 0 thorugh 4 (thats 5 spaces------------------//

//------- if they try to exceed 5th spot "Must've hit a wall" and move diff direction-------------------//

//------- with different destinations registering a number to spawn monsters  ------------------//

//------- a room registered with 0 is an empty room, nice, next turn  ------------------//

//-------user tries to get to the 4 spot in the middle ------------------//

//}

//----------------------------- Main Code that runs ---------------------------------------//
ChooseStartPosition();

while (KeepPlaying)
{
    Move();
    // if you are at the exit stop playing
    // otherwise display the number location to the user
}

ThankYouForPlaying();


//-------------------------------------- Methods --------------------------------------------//
 //in effect, Mr Jensen said its not that deep
                    //even considered removing this assignment
                    //mentioned that my sick days may have moved
                    //some assignments to Feb 5th
                 
                    //remember to set run to solution folder/file,
                    //not the program.cs file
void ChooseStartPosition()
                   
					//comments from yesterday, seems pretty much done built
                    //comment this int and make another just like it
                    //dungeon should contain random row and random column
{                  //row first, column second
    Row = rand.Next(0, 5);
    Column = rand.Next(0, 5);
    Location = Dungeon[Row, Column];
    
    // Make sure we don't start at the exit (4)
    while (Location == 4)
    {
        Row = rand.Next(0, 5);
        Column = rand.Next(0, 5);
        Location = Dungeon[Row, Column];
    }
    
    Console.WriteLine("=== DUNGEON CRAWLER ===");
    Console.WriteLine($"You start at position ({Row}, {Column})");
    Console.WriteLine($"Challenge: {Challenges[Location]}");
    Console.WriteLine("Find the Exit to escape!");
    
    // Use Random to set a starting position within the grid that isn't the exit
}

void Move()
{
    // Ask user for a direction
    // if it is valid move to that place then return the new location
    // if not tell the user the move is invalid
    Console.WriteLine("\nPlease use the following buttons to move: W-Key UP, S-Key DOWN, A-key LEFT, D-key RIGHT");
    string direction = Console.ReadLine().ToLower();  // Convert to lowercase so W or w both work
    
    // Using string comparison (Approach 1) - simpler than ConsoleKey
    // Compare direction string to "w", "a", "s", "d"
    
    if (direction == "w")
    {
        //move up
        if (Row > 0)  // Check if not at top edge (row 0)
        {
            Row--;
            Location = Dungeon[Row, Column];
            Console.WriteLine($"You moved UP. Current challenge: {Challenges[Location]}");
        }
        else
        {
            Console.WriteLine("Must've hit a wall! Can't go up.");
        }
    }
    else if (direction == "a")
    {
        //move left
        if (Column > 0)  // Check if not at left edge (column 0)
        {
            Column--;
            Location = Dungeon[Row, Column];
            Console.WriteLine($"You moved LEFT. Current challenge: {Challenges[Location]}");
        }
        else
        {
            Console.WriteLine("Must've hit a wall! Can't go left.");
        }
    }
    else if (direction == "s")
    {
        //move down
        if (Row < 4)  // Check if not at bottom edge (row 4)
        {
            Row++;
            Location = Dungeon[Row, Column];
            Console.WriteLine($"You moved DOWN. Current challenge: {Challenges[Location]}");
        }
        else
        {
            Console.WriteLine("Must've hit a wall! Can't go down.");
        }
    }
    else if (direction == "d")
    {
        //move right
        if (Column < 4)  // Check if not at right edge (column 4)
        {
            Column++;
            Location = Dungeon[Row, Column];
            Console.WriteLine($"You moved RIGHT. Current challenge: {Challenges[Location]}");
        }
        else
        {
            Console.WriteLine("Must've hit a wall! Can't go right.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Please use W, A, S, or D.");
    }
    
    // Check if player reached the exit
    if (Location == 4)
    {
        KeepPlaying = false;
    }
        //write cute battle messages
    if (Location == 0){
        Console.WriteLine("The room is empty. Nice. A moment of rest before the next challenge.");
    }
    else if (Location == 1){
        Console.WriteLine("Blargh! A monster appears! Blood! Blood! Alright whats next?!");
    }
    else if (Location == 2){
        Console.WriteLine("Whats this a puzzle? It's paper. I think I saw something like \n " +
        "this on Instagram. Oh man this puzzlebook is full of slang words! this is so cash money!");
    }
    else if (Location == 3){
        Console.WriteLine("Oh no! A trap! You barely dodge it, and skin your knee and your pride. \n" +
        "Better be careful moving forward!");
    }
    else if (Location == 4){
        Console.WriteLine("You found the exit! You made it out of the cave! Thank you for playing!");
    
    }
}



void ThankYouForPlaying()
{
    Console.WriteLine("You made it out of the cave! Thank you for playing!");
    //Thank you for playing message
}