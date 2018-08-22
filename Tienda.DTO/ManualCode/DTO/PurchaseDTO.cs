namespace Tienda.DTO.ManualCode.DTO
{
    using System;
    using System.ComponentModel;

    public partial class PurchaseDTO
    {
        [DisplayName("PurchaseId")]
        public int PurchaseId { get; set; }
    }
}