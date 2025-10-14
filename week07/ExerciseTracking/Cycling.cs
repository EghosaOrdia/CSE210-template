 public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
        _speed = speed;
        }

        public override double GetDistance()
        {
        return _speed * Minutes / 60.0;
        }

        public override double GetSpeed()
        {
        return _speed;
        }

        public override double GetPace()
        {
        double distance = GetDistance();
        return Minutes / distance;
        }
    }
