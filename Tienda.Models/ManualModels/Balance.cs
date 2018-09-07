namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Balance
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Balance
        /// </summary>
        public Balance()
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
        public int BalanceId { get; set; }

        /// <summary>
        /// Propiedad DateBalance (DateBalance)
        /// </summary>
        [DisplayName("DateBalance")]
        [Required]
        public DateTime DateBalance { get; set; }

        /// <summary>
        /// Propiedad TotalSold (TotalSold)
        /// </summary>
        [DisplayName("TotalSold")]
        public decimal TotalSold { get; set; }

        /// <summary>
        /// Propiedad TotalBuy (TotalBuy)
        /// </summary>
        [DisplayName("TotalBuy")]
        public decimal TotalBuy { get; set; }

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
