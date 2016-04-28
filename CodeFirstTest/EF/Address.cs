namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Investors = new HashSet<Investor>();
            Managers = new HashSet<Manager>();
            Properties = new HashSet<Property>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }

        [Required]
        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(25)]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Investor> Investors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Property> Properties { get; set; }
    }
}
