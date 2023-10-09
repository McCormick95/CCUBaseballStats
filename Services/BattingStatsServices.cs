using System.Collections.Generic;
using System.Collections;
using CCUBaseball.Models;
using CCUBaseball.Repository;
using System.ComponentModel;
using Org.BouncyCastle.Asn1.Misc;

namespace CCUBaseball.Services{
    public class BattingStatsServices : IBattingStats
    {
        private IStatsRepo _repo;

        public BattingStatsServices(IStatsRepo repo){
            _repo = repo;
        }
        public IEnumerable<Player> GetAll()
        {
            IEnumerable<Player> playerList =  _repo.GetAll();
            return playerList;
        }

        public IEnumerable<Player> GetPlayerByName(string name)
        {
            IEnumerable<Player> playerList =  _repo.GetPlayerByName(name);
            return playerList;
        }

        public IEnumerable<Player> GetPlayersBySeason(int s)
        {
            List<Player> playersBySeason = new();
            IEnumerable<Player> playerList =  _repo.GetAll();
            foreach(Player p in playerList){
                if(p.Season==s){
                    playersBySeason.Add(p);
                }
            }
            return playersBySeason;
        }

        public List<string> AvgTeamBattingAvgBySeason(int season){

            /*
              IEnumerable<Player> playerList= _repo.GetAll();
              List<string> seasonList = new();
              int firstYear = playerList[0].season
              seasonList.Add(playerList[0].season)
              foreach(player p in playerList){
                foreach(string S in seasonList){
                    if(p.season != S){
                        seasonList.Add(p.season)
                    }
                }
              }

              List<string> teamBattingAverages = new();
              foreach(string s in seasonList){
                int playerCount=0;
                int teamAvg = 0;
                foreach(player p in playerList){
                    if(p.Season == S){
                        teamAvg += p.battingAvg
                    }
                    playerCount++;
                }
                teamAvg=/playerCount
                teamBattingAverages.Add("The "+ s + " team had an average team batting average of: " + teamAverage;)
              }
            
            */
            
            List<string> teamBattingAverages = new();
            decimal teamAverage = 0;
            int playerCount = 0;
            IEnumerable<Player> playerList =  _repo.GetAll();
            foreach(Player p in playerList){
                if(p.Season == season){
                   teamAverage += p.BattingAvg;  
                }
                playerCount++;
            }
            teamAverage /= playerCount;
            string returnString = "The "+ season + " team had an average team batting average of: " + teamAverage;
            return null;
        }

        public IEnumerable<Player> GetPlayerByNumber(int num){
            List<Player> playersByNumber = new();
            IEnumerable<Player> playerList =  _repo.GetAll();
            foreach(Player p in playerList){
                if(p.Number == num){
                    playersByNumber.Add(p);
                }
            }  
            return playersByNumber; 
        }

        public List<string> PercentageOfGamesStarted(){
            decimal tempPercentage;
            string str;
            List<string> playerByPercentage = new();
            IEnumerable<Player> playerList = _repo.GetAll();
            foreach(Player p in playerList){
                tempPercentage = p.GamesStarted/p.GamesPlayed;
                str = p.Name + " started " + tempPercentage + " of the games they played in for the " + p.Season + " season.";
                //String Output= "Jon Doe: .123 for the 20XX season."
                playerByPercentage.Add(str);
            }
            return playerByPercentage;
        }


        // public IEnumerable<Player> AtBatsVsBattingAvg(){
        //     return null;
        // }

        // public IEnumerable<string> BattingAvgTrendByPlayerName(string name){
        //     List<string> player=new();
        //     List<Player> tempList=new();
        //     IEnumerable<Player> playerList = _repo.GetAll();
        //     foreach(Player p in playerList){
        //         if(p.Name == name){
        //             tempList.Add(p);
        //         }
        //     }
        //     return null;
        // }

    }
}