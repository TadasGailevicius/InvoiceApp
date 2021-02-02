using InvoiceApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Domain.Entities
{
    public class Vat: AuditEntity
    {
        public int Tax { get; set; }
        public string Country { get; set; }
        public bool IsEU { get; set; }


    }
}
