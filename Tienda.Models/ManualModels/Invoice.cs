namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Invoice
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Invoice
        /// </summary>
        public Invoice()
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
        public int InvoiceId { get; set; }

        /// <summary>
        /// Propiedad State (State)
        /// </summary>
        [DisplayName("State ")]
        public string State { get; set; }

        /// <summary>
        /// Propiedad DateInvoice (DateInvoice)
        /// </summary>
        [DisplayName("DateInvoice")]
        public DateTime DateInvoice { get; set; }

        /// <summary>
        /// Fecha en que se facturo
        /// </summary>
        [DisplayName("PaymentDate")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
        [DisplayName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Propiedad SubTotal (SubTotal)
        /// </summary>
        [DisplayName("SubTotal")]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Propiedad Iva (Iva)
        /// </summary>
        [DisplayName("Iva")]
        public decimal Iva { get; set; }

        /// <summary>
        /// Propiedad Total (Total)
        /// </summary>
        [DisplayName("Total")]
        public decimal Total { get; set; }

        /// <summary>
        /// Propiedad TotalArticles (TotalArticles)
        /// </summary>
        [DisplayName("TotalArticles")]
        public int TotalArticles{ get; set; }

        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************
        /// <summary>
        /// Relación Ciudades (Cities)
        /// </summary>
        [DisplayName("Purchase")]
        [InversePropertyAttribute("Invoice")]
        public virtual ICollection<Purchase> Purchases { get; set; }

        #endregion

        #region Sources

        // ************************************
        // * SOURCES
        // ************************************

        /// <summary>
        /// Id de la Entidad relacionada: Provider (Provider)
        /// </summary>
        [DisplayName("Provider")]
        [Required]
        public int ProviderId { get; set; }

        /// <summary>
        /// Relación Cliente (Customer)
        /// </summary>
        [DisplayName("Provider")]
        [ForeignKey("ProviderId")]
        [InversePropertyAttribute("Invoices")]
        public virtual Provider Provider{ get; set; }

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
