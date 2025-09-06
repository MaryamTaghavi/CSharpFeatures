Console.WriteLine("***** Fun with Object Cloning *****\n");
// Two references to same object!
Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
    public Point() { }
    // Override Object.ToString().
    public override string ToString() => $"X = {X}; Y = {Y}";
}