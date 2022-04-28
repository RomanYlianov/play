using System;

namespace play
{
    public class Player
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Schore { get; set; }

        public int BestTime { get; set; }

        public Player()
        {

        }
        public Player(string name)
        {
            this.Name = name;
            this.Schore = 0;
            this.BestTime = 0;
        }
        public Player(int id, String name, int schore, int bestTime)
        {
            Id = id;
            Name = name;
            Schore = schore;
            BestTime = bestTime;
        }

        public Player(string name, int schore, int time) : this(name)
        {
            Schore = schore;
            this.BestTime = time;
        }
    }
}
