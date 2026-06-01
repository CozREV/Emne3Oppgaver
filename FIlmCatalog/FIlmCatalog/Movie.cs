using System;
using System.Collections.Generic;
using System.Text;

namespace FIlmCatalog
{
    internal class Movie : IComparable<Movie>
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Time { get; set; }
        public int Rating { get; set; }

        public int CompareTo(Movie other)
        {
            return other.Rating.CompareTo(this.Rating);
        }
    }
}
