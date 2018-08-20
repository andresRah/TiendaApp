namespace Tienda.Models.ManualModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SalesDetails
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: SalesDetails
        /// </summary>
        public SalesDetails()
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
        public int SalesDetailsId { get; set; }

        /// <summary>
        /// Propiedad Quantity (Quantity)
        /// </summary>
        [DisplayName("Quantity")]
        [Required]
        public int Quantity{ get; set; }


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
        [DisplayName("Product")]
        [ForeignKey("ProductId")]
        [InversePropertyAttribute("SalesDetails")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// Id de la Entidad relacionada: Sales (Sales)
        /// </summary>
        [DisplayName("Sales")]
        [Required]
        public int SalesId { get; set; }

        /// <summary>
        /// Relación Sales (Sales)
        /// </summary>
        [DisplayName("Sales")]
        [ForeignKey("SalesId")]
        [InversePropertyAttribute("SalesDetails")]
        public virtual Sales Sales { get; set; }

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
