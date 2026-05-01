namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityLevel")]
    public partial class ActivityLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityLevel()
        {
            UserProfiles = new HashSet<UserProfiles>();
        }

        [Key]
        public int idActivity { get; set; }

        [Required]
        [StringLength(100)]
        public string nameActivity { get; set; }

        public double PAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfiles> UserProfiles { get; set; }
    }
}
