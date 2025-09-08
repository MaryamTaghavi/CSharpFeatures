using LazyObjectInstantiation;

Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
// This caller does not care about getting all songs,
// but indirectly created 10,000 objects!
MediaPlayer myPlayer = new MediaPlayer();
myPlayer.Play();
Console.ReadLine();