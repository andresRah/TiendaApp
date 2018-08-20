namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Product
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Product
        /// </summary>
        public Product()
        {

        }
        #endregion

        #region Properties

        // ************************************
        // * PROPERTIES
        // ************************************

        /// <summary>
        /// Propiedad que representa la llave primaria de la entidad: Intencion
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Serial { get; set; }

        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal BuySale { get; set; }

        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        /// <summary>
        /// Relación Ventas (Sales)
        /// </summary>
        [DisplayName("SalesDetails")]
        [InversePropertyAttribute("Product")]
        public virtual ICollection<SalesDetails> SalesDetails { get; set; }

        /// <summary>
        /// Relación Compras (Purchase)
        /// </summary>
        [DisplayName("Purchase")]
        [InversePropertyAttribute("Product")]
        public virtual ICollection<Purchase> Purchases { get; set; }
        #endregion

        #region Sources

        // ************************************
        // * SOURCES
        // ************************************

        /// <summary>
        /// Id de la Entidad relacionada: Categoria (Category)
        /// </summary>
        [DisplayName("Categoria")]
        [Required]
        public int CategoryId { get; set; }

        /// <summary>
        /// Relación Categoria (Category)
        /// </summary>
        [DisplayName("Categoria")]
        [ForeignKey("CategoryId")]
        [InversePropertyAttribute("Products")]
        public virtual Category Category { get; set; }

        #endregion

        #region Auditoria

        /// <summary>
        /// Fecha en que se creo la entidad
        /// </summary>
        [DisplayName("Fecha de Creación")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Fecha en que se creo la entidad
        /// </summary>
        [DisplayName("Fecha de Actualización")]
        public DateTime UpdateTime { get; set; }

        #endregion
    }
}
