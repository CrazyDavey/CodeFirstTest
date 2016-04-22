namespace CodeFirstTest.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CFREEntities : DbContext
    {
        public CFREEntities()
            : base("name=CFREEntitiesConnection")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<CashFlowCategory> CashFlowCategories { get; set; }
        public virtual DbSet<CashFlowType> CashFlowTypes { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<FinancingEvent> FinancingEvents { get; set; }
        public virtual DbSet<FinancingEventType> FinancingEventTypes { get; set; }
        public virtual DbSet<Investor> Investors { get; set; }
        public virtual DbSet<InvestorCashFlow> InvestorCashFlows { get; set; }
        public virtual DbSet<InvestorEmail> InvestorEmails { get; set; }
        public virtual DbSet<InvestorPhone> InvestorPhones { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyCashFlow> PropertyCashFlows { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
        public virtual DbSet<vwPropertyUnit> vwPropertyUnits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.ZIPCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CashFlowCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowCategory>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowCategory>()
                .HasMany(e => e.InvestorCashFlows)
                .WithRequired(e => e.CashFlowCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CashFlowCategory>()
                .HasMany(e => e.PropertyCashFlows)
                .WithRequired(e => e.CashFlowCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CashFlowType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashFlowType>()
                .HasMany(e => e.CashFlowCategories)
                .WithRequired(e => e.CashFlowType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<EmailType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<EmailType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<EmailType>()
                .HasMany(e => e.InvestorEmails)
                .WithRequired(e => e.EmailType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinancingEvent>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FinancingEvent>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEvent>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEventType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEventType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEventType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEventType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FinancingEventType>()
                .HasMany(e => e.FinancingEvents)
                .WithRequired(e => e.FinancingEventType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Investor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Investor>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Investor>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Investor>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Investor>()
                .HasMany(e => e.InvestorEmails)
                .WithRequired(e => e.Investor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Investor>()
                .HasMany(e => e.InvestorPhones)
                .WithRequired(e => e.Investor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvestorCashFlow>()
                .Property(e => e.Amount)
                .HasPrecision(19, 0);

            modelBuilder.Entity<InvestorCashFlow>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorCashFlow>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorEmail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorEmail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorEmail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorPhone>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorPhone>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<InvestorPhone>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.Manager)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneType>()
                .HasMany(e => e.InvestorPhones)
                .WithRequired(e => e.PhoneType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.FinancingEvents)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.InvestorCashFlows)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.PropertyCashFlows)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyCashFlow>()
                .Property(e => e.Amount)
                .HasPrecision(19, 0);

            modelBuilder.Entity<PropertyCashFlow>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PropertyCashFlow>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PropertyType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PropertyType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PropertyType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Rent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Unit>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UnitType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UnitType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UnitType>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.UnitType)
                .WillCascadeOnDelete(false);
        }
    }
}
