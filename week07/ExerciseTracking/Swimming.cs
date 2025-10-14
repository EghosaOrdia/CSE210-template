  public class Swimming : Activity
  {
    private int _laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
        _laps = laps;
        }

        public override double GetDistance()
        {
        double meters = _laps * 50.0;
        double kilometers = meters / 1000.0;
        double miles = kilometers * 0.62;
        return miles;
        }

        public override double GetSpeed()
        {
        double distance = GetDistance();
        return (distance / Minutes) * 60.0;
        }

        public override double GetPace()
        {
        double distance = GetDistance();
        return Minutes / distance;
        }
    }
