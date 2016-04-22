namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unit")]
    public partial class Unit
    {
        public int UnitID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int PropertyID { get; set; }

        public int UnitTypeID { get; set; }

        public decimal Rent { get; set; }

        public bool Vacant { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Property Property { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
