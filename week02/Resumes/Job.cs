public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobDetails()
    {
          Console.WriteLine($"I worked at {_jobTitle} as {_company} from {_startYear}-{_endYear}");
    }
}