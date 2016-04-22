namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailType")]
    public partial class EmailType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailType()
        {
            InvestorEmails = new HashSet<InvestorEmail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmailTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDate { get; set; }

        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorEmail> InvestorEmails { get; set; }
    }
}
