using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForIT
{
    public class Player
    {
        private int playerId; 
        private string _playerName;
       private  List<Game> gamesOwned;
        private  List<int> LookingToPlayGameIds; 

        public Player(int id, string name,  List<Game> gameOwned, List<int> lookToPlay)
        {
            this.playerId = id;
            this._playerName = name;
            this.gamesOwned = gameOwned;
            this.LookingToPlayGameIds = lookToPlay; 
        }

        public List<int> GetWantedToPlayer()
        {
            return this.LookingToPlayGameIds; 
        }

        public List<Game> GetGamesOwned()
        {
            return this.gamesOwned; 
        }
    }
}
