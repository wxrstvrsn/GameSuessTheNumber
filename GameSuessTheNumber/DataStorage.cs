using System.Xml.Serialization;

namespace GuessNumberGame
{
    public static class DataStorage
    {
        private static string DataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "players.xml");
        public static List<Player> LoadPlayers()
        {
            if (!File.Exists(DataFile)) return new List<Player>();
            XmlSerializer ser = new XmlSerializer(typeof(List<Player>));
            using (var fs = new FileStream(DataFile, FileMode.Open))
                return (List<Player>)ser.Deserialize(fs);
        }
        public static void SavePlayers(List<Player> players)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Player>));
            using (var fs = new FileStream(DataFile, FileMode.Create))
                ser.Serialize(fs, players);
        }
    }
}