namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorPhone")]
    public partial class InvestorPhone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvestorPhoneID { get; set; }

        public int InvestorID { get; set; }

        [Required]
        [StringLength(25)]
        public string Phone { get; set; }

        public int PhoneTypeID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Investor Investor { get; set; }

        public virtual PhoneType PhoneType { get; set; }
    }
}
