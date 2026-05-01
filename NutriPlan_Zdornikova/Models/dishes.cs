namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dishes()
        {
            FoodLogs = new HashSet<FoodLogs>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string name { get; set; }

        public int CaloriesPer100G { get; set; }

        public double ProteinPer100G { get; set; }

        public double FatPer100G { get; set; }

        public double CarbsPer100G { get; set; }

        public bool IsActive { get; set; }

        public int Created_by { get; set; }

        public int? ViewDishes { get; set; }

        public virtual Users Users { get; set; }

        public virtual ViewDishes ViewDishes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodLogs> FoodLogs { get; set; }
    }
}
