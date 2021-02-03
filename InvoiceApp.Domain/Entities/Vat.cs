using InvoiceApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Domain.Entities
{
    public class Vat: AuditEntity
    {
        public int Id { get; set; }
        public int Tax { get; set; }
        public string Country { get; set; }
        public bool IsEU { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }


    }
}
