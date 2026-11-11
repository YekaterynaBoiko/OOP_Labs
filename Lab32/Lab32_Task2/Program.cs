using Lab32_Task2;

Playlist playlist = new Playlist();
Song song = new Song
playlist.AddSong("Believer", 204);
playlist.AddSong("Hung up", 338);
playlist.AddSong("M80", 212);

Console.WriteLine($"\nКількість пісень: {playlist.SongCount}");
Console.WriteLine($"\nЗагальна тривалість: {playlist.GetTotalDurationSong()} секунд");