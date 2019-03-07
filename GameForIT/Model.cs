using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForIT
{
    public class Model
    {

        public string RecomendGameToPlay()
        {
            List<Player> playersAttending = GetAttendingPlayers();
            
            List<KeyValuePair<int, int>> gamesMostWanted = GetMostWantedToPlay(playersAttending);

            for(int i = 0; i < gamesMostWanted.Count; i++)
            {
                if (AttendingPlayerHasGame(gamesMostWanted[i].Key, playersAttending))
                {
                    Game gameToPlay = DataAccess.GetTheGame(gamesMostWanted[i].Key); 
                }


            }

            return string.Empty; 
        }


        public List<Player> GetAttendingPlayers()
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player(1, "Stephen", GetPlayerGameList(1), new List<int> { 1, 2, 3 }));
            playerList.Add(new Player(2, "Dave", GetPlayerGameList(2), new List<int> { 1, 4 }));
            playerList.Add(new Player(3, "Nick", GetPlayerGameList(3), new List<int> { 5, 6 }));
            playerList.Add(new Player(4, "Dan", GetPlayerGameList(4), new List<int> { 3, 7 }));
            playerList.Add(new Player(5, "Alex", GetPlayerGameList(5), new List<int> { 1 })); 

            return playerList; 
            
        }

        public bool AttendingPlayerHasGame(int gameId, List<Player> playersAttending)
        {

            foreach(Player gamer in playersAttending)
            {
                List<Game> gamesInCollection = gamer.GetGamesOwned(); 
                foreach(Game aGame in gamesInCollection)
                {
                    if(aGame.getId() == gameId)
                    {
                        return true;
                    }
                }
            }


            return false; 
        }

        public List<Game> GetPlayerGameList(int playerId)
        {
            List<Game> gameList = new List<Game>(); 
            switch (playerId)
            {
                case 1:

                    Game zombicide = new Game(1, "Zombiecide", 7, "Zombies", new TimeSpan(2, 30, 0));
                    gameList.Add(zombicide); 
                    Game AOS = new Game(2, "Age Of Sigmar", 2, "AOS", new TimeSpan(3, 0, 0));
                    gameList.Add(AOS); 


                    break;
                case 2:
                    Game cardAHum = new Game(3, "Card Against Humanity", 5, "A card Game", new TimeSpan(0,30,0));
                    gameList.Add(cardAHum);
                    break;
                case 3:
                    Game killTeam = new Game(4, "Kill Team", 2, "40k", new TimeSpan(1, 0, 0));
                    gameList.Add(killTeam);
                    break;
                case 4:
                    Game x_wingV1 = new Game(5, "X-wing V1", 2, "xwing", new TimeSpan(1, 30, 0));
                    gameList.Add(x_wingV1);
                    break;

                case 5:
                    Game lobotomy = new Game(6, "lobotomy", 5, "Lobotomy", new TimeSpan(2, 45, 0));
                    gameList.Add(lobotomy); 
                    Game FormD = new Game(7, "Formula D", 7 ,"FormUlaD", new TimeSpan(0, 40, 20));
                    gameList.Add(FormD); 
                    break; 

                default:
                    gameList.Add(new Game(8, "Snakes & ladders", 2, "NO", new TimeSpan(0, 40, 0))); 
                    break; 
                    
            }

            return gameList; 
        }

        public List<KeyValuePair<int, int>> GetMostWantedToPlay(List<Player> playersAttending)
        {
            Dictionary<int, int> wantToPlayGames = new Dictionary<int, int>(); 
            
            foreach (Player player in playersAttending)
            {
                List<int> wantToPlay = player.GetWantedToPlayer();
                foreach (int gameId in wantToPlay)
                {
                    if (wantToPlayGames.ContainsKey(gameId)) 
                    {
                        wantToPlayGames[gameId] += 1;
                    }
                    else
                    {
                        wantToPlayGames.Add(gameId, 1); 
                    }
                }
            }

            List<KeyValuePair<int, int>> topMostWanted = wantToPlayGames.ToList();

            topMostWanted.Sort((x, y) => x.Key.CompareTo(y.Key));

            return topMostWanted; 



        }

    }
}
