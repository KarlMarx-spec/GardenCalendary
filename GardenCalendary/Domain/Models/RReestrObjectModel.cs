﻿using Domain.BaseEntites;

namespace Domain.Models
{
    public class RReestrObjectModel : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string? ObjectName { get; set; }

        public int? AccuweatherId { get; set; }
    }
}
