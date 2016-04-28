namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorEmail")]
    public partial class InvestorEmail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvestorEmailID { get; set; }

        public int InvestorID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int EmailTypeID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual EmailType EmailType { get; set; }

        public virtual Investor Investor { get; set; }
    }
}
