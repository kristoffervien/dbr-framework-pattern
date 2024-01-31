using CustomerModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommand, Result<Customer>>
    {
        private readonly IFrameworkPatterns<Customer> _patterns;

        public CustomerCreateCommandHandler(IFrameworkPatterns<Customer> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Customer>> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Customer>();

            // TODO: logic or call the _patterns framework
            await _patterns.CanSaveAsync(request.Model);
            await _patterns.GetValidAsync(request.Model);
            await _patterns.SaveAsync(request.Model);

            return result;
        }
    }
}