namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypesMeal")]
    public partial class TypesMeal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesMeal()
        {
            FoodLogs = new HashSet<FoodLogs>();
        }

        [Key]
        public int idTypesMeal { get; set; }

        [Required]
        [StringLength(100)]
        public string NameTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodLogs> FoodLogs { get; set; }
    }
}
