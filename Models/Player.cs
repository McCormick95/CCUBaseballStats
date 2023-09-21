
namespace CCUBaseball.Models{
    public class Player{
        public int season{get; set;}
        public int number{get; set;}
        public string name{get; set;}
        public decimal battingAvg{get; set;}
        public decimal onBasePlusSlugging{get; set;}
        public int gamesPlayed {get; set;}
        public int gamesStarted {get; set;}
        public int atBats {get; set;}
        public int runs {get; set;}
        public int hits {get; set;}
        public int doubles {get; set;}
        public int triples {get; set;}
        public int homeruns {get; set;}
        public int runsBattedIn {get; set;}
        public int totalBases {get; set;}
        public decimal sluggingPercentage {get; set;}
        public int baseOnBalls {get; set;}
        public int hitByPitch {get; set;}
        public int strikeout {get; set;}
        public int groundIntoDoublePlay {get; set;}
        public decimal onBasePercentage {get; set;}
        public int sacrificeFly {get; set;}
        public int sacrificeBunt {get; set;}
        public int stolenBases {get; set;}
        public int stolenBaseAttempts {get; set;}
        public override string ToString(){
            return $"{Season}, {Number}, {Name}, {battingAvg}, {onBasePlusSlugging}, {gamesPlayed}, {gamesStarted}, {atBats}, {runs}, {hits}, {doubles}, {triples}, {homeruns}, {runsBattedIn}, {totalBases}, {sluggingPercentage}, {baseOnBalls}, {hitByPitch}, {strikeout}, {groundIntoDoublePlay},{onBasePercentage}, {sacrificeFly}, {sacrificeBunt}, {stolenBases}, {stolenBaseAttempts}";
        }
    }

}