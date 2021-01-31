using InvoiceApp.Api.Services;
using InvoiceApp.Application.Common.Interfaces;
using InvoiceApp.Application.Invoices.Commands;
using InvoiceApp.Application.Invoices.Queries;
using InvoiceApp.Application.Invoices.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.Api.Controllers
{
    [Authorize]
    public class InvoicesController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public InvoicesController(ICurrentUserService currentUserService) 
        {
            _currentUserService = currentUserService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateInvoiceCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<InvoiceVm>> Get()
        {
            return await Mediator.Send(new GetUserInvoicesQuery { User = _currentUserService.UserId });
        }
    }
}
