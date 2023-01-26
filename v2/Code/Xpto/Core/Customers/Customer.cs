using Xpto.Core.Shared.Entities;

namespace Xpto.Core.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PersonType { get; set; }
        public string Identity { get; set; }
        public IList<Address> Addresses { get; set; }
        public IList<Phone> Phones { get; set; }
        public IList<Email> Emails { get; set; }
        public string Note { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid CreationUserId { get; set; }
        public string CreationUserName { get; set; }
        public DateTime? ChangeDate { get; set; }
        public Guid ChangeUserId { get; set; }
        public string ChangeUserName { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid();
            Addresses = new List<Address>();
            Phones = new List<Phone>();
            Emails = new List<Email>();
        }
        public void PrintCustomerData(string data)
        {
            if (data == "Addresses")
            {
                for (int i = 0; i < this.Addresses.Count; i++)
                {
                    Console.WriteLine($"Endereço {i + 1}: {this.Addresses[i]}");
                }
            }
            else if (data == "Phones")
            {
                for (int i = 0; i < this.Phones.Count; i++)
                {
                    Console.WriteLine($"Telefone {i + 1}: {this.Phones[i]}");
                }
            }
            else if (data == "Emails")
            {
                for (int i = 0; i < this.Emails.Count; i++)
                {
                    Console.WriteLine($"E-mail {i + 1}: {this.Emails[i]}");
                }
            }
        }

        public void PrintCustomerFullData()
        {
            Console.WriteLine("Código: {0}", this.Code);
            Console.WriteLine("Nome: {0}", this.Name);
            Console.WriteLine("Tipo de Pessoa: {0}", this.PersonType);

            if (this.PersonType?.ToUpper() == "PJ")
            {
                Console.WriteLine("Nome Fantasia:: {0}", this.Nickname);
            }

            Console.WriteLine("CPF/CNPJ: {0}", this.Identity);

            if (this.PersonType?.ToUpper() == "PF" && this.BirthDate != null)
            {
                Console.WriteLine("Data de Nascimento: {0}", ((DateTime)this.BirthDate).ToString("dd/MM/yyyy"));
            }

            PrintCustomerData("Addresses");
            PrintCustomerData("Phones");
            PrintCustomerData("Emails");

            Console.WriteLine("Observação: {0}", this.Note);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
