namespace Tournament
{
    public class Game
    {
        private int roundAmount;

        public Game(int k)
        {
            roundAmount = k;
        }

        public int getMeetingRound(int x, int y)
        {
            int round = 0;

            while(x != y)
            {
                x = x / 2;
                y = y / 2;
                round++;
            }

            return round;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            int x = 16;
            int y = 30;


            Game game = new Game(k);
            int meetingRound = game.getMeetingRound(x, y);
            Console.WriteLine("teams {0} and {1} will meet on round {2}", x, y, meetingRound);
        }
    }

}