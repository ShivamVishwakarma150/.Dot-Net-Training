using System;

namespace MusicAggregator_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter song 1 Detail:");
            String song1 = Console.ReadLine();
            String[] song1Data = song1.Split(',');
            String s1Name = song1Data[0];
            String s1Genre = song1Data[1];
            int s1DurationM = DateTime.Parse("01:" + song1Data[2]).Minute;
            int s1DurationS = DateTime.Parse("01:" + song1Data[2]).Second;
            String s1Duration = s1DurationM + ":" + s1DurationS;
            double s1Rating = Double.Parse(song1Data[3]);

            Song s1 = new Song(s1Name,s1Genre,s1Duration,s1Rating);


           

            Console.WriteLine("Enter song 2 Detail:");
            String song2 = Console.ReadLine();
            String[] song2Data = song2.Split(',');
            String s2Name = song2Data[0];
            String s2Genre = song2Data[1];
            int s2DurationM = DateTime.Parse("01:" + song2Data[2]).Minute;
            int s2DurationS = DateTime.Parse("01:" + song2Data[2]).Second;
            String s2Duration = s2DurationM + ":" + s2DurationS;
            double s2Rating = Double.Parse(song1Data[3]);
            Song s2 = new Song(s2Name, s2Genre, s2Duration, s2Rating);

            s1.showDetails();
            Console.WriteLine();
            s2.showDetails();

            if(Song.CompareSong(s1, s2) == true)
            {
                Console.WriteLine("Same song");
            }
            else
            {
                Console.WriteLine("Different Song");
            }
            
        }
    }
}
