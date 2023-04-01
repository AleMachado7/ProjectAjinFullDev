using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Emails;
using Xpto.Core.Shared.Entities.Phones;

namespace Xpto.Services.Phones
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _repository;

        public PhoneService(IPhoneRepository repository)
        {
            _repository = repository;
        }

        public Phone Create(Phone phone)
        {
            _repository.Insert(phone);
            return phone;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public List<Phone> Get(int customerCode)
        {
            List<Phone> phones = _repository.Get(customerCode);
            return phones;
        }

        public Phone Update(Phone phone)
        {
            _repository.Update(phone);
            return phone;
        }
    }
}
