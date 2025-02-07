﻿using InvoiceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Invoice> Invoices { get; set; }
        DbSet<InvoiceItem> InvoiceItems {get; set;}

        DbSet<InvoiceApp.Domain.Entities.Vat> InvoiceVat{ get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
