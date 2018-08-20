namespace Tienda.Models.ManualModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Purchase
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Purchase
        /// </summary>
        public Purchase()
        {

        }
        #endregion

        #region Properties

        // ************************************
        // * PROPERTIES
        // ************************************

        /// <summary>
        /// Propiedad que representa la llave primaria de la entidad: Purchase
        /// </summary>
        [Key]
        public int PurchaseId { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
        [DisplayName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Propiedad Quantity (Quantity)
        /// </summary>
        [DisplayName("Quantity")]
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Propiedad UnitPrice (UnitPrice)
        /// </summary>
        [DisplayName("UnitPrice")]
        [Required]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Propiedad SubTotalUnitPrice (SubTotalUnitPrice)
        /// </summary>
        [DisplayName("SubTotalUnitPrice")]
        [Required]
        public decimal SubTotalUnitPrice { get; set; }

        /// <summary>
        /// Propiedad Iva (Iva)
        /// </summary>
        [DisplayName("Iva")]
        [Required]
        public decimal Iva { get; set; }

        /// <summary>
        /// Propiedad TotalUnitPrice (TotalUnitPrice)
        /// </summary>
        [DisplayName("TotalUnitPrice")]
        [Required]
        public decimal TotalUnitPrice { get; set; }

        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        #endregion

        #region Sources

        // ************************************
        // * SOURCES
        // ************************************

        /// <summary>
        /// Id de la Entidad relacionada: Sales (Sales)
        /// </summary>
        [DisplayName("Product")]
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// Relación Product (Product)
        /// </summary>
        [DisplayName("Compra")]
        [ForeignKey("ProductId")]
        [InversePropertyAttribute("Purchases")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// Id de la Entidad relacionada: Sales (Sales)
        /// </summary>
        [DisplayName("Invoice")]
        [Required]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Relación Invoice (Invoice)
        /// </summary>
        [DisplayName("Invoice")]
        [ForeignKey("InvoiceId")]
        [InversePropertyAttribute("Purchases")]
        public virtual Invoice Invoice { get; set; }

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