﻿using AutoMapper;
using InvoiceApp.Application.Common.Interfaces;
using InvoiceApp.Application.Invoices.Commands;
using InvoiceApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceApp.Application.Invoices.Handlers
{
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateInvoiceCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Invoice>(request);

            _context.Invoices.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;

            //var element = _context.Invoices.Select(x => {x.Id == x.})
            //_context.Invoices.Remove()
        }
    }
}