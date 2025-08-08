int[,] myMatrix;

myMatrix = new int[3, 4];

for(int i = 0; i <3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        myMatrix[i, j] = i * j;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(myMatrix[i, j] + "\t");
    }

    Console.WriteLine();
}

Console.WriteLine();
