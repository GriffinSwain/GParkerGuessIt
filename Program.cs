//Griffin Parker
//October 19, 2022
//This program explains the guessing game, asks the user to choose a difficulty, and then leads them through their attempts to guess the correct number.

using System;
string test;
string loop;
string difficulty = "";
string min = "";
string max = "";
string border1 = "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
string border2 = "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-";
int guess;
int num = 0;
int correct = 1;
int attempt = 0;
int custom = 1;
int customLoop = 0;
int mini;
int maxi;
int repeat = 1;
int finish = 1;
bool numTest;
bool choice = false;
Console.Clear();
Random rndNum = new Random();

//for (int i = 0; i >= 10; i++)
//{
//Console.Clear();
Difficulty(border1, border2);
/* Thread.Sleep(200);
Console.Clear();
Difficulty(border2, border1);
Thread.Sleep(200); */

//}
while (repeat == 1){
while (!choice){
    Console.WriteLine("             Would you like to play on Easy, Medium, Hard, or Custom mode?");
difficulty = Console.ReadLine().ToLower();
if ((difficulty =="easy")|| (difficulty == "medium") || (difficulty == "hard") || (difficulty == "impossible")||(difficulty == "custom")){
    choice = true;
}else{
    Console.Clear();
    Console.WriteLine("Please choose from 'Easy', 'Medium', 'Hard', or 'Custom'!");
}
}
switch(difficulty){
case "easy":
    num = rndNum.Next(1, 11);
    break;
case "medium":
    num = rndNum.Next(1, 51);
    break;
case "hard":
    num = rndNum.Next(1, 101);
    break;
case "custom":
    while(custom == 1){
    if(customLoop != 1){
    Console.WriteLine("You will be choosing the minimum and maximum values that the random number can be.");
    Console.WriteLine("Please choose the minimum");
    min = Console.ReadLine();
    Console.WriteLine("Please choose the maximum");
    max = Console.ReadLine();
    }
    if ((numTest = Int32.TryParse(min, out mini)) && (numTest = Int32.TryParse(max, out maxi))){
    num = rndNum.Next(mini,maxi + 1);
    choice = true;
    custom++;
        }else{
            Console.WriteLine("Please select two valid numbers");
            Console.WriteLine();
        }
        }
    break;
case "impossible":
    num = rndNum.Next(0,1000000);
    break;
}
Console.Clear();
Console.WriteLine("Try to guess the randomly selected number!"); 

while(correct != 0){
test = Console.ReadLine();
if (numTest = Int32.TryParse(test, out guess)){

if (guess > num){
    Console.WriteLine($"Your guess of {guess} was greater than the correct number");
}
if (guess < num){
    Console.WriteLine($"Your guess of {guess} was lesser than the correct number");
}
attempt++;
if (guess == num){
correct--;
}
}else{
    Console.WriteLine("Please input a valid number");
}
}
Console.Clear();
Console.WriteLine("You guessed it! The correct number was " + num);
Console.WriteLine();
if (attempt > 1){
    Console.WriteLine($"It took you {attempt} guesses to get the correct number.");
}else{
    Console.WriteLine("You guessed the number correctly on your first try! You must be very intelligent.");
}
Console.WriteLine();

attempt = 0;
guess = 0;
correct = 1;
finish = 1;

while(finish == 1){
Console.WriteLine("To play again with the same difficulty, type 'again'. To choose a new difficulty, type 'change'. To stop the program, type 'end'");
loop = Console.ReadLine().ToLower();
switch (loop){
    case "again":
    customLoop = 1;
    custom = 1;
    Console.Clear();
    Console.WriteLine("Another number has been randomly selected!");
    finish++;
    break;
case "change":
    choice = false;
    custom = 1;
    customLoop = 0;
    finish++;
    break;
case "end":
    finish++;
    repeat++;
    break;
default:
    break;
}
}
}
static void Difficulty(string border, string border2)
{
Console.WriteLine("Welcome to the guessing game! A number will be randomly chosen for you, and you will have to guess it!");
Console.WriteLine($"{border}");
Console.WriteLine("|                  Easy mode will generate a number between 1 and 10                                |");
Console.WriteLine("|                Medium mode will generate a number between 1 and 50                                |");
Console.WriteLine("|                 Hard mode will generate a number between 1 and 100                                |");
Console.WriteLine("|    Custom mode will allow you to choose the minimum and maximum that the random number can be     |");
Console.WriteLine($"{border2}");

/* Console.SetCursorPosition(0, Console.CursorTop - 1);
Console.WriteLine($"{border}");
//Console.SetCursorPosition(0, Console.CursorTop + 1);
Console.SetCursorPosition(0, Console.CursorTop - 6);
Console.WriteLine($"{border2}");
//Console.SetCursorPosition(0, Console.CursorTop + 6); */
}
