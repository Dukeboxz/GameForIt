using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForIT
{
    public static class DataAccess
    {

        public static Game GetTheGame(int id)
        {
            return new Game(id, "zombiecide", 7, "Zombies", new TimeSpan(2, 30, 0)); 
        }

        public static  Game GetTheGame(string nameOfGame)
        {
            return new Game(999, nameOfGame, 4, "Muchkin I think", new TimeSpan(0, 30, 0)); 
        }
    }
}
