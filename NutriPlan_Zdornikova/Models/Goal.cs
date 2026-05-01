namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Goal")]
    public partial class Goal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goal()
        {
            UserProfiles = new HashSet<UserProfiles>();
        }

        [Key]
        public int IdGoal { get; set; }

        [Required]
        [StringLength(50)]
        public string NameGoal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfiles> UserProfiles { get; set; }
    }
}
