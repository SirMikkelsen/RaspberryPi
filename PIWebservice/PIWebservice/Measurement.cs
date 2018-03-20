namespace PIWebservice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Measurement
    {
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        [Column("Measurement")]
        public int MeasurementValue { get; set; }
    }
}
