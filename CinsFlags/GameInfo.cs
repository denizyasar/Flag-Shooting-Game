using System.Net;

namespace CinsFlags
{
    //static class to keep info and use between forms and classes
    public static class GameInfo
    {
        public static string playerName { get; set; }

        public static Modes mode { get; set; }

        public static IPAddress serverIP { get; set; }

    }
}