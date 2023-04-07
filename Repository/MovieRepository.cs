using System.Collections.Generic;
using MovieApi.Models;
using MySql.Data.MySqlClient;

namespace MovieApi.Repository{
    public class MovieRepository : IMovieRepository{
        private static readonly List<Movie> movies = new List<Movie>(10)
        {
            new Movie {Name="Citizen Kane", Genre="Drama", Year= 1942},
            new Movie {Name="The Wizard of Oz", Genre="Fantasy", Year= 1939},
            new Movie {Name="The Godfather", Genre="Crime", Year= 1972}

        };
        private MySqlConnection _connection;
        public MovieRepository(){
            string connectionString="server=localhost;userid=csci330user;password=csci330pass;database=entertainment";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        
        ~MovieRepository(){
            _connection.Close();
        }

        public IEnumerable<Movie> GetAll(){
            var statement = "select * from Movies";
            var command = new MySqlCommand(statement,_connection);
            var results = command.ExecuteReader();

            List<Movie> newList = new List<Movie>(20);

            while(results.Read()){
                Movie m = new Movie{
                    Name = (string)results[1],
                    Genre = (string)results[3],
                    Year = (int)results[2]
                };
                newList.Add(m);
            }


            return newList;
            //return movies;
        }

        public Movie GetMovieByName(string name){
            foreach(Movie m in movies){
                if(m.Name.Equals(name))
                    return m;
            }
            return null;
        }

        public void InsertMovie(Movie m){
            movies.Add(m);
        }

        public void UpdateMovie(string name, Movie movieIn){
            foreach(Movie m in movies){
                if(m.Name.Equals(name)){
                    m.Name=movieIn.Name;
                    m.Genre=movieIn.Genre;
                    m.Year=movieIn.Year;
                }
            };
        }

        public void DeleteMovie(string name){
           foreach(Movie m in movies){
                if(m.Name.Equals(name)){
                    movies.Remove(m);
                    return;
                }
            }
        }
    }
}