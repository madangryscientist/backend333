using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly int[] Interger = new int[]
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9
    };

    private static readonly bool[] Boolean = new bool[]
    {
        true, false
    };

    private static readonly double[] Doubles = new double[]
    {
        1.7, 2.8, 3.4, 4.7
    };

    private static readonly Person[] PersonList = new Person[]
    {
      new Person()
      {
          Name = "Erin", 
          Age = 21,
          Height = 2.5
      }, 
      new Person()
      {
          Name = "Corrine",
          Age = 25,
          Height = 2.8
      },
      new Person(){
      Name = "Jacobus",
      Age = 36,
      Height = 3
      },
      new Person(){
      Name = "Charles",
      Age = 21,
      Height = 2.8
      }
    };

    public WeatherForecastController()
    {
    }

    [HttpGet("numbers")]
    public List<int> Get()
    {
        var number = new List<int>()
        {
            1, 2, 3, 4, 5

        };
        return number;
    }

    [HttpGet("NumbersInput")]
    public ActionResult<int> NumbersInput([FromQuery] int number)
    {
        if (Interger.Contains(number))
        {
            return Ok(number);
        }

        return NotFound();
    }

    [HttpGet("bools")]
    public List<bool> Bools()
    {
        var boolean = new List<bool>()
        {
            true, false
        };
        return boolean;
    }

    [HttpGet("boolsInput")]
    public ActionResult<bool> BoolsInput([FromQuery] bool boolean)
    {
        if (Boolean.Contains(boolean))
        {
            return Ok(boolean);
        }

        return NotFound();
    }

    [HttpGet(template: "string")]
    public List<string> String()
    {
        var strings = new List<string>()
        {
            "a", "b", "c", "d", "e"
        };
        return strings;
    }

    [HttpGet(template: "stringInput")]
    public ActionResult<string> StringInput([FromQuery] string name)
    {
        var content = new List<string>()
            { };
        foreach (var element in Summaries)
        {
            if (element.StartsWith(name))
            {
                content.Add(element);

            }
        }

        if (content.Count == 0)
        {
            return NotFound();
        }

        return Ok(content);
    }



    [HttpGet(template: "double")]
    public List<double> Double()
    {
        var doubles = new List<double>()
        {
            1.5
        };
        return doubles;
    }

    [HttpGet(template: "doubleInput")]
    public double doubleInput([FromQuery] double doubles)
    {
        return doubles;
    }

    [HttpGet(template: "Person")]
    public List<Person> Persons()
    {
        var person = new Person()
        {
            Name = "Erin",
            Age = 21,
            Height = 1.62
        };
        var person2 = new Person()
        {
            Name = "Corrine",
            Age = 25,
            Height = 1.75
        };
        var persons = new List<Person>();
        persons.Add(person);
        persons.Add(person2);
        return persons;
    }

    [HttpGet(template: "personInput")]
    public ActionResult<Person> personInput([FromQuery] Person person)
    {
        var content = new List<Person>()
            { };
        foreach (var element in PersonList)
        {
            if (element.Name == person.Name && element.Age == person.Age && element.Height == person.Height)
            {
                content.Add(element);
            }
         
        }
        return content.Count == 0 ? NotFound() : Ok(content);

    }
}
