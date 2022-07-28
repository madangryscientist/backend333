namespace backend333;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

public abstract class Person
{
    public string Name { get;  set; }
    public int Age { get; set; }
    public double Height { get; set; }

    public abstract string Greeting();
}

public interface INationality
{
    public string Nationality();
}
public interface IAmHuman
{
   
}
public class ZuluPerson : Person , INationality, IAmHuman
{
    public override string Greeting()
    {
        return "Sawubona";
    }

    public string Nationality()
    {
        return "RSA";
    }
}

public class XhosaPerson : Person , INationality
{
    public override string Greeting()
    {
        return "mholweni";
    }
    public string Nationality()
    {
        return "RSA";
    }
}

public class EnglishPerson : Person , INationality
{
    public override string Greeting()
    {
      return  "Hi";
    }
    public string Nationality()
    {
        return "UK";
    }
}