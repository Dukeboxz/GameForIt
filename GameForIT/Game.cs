using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForIT
{
    public class Game
    {
        private int id { get; set; }
        private string _name;
        private int _players;
        private string _description;
        private TimeSpan _timeToPlay;


        public Game(int anId, string theName, int numOfPlayers , string aDescription, TimeSpan timeForPlay)
        {
            this.id = anId;
            this._name = theName;
            this._players = numOfPlayers;
            this._description = aDescription;
            this._timeToPlay = timeForPlay; 
        }

        public Game GetGameById(int id)
        {
            return DataAccess.GetTheGame(id); 
        }

        public Game GetGameByName(string gameName)
        {
            return DataAccess.GetTheGame(gameName); 
        }

        public int getId()
        {
            return this.id;
        }

        
    }
}
