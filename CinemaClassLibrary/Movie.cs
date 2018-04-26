using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    class Movie
    {
        public String Title { get; set; }
        public int DurationMinutes { get; set; }
        public List<String> ActorsList { get; set; }
        public Movie(String title, int duration, List<String> actors)
        {
            Title = title;
            DurationMinutes = duration;
            ActorsList = actors;
        }
    }
}
