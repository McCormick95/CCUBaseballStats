
using CCUBaseball.Models;

namespace CCUBaseball.Repository{
    public interface IStatsRepo{
        public IEnumerable<Player> GetAll();

        public IEnumerable<Player> GetPlayerByName(string name);


    }
}