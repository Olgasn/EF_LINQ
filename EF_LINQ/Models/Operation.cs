namespace EF_LINQ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operation
    {
        public int OperationID { get; set; }

        public int? FuelID { get; set; }

        public int? TankID { get; set; }

        public float? Inc_Exp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public virtual Fuel Fuel { get; set; }

        public virtual Tank Tank { get; set; }
    }
}
