using System.Collections.Generic;
using CCUBaseball.Models;
using MySql.Data.MySqlClient;

namespace CCUBaseball.Repository{
    public class StatsRepo : IStatsRepo{
        
        private readonly MySqlConnection _connection;
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

            List<Player> newList = new();

            while(results.Read()){
                Player p = new()
                {
                    Season = (int)results[1],
                    Number = (int)results[2],
                    Name =(string)results[3],
                    BattingAvg = (decimal)results[4],
                    OnBasePlusSlugging =(decimal)results[5],
                    GamesPlayed =(int)results[6],
                    GamesStarted =(int)results[7],
                    AtBats =(int)results[8],
                    Runs =(int)results[9], 
                    Hits =(int)results[10],
                    Doubles =(int)results[11],
                    Triples =(int)results[12],
                    Homeruns =(int)results[13], 
                    RunsBattedIn =(int)results[14], 
                    TotalBases =(int)results[15],
                    SluggingPercentage =(decimal)results[16],
                    BaseOnBalls =(int)results[17],
                    HitByPitch =(int)results[18],
                    Strikeout =(int)results[19],
                    GroundIntoDoublePlay =(int)results[20],
                    OnBasePercentage =(decimal)results[21],
                    SacrificeFly =(int)results[22],
                    SacrificeBunt =(int)results[23],
                    StolenBases =(int)results[24],
                    StolenBaseAttempts =(int)results[25]
                };
                newList.Add(p);
            }

            results.Close();
            return newList;
            //return players and stats for all seasons;
        }

        public IEnumerable<Player> GetPlayerByName(string name){
            var statement = "select * from CCUBaseball where name = @newName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", name);

            var results = command.ExecuteReader();

            List<Player> playerCareerStats = new();

            while(results.Read()){
                Player p = new(){
                    Season = (int)results[1],
                    Number = (int)results[2],
                    Name =(string)results[3],
                    BattingAvg = (decimal)results[4],
                    OnBasePlusSlugging =(decimal)results[5],
                    GamesPlayed =(int)results[6],
                    GamesStarted =(int)results[7],
                    AtBats =(int)results[8],
                    Runs =(int)results[9], 
                    Hits =(int)results[10],
                    Doubles =(int)results[11],
                    Triples =(int)results[12],
                    Homeruns =(int)results[13], 
                    RunsBattedIn =(int)results[14], 
                    TotalBases =(int)results[15],
                    SluggingPercentage =(decimal)results[16],
                    BaseOnBalls =(int)results[17],
                    HitByPitch =(int)results[18],
                    Strikeout =(int)results[19],
                    GroundIntoDoublePlay =(int)results[20],
                    OnBasePercentage =(decimal)results[21],
                    SacrificeFly =(int)results[22],
                    SacrificeBunt =(int)results[23],
                    StolenBases =(int)results[24],
                    StolenBaseAttempts =(int)results[25]
                };
                playerCareerStats.Add(p);
            }

            results.Close();
            return playerCareerStats;
        }

    //     public void InsertMovie(Movie m){
    //         var statement = "insert into Movies (Name, Year, Genre) Values(@n, @y, @g)";
    //         var command = new MySqlCommand(statement,_connection);
    //         command.Parameters.AddWithValue("@n", m.Name);
    //         command.Parameters.AddWithValue("@y", m.Year);
    //         command.Parameters.AddWithValue("@g", m.Genre);

    //         int result = command.ExecuteNonQuery();
    //         Console.WriteLine(result);
    //     }

    //     public void UpdateMovie(string name, Movie movieIn){
    //         var statement = "update Movies set Name=@newName, Year=@newYear, Genre=@newGenre where Name=@updateName";
    //         var command = new MySqlCommand(statement, _connection);
    //         command.Parameters.AddWithValue("@newName", movieIn.Name);
    //         command.Parameters.AddWithValue("@newYear", movieIn.Year);
    //         command.Parameters.AddWithValue("@newGenre", movieIn.Genre);
    //         command.Parameters.AddWithValue("@updateName", name);

    //         int result = command.ExecuteNonQuery();
    //     }

    //     public void DeleteMovie(string name){
    //        var statement = "delete from Movies where Name = @n";
    //        var command = new MySqlCommand(statement, _connection);
    //        command.Parameters.AddWithValue("@n", name);

    //        int result = command.ExecuteNonQuery();
    //     }


    // }
    }
}