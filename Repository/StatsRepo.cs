using System.Collections.Generic;
using CCUBaseball.Models;
using MySql.Data.MySqlClient;

namespace CCUBaseball.Repository{
    public class StatsRepo : IStatsRepo{
        // private static readonly List<Movie> movies = new List<Movie>(10)
        // {
        //     new Movie {Name="Citizen Kane", Genre="Drama", Year= 1942},
        //     new Movie {Name="The Wizard of Oz", Genre="Fantasy", Year= 1939},
        //     new Movie {Name="The Godfather", Genre="Crime", Year= 1972}

        // };
        private MySqlConnection _connection;
        public StatsRepo(){
            string connectionString="server=localhost;userid=csci330user;password=csci330pass;database=ccuStats";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        
        ~StatsRepo(){
            _connection.Close();
        }

        public IEnumerable<Player> GetAll(){
            var statement = "SELECT * FROM CCUBaseball";
            var command = new MySqlCommand(statement,_connection);
            var results = command.ExecuteReader();

            List<Player> newList = new List<Player>();

            while(results.Read()){
                Player p = new Player{
                    season = (int)results[1],
                    number = (int)results[2],
                    name =(string)results[3],
                    battingAvg = (decimal)results[4],
                    onBasePlusSlugging =(decimal)results[5],
                    gamesPlayed =(int)results[6],
                    gamesStarted =(int)results[7],
                    atBats =(int)results[8],
                    runs =(int)results[9], 
                    hits =(int)results[10],
                    doubles =(int)results[11],
                    triples =(int)results[12],
                    homeruns =(int)results[13], 
                    runsBattedIn =(int)results[14], 
                    totalBases =(int)results[],
                    sluggingPercentage =(decimal)results[15],
                    baseOnBalls =(int)results[16],
                    hitByPitch =(int)results[17],
                    strikeout =(int)results[18],
                    groundIntoDoublePlay =(int)results[19],
                    onBasePercentage =(decimal)results[20],
                    sacrificeFly =(int)results[21],
                    sacrificeBunt =(int)results[22],
                    stolenBases =(int)results[23],
                    stolenBaseAttempts =(int)results[24],
                };
                newList.Add(p);
            }

            results.Close();
            return newList;
            //return players and stats for all seasons;
        }

        public Movie GetMovieByName(string name){
            var statement = "select * from Movies where Name = @newName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", name);

            var results = command.ExecuteReader();
            Movie m = null;
            if(results.Read()){
                m = new Movie{
                    Name = (string)results[1],
                    Genre = (string)results[3],
                    Year = (int)results[2]
                };
            }

            results.Close();
            return m;
        }

        public void InsertMovie(Movie m){
            var statement = "insert into Movies (Name, Year, Genre) Values(@n, @y, @g)";
            var command = new MySqlCommand(statement,_connection);
            command.Parameters.AddWithValue("@n", m.Name);
            command.Parameters.AddWithValue("@y", m.Year);
            command.Parameters.AddWithValue("@g", m.Genre);

            int result = command.ExecuteNonQuery();
            Console.WriteLine(result);
        }

        public void UpdateMovie(string name, Movie movieIn){
            var statement = "update Movies set Name=@newName, Year=@newYear, Genre=@newGenre where Name=@updateName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", movieIn.Name);
            command.Parameters.AddWithValue("@newYear", movieIn.Year);
            command.Parameters.AddWithValue("@newGenre", movieIn.Genre);
            command.Parameters.AddWithValue("@updateName", name);

            int result = command.ExecuteNonQuery();
        }

        public void DeleteMovie(string name){
           var statement = "delete from Movies where Name = @n";
           var command = new MySqlCommand(statement, _connection);
           command.Parameters.AddWithValue("@n", name);

           int result = command.ExecuteNonQuery();
        }


    }
}