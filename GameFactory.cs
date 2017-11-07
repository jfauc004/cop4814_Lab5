using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Game2
{
   public class GameFactory
    {
        public List<Game> GameList = new List<Game>();


        public void CreateGameList()
        {


            Game G = new Game("Hornets", 50, "Bulldogs", 75);
            GameList.Add(G);
            G = new Game("Panthers", 45, "Stingrays", 75);
            GameList.Add(G);
            G = new Game("Sharks", 66, "Dolphins", 85);
            GameList.Add(G);
            G = new Game("Giants", 14, "Steelers", 6);
            GameList.Add(G);
            G = new Game("Knights", 36, "Vikings", 42);
            GameList.Add(G);
            G = new Game("Bucs", 7, "Rams", 17);
            GameList.Add(G);
        }
        public string FilePath = @"..\..\games.xml";

        public bool SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer serial = new XmlSerializer(GameList.GetType());
            serial.Serialize(sw, GameList);
            sw.Close();
            return true;

        }
    }
}
