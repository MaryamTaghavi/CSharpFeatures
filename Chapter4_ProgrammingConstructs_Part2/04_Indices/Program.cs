string[] gothicBands = { "Tones On Tail" , "Bauhaus" , "Sisters of Mercy"};

for (int i = 1; i <= gothicBands.Length; i++)
{
    Index inx = ^i;
    Console.WriteLine(gothicBands[inx] + ", ");
}