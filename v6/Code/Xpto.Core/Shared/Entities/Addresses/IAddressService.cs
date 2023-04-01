using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpto.Core.Shared.Entities.Addresses
{
    public interface IAddressService
    {
        Address Create(Address address);
        Address Update(Address address);
        void Delete(Guid id);
        List<Address> Get(int customerCode);
    }
}
