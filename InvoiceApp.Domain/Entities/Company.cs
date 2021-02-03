using InvoiceApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Domain.Entities
{
    public class Company : AuditEntity
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Contact { get; set; }

        public string CompanyAdress { get; set; }

        public bool isCompany { get; set; }
    }
}
