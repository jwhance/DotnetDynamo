using DotnetDynamo.Models;

namespace DotnetDynamo.Mappings
{
    public static class CustomerRequestToCustomerMapping
    {
        public static Customer ToCustomer(this CustomerRequest customerRequest)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                GitHubUsername = customerRequest.GitHubUsername,
                DateOfBirth = customerRequest.DateOfBirth,
                FullName = customerRequest.FullName,
                Email = customerRequest.Email,
                UpdatedAt = DateTime.UtcNow,
                Factor = customerRequest.Factor,
            };

            if (customerRequest.RecordAttributes != null)
            {
                var attrDictionary = new Dictionary<string, Attributes>();
                foreach (var attr in customerRequest.RecordAttributes)
                {
                    var attribute = new Attributes
                    {
                        boolAttribute = attr.Value.boolAttribute,
                        stringAttribute = attr.Value.stringAttribute,
                        intAttribute = attr.Value.intAttribute,
                        decimalAttribute = attr.Value.decimalAttribute,
                        dateTimeAttribute = attr.Value.dateTimeAttribute,
                    };

                    attrDictionary.Add(attr.Key, attribute);
                }

                customer.RecordAttributes = attrDictionary;
            }

            return customer;
        }
    }
}
