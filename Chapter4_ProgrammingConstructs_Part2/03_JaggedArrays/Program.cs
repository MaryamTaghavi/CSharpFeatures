int[][] myJaggArray = new int[5][];

for (int i = 0; i < myJaggArray.Length; i++)
{
    myJaggArray[i] =new int[i+7];
}

for (int i = 0;i < 5;i++)
{
    for(int j = 0; j < myJaggArray[i].Length; j++)
    {
        Console.WriteLine(myJaggArray[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();