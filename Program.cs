// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

//Given this declaration, write code that will find and display the largest element of 'numbers'

    int[] numbers = new int[20]{2904, 4451, 1484, 2791, 3975, 2576, 2444, 448, 749, 4245, 4753, 3483, 2088, 3987, 3127, 1346, 3615, 1758, 1374, 3960};
    int greatest =0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > greatest)
            greatest = numbers[i];
    }
    Console.WriteLine($"The greatest number in the list 'numbers' is {greatest}\n");

//Write a program that takes a list of strings an prints them, one per line, in a rectangular frame. 
    //string? input = Console.ReadLine();
    string input = "The quick brown fox jumps over the lazy dog.";
    string[] words = input.Split(' ');
    greatest = 0; 

    // find longest word
    for (int i = 0; i < words.Length; i ++)
    {
        if(words[i].Length > greatest)
            greatest = words[i].Length;
    }
    // print the top line of the box
    Console.Write("/");
    for (int i=0; i< greatest+1; i++)
        Console.Write("*");
    Console.WriteLine("\\");
    // print the words
    for (int i=0; i < words.Length; i++)
    {
        Console.Write($"*{words[i]}");
        for (int j = 0; j < (greatest-words[i].Length+1);j++)
            Console.Write(" ");
        Console.Write("*\n");
    }
    // print the bottom line of the box
    Console.Write("\\");
    for (int i=0; i< greatest+1; i++)
        Console.Write("*");
    Console.Write("/\n\n");


// Given lists A and B that are already sorted, create a list C that combines the two lists and keeps them sorted
    int[] A = new int[4] {1,3,9,12};
    int[] B = new int[4] {2,4,11,15};
    int[] C = new int[8];
    // Option one combine the lists and sort the list
    for (int i = 0; i< A.Length; i++)
        C[i] = A[i];
    for (int i = B.Length; i < 2*B.Length; i ++)
        C[i] = B[i-B.Length];
    Array.Sort(C);
    foreach(int i in C)
        Console.Write(i + " ");
    Console.WriteLine("");
    // empty it for the next solution
    Array.Clear(C);
    // Option two adds the elements one at a time in the right order.
    int a = 0;
    int b = 0;
    
    for (int i = 0; i< A.Length + B.Length; i++)
    {
        if(a >= A.Length)
        {
            C[i] = B[b];
            b ++;
        }
        else if (b >=B.Length)
        {
            C[i] = A[a];
            a ++;
        }
        else if (A[a] > B[b])
        {
            C[i] = B[b];
            b++;
        }
        else
        {
            C[i] = A[a];
            a++;
        }
    }
     foreach(int i in C)
        Console.Write(i + " ");
    Console.WriteLine("\n");

// Given the array 'numbers', write code that will find the sum of all the elements using a 'for' loop and then find the sum using a 'while' loop

int[] numbers2 = new int[20]{2904, 4451, 1484, 2791, 3975, 2576, 2444, 448, 749, 4245, 4753, 3483, 2088, 3987, 3127, 1346, 3615, 1758, 1374, 3960};
int sumFor = 0;
int sumWhile = 0;
for (int i =0; i< numbers2.Length; i++)
{
    sumFor+=numbers2[i];
}
int count = 0;
while(count < numbers2.Length)
{
    sumWhile +=numbers2[count];
    count ++;
}

Console.WriteLine($"Sum from for = {sumFor}, Sum from while = {sumWhile}\n");

// Write a program that will print the numbers between 1 and 1000 that are divisible by both 3 and 7

for (int i = 1; i< 1001; i++)
{
    if(i%3 == 0 || i%7 == 0)
        Console.Write($"{i} ");
}
Console.WriteLine("\n");

// EXTRA CREDIT: (20 pts). Write a program that will generate a random number between 1 and 1000000 and print the individual digits of the number on a separate line WITHOUT converting it into a string.  For example:

Random rand = new Random();
int number = rand.Next(1,10000000);
Console.WriteLine($"The starting number is {number}");
// Log10 of a number will determine how many digits it has. Ceilinlg rounds it up
int length = (int)Math.Floor(Math.Log10(number));
int divisor = 0;
for (int i = length; i >= 0; i --)
{
    divisor = (int)Math.Pow(10,i);
    Console.WriteLine($"{(number/divisor)}");
    number %= divisor;
}