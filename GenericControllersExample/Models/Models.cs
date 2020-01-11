using System;
using GenericControllersExample.Attributes;

namespace GenericControllersExample.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
    }

    [GenericController("api/pen")]
    public class Pen : Entity
    {
        public string Title { get; set; }

        public int Length { get; set; }
    }

    [GenericController("api/song")]
    public class Song : Entity
    {
        public string Title { get; set; }

        public string Artist { get; set; }
    }

    [GenericController("api/user")]
    public class User : Entity
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
