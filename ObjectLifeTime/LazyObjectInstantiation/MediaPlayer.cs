namespace LazyObjectInstantiation;

public class MediaPlayer
{
    public void Play() { /* Play a song */ }
    public void Pause() { /* Pause the song */ }
    public void Stop() { /* Stop playback */ }
    private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();
    public AllTracks GetAllTracks()
    {
        // Return all of the songs.
        return _allSongs.Value ;
    }
}
