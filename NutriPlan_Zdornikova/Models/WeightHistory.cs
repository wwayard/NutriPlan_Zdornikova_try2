namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeightHistory")]
    public partial class WeightHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idWeight { get; set; }

        public int UserId { get; set; }

        public double WeghtKg { get; set; }

        public DateTime RecordDate { get; set; }

        public virtual UserProfiles UserProfiles { get; set; }
    }
}
