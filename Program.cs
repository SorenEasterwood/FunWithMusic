using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Country,
            Metal,
            Orchestral,
            Swing,
            Rap
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, int length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }

            public void setLength(int length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("What is the name of the album?");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("How long is it in minutes? (Use only a single digit)");
            int tempLength = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the genre?");
            Console.WriteLine("C - Country\nM - Metal\nO - Orchestral\nS - Swing\nR - Rap");
            Genre tempGenre = Genre.Country;
            char m = char.Parse(Console.ReadLine());
            switch (m)
            {
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'O':
                    tempGenre = Genre.Orchestral;
                    break;
                case 'S':
                    tempGenre = Genre.Swing;
                    break;
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
            }

            Music song = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music newSong = song;

            Console.WriteLine("What is another song on the Album?");
            newSong.setTitle(Console.ReadLine());

            Console.WriteLine("What is the length of this song in minutes?");
            newSong.setLength(int.Parse(Console.ReadLine()));

            Console.WriteLine($"{song.Display()}");
            Console.WriteLine();
            Console.WriteLine($"{newSong.Display()}");
        }
    }
}