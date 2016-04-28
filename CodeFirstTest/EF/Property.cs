namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Property")]
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            FinancingEvents = new HashSet<FinancingEvent>();
            InvestorCashFlows = new HashSet<InvestorCashFlow>();
            PropertyCashFlows = new HashSet<PropertyCashFlow>();
            Units = new HashSet<Unit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropertyID { get; set; }

        public int PropertyTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int AddressID { get; set; }

        public int ManagerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SoldDate { get; set; }

        public int AppraisalValue { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int SquareFeet { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Address Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancingEvent> FinancingEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorCashFlow> InvestorCashFlows { get; set; }

        public virtual Manager Manager { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyCashFlow> PropertyCashFlows { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit> Units { get; set; }
    }
}
