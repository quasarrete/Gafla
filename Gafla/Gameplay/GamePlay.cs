using Gafla.Entities;
using Gafla.PlayerEntities;
using Gafla.TileEntities;
using System;
using System.Collections.Generic;

namespace Gafla.Gameplay
{
    public class GamePlay
    {
        public static int MAX_PLAYERS = 4;
        public IList<Player> GamePlayers { get; set; }

        public GamePlay()
        {
            GamePlayers = new List<Player>();
        }

        public void AddPlayer(string playerName)
        {
            if (GamePlayers.Count <= 4)
            {
                GamePlayers.Add(new Player
                {
                    Name = playerName,
                    PlayerHand = new List<Tile>()
                });
            }
        }
        public void CreateSet()
        {
            var player1 = new Player
            {
                Name = "Abdullah",
                PlayerHand = new List<Tile>()
            };
            var player2 = new Player
            {
                Name = "Hussain",
                PlayerHand = new List<Tile>()
            };
            var player3 = new Player
            {
                Name = "Tanjina",
                PlayerHand = new List<Tile>()
            };
            var player4 = new Player
            {
                Name = "Tanni",
                PlayerHand = new List<Tile>()
            };
            var playerList = new List<Player>();
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(player4);

            var set = new TileSet();
            set.ShuffleSet();

            for (int i = 0; i < 7; i++)
            {
                playerList[0].AddTile(set.Tiles.Pop());
                playerList[1].AddTile(set.Tiles.Pop());
                playerList[2].AddTile(set.Tiles.Pop());
                playerList[3].AddTile(set.Tiles.Pop());
            }

            foreach (var player in playerList)
            {
                Console.WriteLine(player.Name);
                foreach (var hand in player.PlayerHand)
                {
                    Console.WriteLine(hand.ToString());
                }
                player.TallyPoints();
                Console.WriteLine("Points: {0}", player.Points);
            }
        }
    }
}
