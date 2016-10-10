namespace EF_LINQ.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Fuel
    {
        public Fuel()
        {
            Operations = new HashSet<Operation>();
        }

        public int FuelID { get; set; }

        [StringLength(50)]
        public string FuelType { get; set; }

        public float? FuelDensity { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }
    }
}
