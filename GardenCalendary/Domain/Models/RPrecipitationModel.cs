using Domain.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RPrecipitationModel : BaseModel
    {
        /// <summary>
        ///  справочник осадков
        /// </summary>
        public int Id { get; set; }

        public string? Precipitation { get; set; } //описание осадка  солнечно ,  дождь... снег
    }
}
