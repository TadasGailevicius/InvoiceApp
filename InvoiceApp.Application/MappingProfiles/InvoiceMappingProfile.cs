using AutoMapper;
using InvoiceApp.Application.Invoices.Commands;
using InvoiceApp.Application.Invoices.ViewModels;
using InvoiceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Application.MappingProfiles
{
    public class InvoiceMappingProfile : Profile
    {
        public InvoiceMappingProfile()
        {
            CreateMap<Invoice, InvoiceVm>();
            CreateMap<InvoiceItem, InvoiceItemVm>().ConstructUsing(i => new InvoiceItemVm
            {
                Id = i.Id,
                Item = i.Item,
                Quantity = i.Quantity,
                Rate = i.Rate
            });

            CreateMap<InvoiceVm, Invoice>();
            CreateMap<InvoiceItemVm, InvoiceItem>();

            CreateMap<CreateInvoiceCommand, Invoice>();
        }
    }
}
