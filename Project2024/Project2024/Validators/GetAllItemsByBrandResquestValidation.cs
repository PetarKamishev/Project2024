using FluentValidation;
using Project2024.Project2024.Models.Requests;

namespace Project2024.Validators
{
    public class GetAllItemsByBrandResquestValidation : AbstractValidator<GetAllItemsByBrandRequest>
    {
        public GetAllItemsByBrandResquestValidation() 
        {
            RuleFor(x => x.BrandId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.DateBefore).NotEmpty().GreaterThan(new DateTime(1900, 01, 01));        
        }
    }
}
