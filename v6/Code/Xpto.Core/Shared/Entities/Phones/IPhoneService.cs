using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;

namespace Xpto.Core.Shared.Entities.Phones
{
    public interface IPhoneService
    {
        Phone Create(Phone phone);
        Phone Update(Phone phone);
        void Delete(Guid id);
        List<Phone> Get(int customerCode);
    }
}
