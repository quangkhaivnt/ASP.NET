namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Commune> Communes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GenderCustomer> GenderCustomers { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<StatusCustomer> StatusCustomers { get; set; }
        public virtual DbSet<StatusProduct> StatusProducts { get; set; }
        public virtual DbSet<StatusShipment> StatusShipments { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.cityId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Communes)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.communeId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Districts)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.districtId);

            modelBuilder.Entity<Admin>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.nameCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Commune>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.userId);

            modelBuilder.Entity<District>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<GenderCustomer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<GenderCustomer>()
                .HasMany(e => e.Admins)
                .WithOptional(e => e.GenderCustomer)
                .HasForeignKey(e => e.genderId);

            modelBuilder.Entity<GenderCustomer>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.GenderCustomer)
                .HasForeignKey(e => e.genderId);

            modelBuilder.Entity<GenderCustomer>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.GenderCustomer)
                .HasForeignKey(e => e.genderId);

            modelBuilder.Entity<Material>()
                .Property(e => e.material1)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.price)
                .HasPrecision(16, 2);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.card_name)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.PaymentMethod)
                .HasForeignKey(e => e.payment_method_id);

            modelBuilder.Entity<Product>()
                .Property(e => e.nameImage)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.sender)
                .IsUnicode(false);

            modelBuilder.Entity<Shipper>()
                .Property(e => e.typeShipper)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.price)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Size>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<StatusCustomer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusCustomer>()
                .HasMany(e => e.Admins)
                .WithOptional(e => e.StatusCustomer)
                .HasForeignKey(e => e.statusId);

            modelBuilder.Entity<StatusCustomer>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.StatusCustomer)
                .HasForeignKey(e => e.statusId);

            modelBuilder.Entity<StatusCustomer>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.StatusCustomer)
                .HasForeignKey(e => e.statusId);

            modelBuilder.Entity<StatusProduct>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusProduct>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.StatusProduct)
                .HasForeignKey(e => e.statusId);

            modelBuilder.Entity<StatusShipment>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
