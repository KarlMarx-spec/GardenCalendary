using Domain.BaseEntites;
using Domain.Entities;

namespace Domain.Models
{
  public  class WeatherCalendarModel : BaseModel
    {
        public int Id { get; set; }

        public int? ObjectId { get; set; }

        public DateTime? DateTime { get; set; }

        public string? Precipitation { get; set; }

        public int? TemperaturaMax { get; set; }

        public int? TemperaturaMin { get; set; }

    }
}
