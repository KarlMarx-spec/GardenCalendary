using Domain.BaseEntites;

namespace Domain.Entities;

public partial class RPrecipitation : BaseEntity
{
    /// <summary>
    ///  справочник осадков
    /// </summary>
    public int Id { get; set; }

    public string? Precipitation { get; set; } //описание осадка  солнечно ,  дождь... снег
}
