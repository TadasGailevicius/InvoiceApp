using FluentValidation.Validators;
using InvoiceApp.Application.Invoices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceApp.Application.Invoices.Validators
{
    public class MustHaveInvoiceItemPropertyValidator : PropertyValidator
    {
        public MustHaveInvoiceItemPropertyValidator()
            : base("Property {PropertyName} should not be an empty list.")
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var list = context.PropertyValue as IList<InvoiceItemVm>;
            return list != null && list.Any();
        }
    }
}
