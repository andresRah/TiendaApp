namespace Tienda.DTO.ManualCode.DTO
{
    using System;
    using System.ComponentModel;

    public partial class InvoiceDTO
    {
        [DisplayName("InvoiceId")]
        public int InvoiceId { get; set; }
    }
}