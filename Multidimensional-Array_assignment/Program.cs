//--------------------------------- Global Variables ---------------------------------------//
using System.Diagnostics.CodeAnalysis;

Random rand = new Random();
string[] Challenges = { "Empty", "Monster", "Puzzle", "Trap", "Exit" };
bool KeepPlaying = true;
int Row;
int Column;
int[,] Dungeon = new int[5, 5]
{
    { 0, 1, 0, 2, 0 },
    { 3, 0, 0, 1, 0 },
    { 0, 0, 4, 0, 2 },
    { 1, 3, 0, 0, 0 },
    { 2, 0, 1, 3, 0 }
};

//explanation of how to start and build this out//
//rought out what you can and call it good, if 2 dimesnions in your array seems
// to work for your code thats great. otherwise go just 1 dimension
//not a key skill
//----- Make Choose start position--------------//

//---------- After giving a starting position, loop a method every turn  ------------------//

//---------- that moves the player around the array 0 thorugh 4 (thats 5 spaces------------------//

//---------- if they try to exceed 5th spot "Must've hit a wall" and move diff direction-------------------//

//---------- with different destinations registering a number to spawn monsters  ------------------//

//---------- a room registered with 0 is an empty room, nice, next turn  ------------------//

//----------user tries to get to the 4 spot in the middle ------------------//



//------------------------------- Main Code that runs ---------------------------------------//
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
                   

                    //comment this int and make another just like it
                    //dungeon should contain random row and random column
{                  //row first, column second
    //int location = Dungeon[4, 2];
    int location = Dungeon[rand.Next(0, 5), rand.Next(0, 5)];
    if (location == 4)
    {
        location = Dungeon[rand.Next(0, 5), rand.Next(0, 5)];
    }
    Console.WriteLine(location);
    Console.WriteLine(Challenges[location]);



    // Use Random to set a starting position within the grid that isn't the exit
}

void Move()
{
    // Ask user for a direction
    // if it is valid move to that place then return the new location
    // if not tell the user the move is invalid
    Console.WriteLine("Please use the following buttons to move: W-Key UP, S-Key DOWN, A-key LEFT, D-key RIGHT");
    string direction = Console.ReadLine();
    if (direction != "W" && direction != "A" && direction != "S" && direction != "D")
    {
        Console.WriteLine("Invalid input, please use the following buttons to move: W-Key UP, S-Key DOWN, A-key LEFT, D-key RIGHT");
        direction = Console.ReadLine();
    }


}

void ThankYouForPlaying()
{
    //Thank you for playing message
}