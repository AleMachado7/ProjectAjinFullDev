using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Customers;
using Xpto.Core.Shared.Entities.Addresses;

namespace Xpto.Services.Addresses
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;

        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public Address Create(Address address)
        {
            _repository.Insert(address);
            return address;
        }

        public void Delete(Guid id)
        {
             _repository.Delete(id);
        }

        public List<Address> Get(int customerCode)
        {
           List<Address> addresses  = _repository.Get(customerCode);
           return addresses;
        }

        public Address Update(Address address)
        {
            _repository.Update(address);
            return address;
        }
    }
}

