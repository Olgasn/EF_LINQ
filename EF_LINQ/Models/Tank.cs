namespace EF_LINQ.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tank()
        {
            Operations = new HashSet<Operation>();
        }

        public int TankID { get; set; }

        [StringLength(20)]
        public string TankType { get; set; }

        public float? TankVolume { get; set; }

        public float? TankWeight { get; set; }

        [StringLength(20)]
        public string TankMaterial { get; set; }

        [StringLength(50)]
        public string TankPicture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
