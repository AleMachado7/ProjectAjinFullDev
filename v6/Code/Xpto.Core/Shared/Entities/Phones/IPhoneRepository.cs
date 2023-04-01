using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Customers;

namespace Xpto.Core.Shared.Entities.Phones
{
    public interface IPhoneRepository
    {
        Phone Insert(Phone phone);
        void Update(Phone phone);
        int Delete(Guid id);
        List<Phone> Get(int customerCode);
    }
}
