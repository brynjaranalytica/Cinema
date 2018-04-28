using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CinemaClassLibrary;

namespace CinemaWebApplication
{
    public class DBconnector
    {
        private String Server = "127.0.0.1";
        private String Port = "5432";
        private String User = "postgres";
        private String Password = "Postgres";
        private String Database = "cinema";

        static void Main(String[] args)
        {
            DBconnector dbConnector = new DBconnector();
            Stack<Movie> movies = dbConnector.GetMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
            Console.ReadKey();
        }

        public Stack<Movie> GetMovies()
        {
            string connstring = $"Server={Server};Port={Port};User Id={User};Password={Password};Database={Database};";
            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    Stack<Movie> movieStack = new Stack<Movie>();
                    conn.Open();

                    string sql = "select movie.id, movie.title, movie.duration_minutes from movie;";
                    string sql2 = "";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Prepare();
                    NpgsqlDataReader moviesData = cmd.ExecuteReader();
                    //first: reading the movies data and building sql batch query for getting actors for each movie
                    while (moviesData.Read())
                    {
                        movieStack.Push(new Movie((int)moviesData[0], (String)moviesData[1], (int)moviesData[2]));
                        sql2 = $"select actor.name from actor where actor.id in (select actor from movie_actors where movie_actors.movie = {(int)moviesData[0]});"+sql2;
                    }
                    conn.Close();
                    //then: reading the actors data for each movie
                    conn.Open();
                    cmd.CommandText = sql2;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    NpgsqlDataReader actorsData = cmd.ExecuteReader();
                    foreach (var movie in movieStack)
                    {
                        while (actorsData.Read())
                        {
                            movie.ActorsList.Add((String)actorsData[0]);
                        }
                        actorsData.NextResult();
                    }
                   
                    conn.Close();
                    return movieStack;
                
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong: \n" + e.Message);
                    throw;
                }

            }
        
        }
    }
}