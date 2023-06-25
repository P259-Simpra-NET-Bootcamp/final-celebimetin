﻿using FluentValidation;

namespace Schema.Validations
{
    public class ProductUpdateRequestValidator : AbstractValidator<ProductUpdateRequest>
    {
        public ProductUpdateRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(3, 100);
            RuleFor(x => x.UnitPrice).NotNull().NotEmpty();
            RuleFor(x => x.UnitsInStock).NotNull().NotEmpty();
            RuleFor(x => x.UnitPrice).NotNull().NotEmpty();
            RuleFor(x => x.Description).Length(3, 250);
            RuleFor(x => x.IsStatus).NotNull().NotEmpty();
        }
    }
}