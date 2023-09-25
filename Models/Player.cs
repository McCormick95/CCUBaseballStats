
namespace CCUBaseball.Models{
    public class Player{
        public int Season{get; set;}
        public int Number{get; set;}
        public string? Name {get; set;}
        public decimal BattingAvg{get; set;}
        public decimal OnBasePlusSlugging{get; set;}
        public int GamesPlayed {get; set;}
        public int GamesStarted {get; set;}
        public int AtBats {get; set;}
        public int Runs {get; set;}
        public int Hits {get; set;}
        public int Doubles {get; set;}
        public int Triples {get; set;}
        public int Homeruns {get; set;}
        public int RunsBattedIn {get; set;}
        public int TotalBases {get; set;}
        public decimal SluggingPercentage {get; set;}
        public int BaseOnBalls {get; set;}
        public int HitByPitch {get; set;}
        public int Strikeout {get; set;}
        public int GroundIntoDoublePlay {get; set;}
        public decimal OnBasePercentage {get; set;}
        public int SacrificeFly {get; set;}
        public int SacrificeBunt {get; set;}
        public int StolenBases {get; set;}
        public int StolenBaseAttempts {get; set;}
        public override string ToString(){
            return $"{Season}, {Number}, {Name}, {BattingAvg}, {OnBasePlusSlugging}, {GamesPlayed}, {GamesStarted}, {AtBats}, {Runs}, {Hits}, {Doubles}, {Triples}, {Homeruns}, {RunsBattedIn}, {TotalBases}, {SluggingPercentage}, {BaseOnBalls}, {HitByPitch}, {Strikeout}, {GroundIntoDoublePlay},{OnBasePercentage}, {SacrificeFly}, {SacrificeBunt}, {StolenBases}, {StolenBaseAttempts}";
        }
    }

}