using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;

namespace Xpto.Core.Shared.Entities.Addresses
{
    public interface IAddressRepository
    {
        Address Insert(Address address);
        void Update(Address address);
        int Delete(Guid id);
        List<Address> Get(int customerCode);
    }
}
