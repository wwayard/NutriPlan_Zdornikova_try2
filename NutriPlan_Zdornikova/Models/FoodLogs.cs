namespace NutriPlan_Zdornikova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodLogs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int userId { get; set; }

        public int DishId { get; set; }

        public int IdMealType { get; set; }

        public double WeightGrams { get; set; }

        [Column(TypeName = "date")]
        public DateTime LogDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual dishes dishes { get; set; }

        public virtual TypesMeal TypesMeal { get; set; }

        public virtual UserProfiles UserProfiles { get; set; }
    }
}
