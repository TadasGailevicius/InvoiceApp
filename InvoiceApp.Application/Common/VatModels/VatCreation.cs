using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Application.Common.Vat
{
    public class VatCreation: IRequest<int>
    {
        public int Tax { get; set; }
        public string Country { get; set; }
        public bool IsEU { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
