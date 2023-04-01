using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;

namespace Xpto.Core.Shared.Entities.Emails
{
    public interface IEmailService
    {
        Email Create(Email email);
        Email Update(Email email);
        void Delete(Guid id);
        List<Email> Get(int customerCode);
    }
}
