namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserProfiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfiles()
        {
            FoodLogs = new HashSet<FoodLogs>();
            WeightHistory = new HashSet<WeightHistory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirthday { get; set; }

        public int heightCM { get; set; }

        public double weightCM { get; set; }

        public int DailyCalories { get; set; }

        public DateTime Updatet_at { get; set; }

        public int IdGender { get; set; }

        public int idGoal { get; set; }

        public int IdActivityLevel { get; set; }

        public virtual ActivityLevel ActivityLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodLogs> FoodLogs { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Goal Goal { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeightHistory> WeightHistory { get; set; }
    }
}
