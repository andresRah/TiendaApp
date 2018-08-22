namespace Tienda.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;
    using Tienda.Models.ManualModels;

    /// <summary>
    /// Clase que implementa el patron Unit of Work y representa el Contexto de la base de datos
    /// </summary>
    public partial class TiendaDbContext : DbContext, IUnitOfWork, IDisposable
    {
        /// <summary>
        /// Identificador del contexto
        /// </summary>
        public string key;

        /// <summary>
        /// Conjunto de entidades Category (Category)
        /// </summary>
        public DbSet<Category> Category { get; set; }
        /// <summary>
        /// Conjunto de entidades Category (Category)
        /// </summary>
        public DbSet<Category> Category { get; set; }
        /// <summary>
        /// Conjutno de entidades Customer (Customer)
        /// </summary>
        public DbSet<Customer> Customer { get; set; }
        /// <summary>
        /// Conjunto de entidades Invoice (Invoice)
        /// </summary>
        public DbSet<Invoice> Invoice { get; set; }
        /// <summary>
        /// Conjunto de entidades Product (Product)
        /// </summary>
        public DbSet<Product> Product { get; set; }
        /// <summary>
        /// Conjunto de entidades Provider (Provider)
        /// </summary>
        public DbSet<Provider> Provider { get; set; }
        /// <summary>
        /// Conjunto de entidades Purchase (Purchase)
        /// </summary>
        public DbSet<Purchase> Purchase { get; set; }
        /// <summary>
        /// Conjunto de entidades Sales (Sales)
        /// </summary>
        public DbSet<Sales> Sales { get; set; }
        /// <summary>
        /// Conjunto de entidades SalesDetails (SalesDetails)
        /// </summary>
        public DbSet<SalesDetails> SalesDetails { get; set; }

        /// <summary>
        /// Metodo constructor
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TiendaDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        //public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
        //   : base(options)
        //{
        //    //Database.EnsureCreated();
        //    this.key = Guid.NewGuid().ToString();
        //}

        /// <summary>
        /// Metodo que devuelve la entrada dada la entidad
        /// </summary>
        /// <param name="entity">Entidad</param>
        /// <returns>Entrada de la entidad</returns>
        new public EntityEntry Entry(Object entity)
        {
            return base.Entry(entity);
        }

        /// <summary>
        /// Metodo que salva los cambios efectuados al contexto actual
        /// </summary>
        void IUnitOfWork.SaveChanges()
        {
            base.SaveChanges();
        }

        /// <summary>
        /// Metodo que desecha el contexto
        /// </summary>
        void IUnitOfWork.Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Metodo que desecha el contexto 
        /// </summary>
        /// <param name="disposing">Boleano que indica si el contexto esta siendo desechado</param>
        //protected virtual void Dispose(bool disposing) => base.Dispose(disposing);

        /// <summary>
        /// Metodo en donde se especifican las relaciones existentes en el modelo
        /// </summary>
        /// <param name="modelBuilder">Contructor del modelo</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Intencion>()
            //        .HasOptional(e => e.IdIntencion)
            //        .WithMany();
            //modelBuilder.Entity<InventarioIntencion>()
            //    .HasMany(e => e.Positions)
            //    .WithRequired(e => e.Hotel);
            //modelBuilder.Entity<InventarioProductoAgricola>()
            //    .HasMany(e => e.JobRoleProfiles)
            //    .WithOptional(e => e.Hotel);
            //modelBuilder.Entity<City>()
            //    .HasMany(e => e.Hotels)
            //    .WithRequired(e => e.City);
            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.Cities)
            //    .WithRequired(e => e.Country);
        }
    }
}