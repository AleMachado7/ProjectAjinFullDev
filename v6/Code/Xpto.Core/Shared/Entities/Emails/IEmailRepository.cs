using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpto.Core.Shared.Entities.Emails
{
    public interface IEmailRepository
    {
        Email Insert(Email email);
        void Update(Email email);
        int Delete(Guid id);
        List<Email> Get(int customerCode);

    }
}
