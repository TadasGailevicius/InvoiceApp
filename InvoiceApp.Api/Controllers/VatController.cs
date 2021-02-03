using InvoiceApp.Application.Common.Interfaces;
using InvoiceApp.Application.Common.Vat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.Api.Controllers
{
    public class VatController: ApiController
    {
        private readonly IVatService _vatService;

        public VatController(IVatService vatService)
        {
            _vatService = vatService ;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(VatCreation vatCreation)
        {
            return await Mediator.Send(vatCreation);

        }

        [HttpGet]
        public async Task<IList<VatCreation>> Get() 
        { 
        
            return null;
            //return await Mediator.Send(new GetUserInvoicesQuery { User = _currentUserService.UserId });
        }

        [HttpGet("{Country}")]
        public async Task<ActionResult<int>> GetByCountry([FromRoute]string country)
        {
            return null;

        }
    }
}
