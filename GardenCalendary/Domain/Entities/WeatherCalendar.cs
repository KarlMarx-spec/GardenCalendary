using Domain.BaseEntites;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class WeatherCalendar : BaseEntity
{
    public int Id { get; set; }

    public int? ObjectId { get; set; }

    public DateTime? DateTame { get; set; }

    public int? PrecipitationId { get; set; }

    public int? TemperaturaMax { get; set; }

    public int? TemperaturaMin { get; set; }

    public virtual RReestrObject? Object { get; set; }

    public virtual RPrecipitation? Precipitation { get; set; }
}
