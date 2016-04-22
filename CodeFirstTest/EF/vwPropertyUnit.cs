namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwPropertyUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropertyID { get; set; }

        public int? NumUnits { get; set; }
    }
}
