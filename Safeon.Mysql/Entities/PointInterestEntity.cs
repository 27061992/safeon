﻿namespace Safeon.Mysql.Entities
{
    public class PointInterestEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int PointInterestTypeId { get; set; }
        public bool Active { get; set; }

        public virtual PointInterestTypeEntity PointInterestType { get; set; }
    }
}