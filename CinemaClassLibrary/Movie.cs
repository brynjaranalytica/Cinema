using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int DurationMinutes { get; set; }
        public List<String> ActorsList { get; set; }
        public Movie(int id, String title, int duration, List<String> actors)
        {
            Id = id;
            Title = title;
            DurationMinutes = duration;
            ActorsList = actors;
        }
        public Movie(int id, String title, int duration): this(id, title, duration, new List<String>())
        {
    
        }
        
        public override String ToString()
        {
            String Actors = "";
            foreach (var actor in ActorsList)
            {
                Actors += actor + ", ";
            }
            return $"Movie title:{Title}, duration: {DurationMinutes} min.\nActors: {Actors.Substring(0,Actors.Length-2)}\n-------------------------\n";
        }
    }
}
