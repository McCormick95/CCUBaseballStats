
using CCUBaseball.Models;

namespace CCUBaseball.Repository{
    public interface IStatsRepo{
        public IEnumerable<Player> GetAll();

        public IEnumerable<Player> GetPlayerByName(string name);

        


        //public void InsertMovie(Player p);
        //public void UpdateMovie(string name, Player m);
        //public void DeleteMovie(string name);
    }
}