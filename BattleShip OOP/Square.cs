namespace BattleShip_OOP
{
    public class Square
    {
        public SquereType SquereType { get { return type; } set { type = value; } }
        public bool IsHit { get { return SquereType == SquereType.Hit; } }
        public bool IsMiss { get { return SquereType == SquereType.Missed; } }
        public bool IsShip { get { return SquereType == SquereType.Ship; } }
        public bool IsEmpty { get { return SquereType == SquereType.Empty; } }

        private Tuple<int, int> position;
        //private string mark;
        private SquereType type;

        public Square(int x, int y)
        {
            position = new Tuple<int, int>(x, y);
            type = SquereType.Empty;
        }

        public char Symbol
        {
            get
            {
                // można uprościć instrukcją switch
                if (type == SquereType.Ship)
                {
                    return 'S';
                }

                else if (type == SquereType.Missed)
                {
                    return 'M';
                }

                else if (type == SquereType.Hit)
                {
                    return 'X';
                }
                else
                {
                    return ' ';
                }
                

            }
        }

        public override string ToString()
        {
            return $"{ Symbol } ({ position })";
        }




    }
}
