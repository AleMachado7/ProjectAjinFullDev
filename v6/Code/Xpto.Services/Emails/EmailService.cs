using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;
using Xpto.Core.Shared.Entities.Emails;

namespace Xpto.Services.Emails
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _repository;

        public EmailService(IEmailRepository repository)
        {
            _repository = repository;
        }

        public Email Create(Email email)
        {
            _repository.Insert(email);
            return email;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public List<Email> Get(int customerCode)
        {
            List<Email> emails = _repository.Get(customerCode);
            return emails;
        }

        public Email Update(Email email)
        {
            _repository.Update(email);
            return email;
        }
    }
}
