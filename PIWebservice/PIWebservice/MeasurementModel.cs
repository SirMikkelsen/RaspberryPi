namespace PIWebservice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MeasurementModel : DbContext
    {
        public MeasurementModel()
            : base("name=MeasurementModel")
        {
        }

        public virtual DbSet<Measurement> Measurements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
