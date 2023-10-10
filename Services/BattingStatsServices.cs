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

        public List<string> AvgTeamBattingAvgBySeason(){
            IEnumerable<Player> playerList= _repo.GetAll();
            List<int> seasonList = new();

            foreach(Player p in playerList){
                if(!seasonList.Contains(p.Season)){
                    seasonList.Add(p.Season);
                }
            }
            List<string> teamBattingAverages = new();
            foreach(int s in seasonList){
                int playerCount=0;
                decimal teamAvg = 0;
                foreach(Player p in playerList){
                    if(p.Season == s){
                        teamAvg += p.BattingAvg;
                        playerCount++;
                    }
                }
                if(playerCount != 0){
                    teamAvg /= playerCount;
                }

                teamBattingAverages.Add("The "+ s + " team had an average team batting average of: " + teamAvg.ToString("0.000"));
            }
            return teamBattingAverages;
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
                tempPercentage = 100 * decimal.Divide(p.GamesStarted , p.GamesPlayed);
                str = p.Name + " started " + tempPercentage.ToString("##0.#") + "% of games of the " + p.Season + " season.";
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