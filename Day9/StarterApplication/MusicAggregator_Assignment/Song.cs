using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAggregator_Assignment
{
    internal class Song
    {
        private String _title;
        private String _genre;
        private String _duration;
        private double _rating;

        public Song(string title, string genre, string duration, double rating)
        {
            _title = title;
            _genre = genre;
            _duration = duration;
            _rating = rating;
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public String Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public String Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public double Rating
        {
            get { return _rating; }
           set{_rating = value;}
        }

        public void showDetails()
        {
            Console.WriteLine("Title: "+this.Title);
            Console.WriteLine("Genre: "+this.Genre);
            Console.WriteLine("Duration: "+this.Duration);
            Console.WriteLine("Rating: "+this.Rating);

        }
        public static bool CompareSong(Song s1, Song s2)
        {

            if(s1.Title==s2.Title && s1.Genre==s2.Genre && s1.Duration==s2.Duration && s1.Rating==s2.Rating)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
