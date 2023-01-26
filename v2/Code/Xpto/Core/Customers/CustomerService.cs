using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities;
using Xpto.Core.Shared.Functions;

namespace Xpto.Core.Customers
{
    public class CustomerService
    {
        public void List()
        {
            App.Clear();
            Console.WriteLine("Lista de Clientes");

            if (App.Customers.Count == 1)
                Console.WriteLine("1 registro encontrado");
            else if (App.Customers.Count > 1)
                Console.WriteLine("{0} registros encontrados", App.Customers.Count);
            else
                Console.WriteLine("nenhum registro encontrado");

            Console.WriteLine();
            Console.WriteLine("Lista de Clientes");
            Console.WriteLine(("").PadRight(100, '-'));
            Console.WriteLine("CÓDIGO".PadRight(10, ' ') + "| NOME");

            foreach (var customer in App.Customers)
            {
                Console.WriteLine(("").PadRight(100, '-'));
                Console.WriteLine($"{customer.Code.ToString().PadRight(10, ' ')}| {customer.Name}");
            }

            Console.WriteLine(("").PadRight(100, '-'));

            Console.WriteLine();
            Console.WriteLine("0 - Voltar");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out var action);

            while (action != 0)
            {
                Console.WriteLine("Comando inválido");
                int.TryParse(Console.ReadLine(), out action);
            }
        }

        public void Select()
        {
            App.Clear();
            Console.WriteLine("Consulta de Cliente");
            Console.WriteLine();
            Console.Write("Informe o código do cliente ou 0 para sair: ");

            while (true)
            {
                int.TryParse(Console.ReadLine(), out var code);

                if (code == 0)
                    return;

                var customer = App.Customers.FirstOrDefault(x => x.Code == code);

                if (customer == null)
                {
                    App.Clear();
                    Console.WriteLine("Consulta de Cliente");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cliente não encontrato ou código inválido");
                    Console.ResetColor();
                }
                else
                {
                    App.Clear();
                    Console.WriteLine("Consulta de Cliente");
                    Console.WriteLine();
                    Console.WriteLine(("").PadRight(100, '-'));
                    Console.WriteLine("Cliente Selecionado");
                    Console.WriteLine(("").PadRight(100, '-'));
                    customer.PrintCustomerFullData();
                    Console.WriteLine(("").PadRight(100, '-'));
                    Console.WriteLine("Deseja adicionar, editar ou excluir informações para este cliente? (S / N)");
                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        Console.WriteLine("Escolha uma opção abaixo:");
                        Console.WriteLine("1 - Adicionar Informações");
                        Console.WriteLine("2 - Editar Informações");
                        Console.WriteLine("3 - Excluir Informações");
                        Console.WriteLine("0 - Voltar");
                        Console.WriteLine(("").PadRight(100, '-'));
                        var optionValid = int.TryParse(Console.ReadLine(), out var dataOption);
                        while (!optionValid)
                        {
                            Console.WriteLine("Opção Inválida");
                            Console.WriteLine((""));
                            Console.WriteLine("Escolha uma opção abaixo:");
                            Console.WriteLine("1 - Adicionar Informações");
                            Console.WriteLine("2 - Editar Informações");
                            Console.WriteLine("3 - Excluir Informações");
                            Console.WriteLine("0 - Voltar");
                            optionValid = int.TryParse(Console.ReadLine(), out dataOption);
                        }

                        if (dataOption == 1)
                        {
                            Console.WriteLine("1 - Adicionar Endereço");
                            Console.WriteLine("2 - Adicionar Telefone");
                            Console.WriteLine("3 - Adicionar Email");
                            Console.WriteLine("0 - Voltar");
                            var operation = Console.ReadLine();
                            if (operation == "1") customer.Addresses.Add(NewAddress());
                            if (operation == "2") customer.Phones.Add(NewPhone());
                            if (operation == "3") customer.Emails.Add(NewEmail());
                        }
                        else if (dataOption == 2)
                        {
                            Console.WriteLine("1 - Editar Endereço");
                            Console.WriteLine("2 - Editar Telefone");
                            Console.WriteLine("3 - Editar Email");
                            Console.WriteLine("0 - Voltar");
                            var operation = Console.ReadLine();
                            if (operation == "1") EditCustomerData(customer, "Addresses");
                            else if (operation == "2") EditCustomerData(customer, "Phones");
                            else if (operation == "3") EditCustomerData(customer, "Emails");

                        }
                        else if (dataOption == 3)
                        {
                            Console.WriteLine("EMAILS");
                            Console.WriteLine("1 - Deletar Endereço");
                            Console.WriteLine("2 - Deletar Telefone");
                            Console.WriteLine("3 - Deletar Email");
                            Console.WriteLine("0 -  Voltar");
                            var operation = Console.ReadLine();
                            if (operation == "1") DeleteCustomerData(customer, "Adresses");
                            else if (operation == "2") DeleteCustomerData(customer, "Phones");
                            else if (operation == "3") DeleteCustomerData(customer, "Emails");
                        }
                    }
                    Console.WriteLine(("").PadRight(100, '-'));
                }
                Console.WriteLine();
                Console.Write("Informe o código do cliente ou 0 para sair: ");
            }
        }

        public void Create()
        {
            App.Clear();

            Console.WriteLine("Novo Cliente");
            Console.WriteLine();

            var customer = new Customer();

            Console.Write("Código (Número inteiro):");
            customer.Code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tipo de Pessoa (PF ou PJ):");
            customer.PersonType = Console.ReadLine();

            Console.Write("Nome:");
            customer.Name = Console.ReadLine();

            if (customer.PersonType?.ToUpper() == "PJ")
            {
                Console.Write("Nome Fantasia:");
                customer.Nickname = Console.ReadLine();
            }

            Console.Write("CPF/CNPJ:");
            customer.Identity = Console.ReadLine();

            if (customer.PersonType?.ToUpper() == "PF")
            {
                Console.Write("Data de Nascimento (dd/mm/aaaa):");

                while (true)
                {
                    if (DateTime.TryParseExact(
                            Console.ReadLine(),
                            "d/M/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out var dt))
                    {
                        customer.BirthDate = dt;
                        break;
                    }
                    else
                    {
                        Console.Write("Data de Nascimento inválida:");
                    }
                }
            }

            Console.WriteLine("ENDEREÇO");
            do
            {
                customer.Addresses.Add(NewAddress());
                Console.WriteLine("Deseja adicionar outro endereço? (S / N)");
            } while (Console.ReadLine().Trim().ToUpper() == "S");

            Console.WriteLine("TELEFONE");
            do
            {
                customer.Phones.Add(NewPhone());
                Console.WriteLine("Deseja adicionar outro Telefone? (S / N)");
            } while (Console.ReadLine().Trim().ToUpper() == "S");

            Console.WriteLine("EMAIL");
            do
            {
                customer.Emails.Add(NewEmail());
                Console.WriteLine("Deseja adicionar outro Email? (S / N)");
            } while (Console.ReadLine().Trim().ToUpper() == "S");

            Console.Write("Observação:");
            customer.Note = Console.ReadLine();

            customer.CreationDate = new DateTime();
            App.Customers.Add(customer);

            var customerRepository = new CustomerRepository();
            customerRepository.Save();

            Console.WriteLine();
            Console.WriteLine("Cliente cadastrado com sucesso");

            Console.WriteLine();
            Console.WriteLine("0 - Voltar");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out var action);

            while (action != 0)
            {
                Console.WriteLine("Comando inválido");
                int.TryParse(Console.ReadLine(), out action);
            }
        }

        public void Edit()
        {
            App.Clear();
            Console.WriteLine("Atualização de Cliente");
            Console.WriteLine();
            Console.Write("Informe o código do cliente ou 0 para sair: ");

            while (true)
            {
                int.TryParse(Console.ReadLine(), out var code);

                if (code == 0)
                    return;

                var customer = App.Customers.FirstOrDefault(x => x.Code == code);

                if (customer == null)
                {
                    App.Clear();
                    Console.WriteLine("Atualização de Cliente");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cliente não encontrato ou código inválido");
                    Console.ResetColor();
                }
                else
                {
                    App.Clear();
                    Console.WriteLine("Atualização de Cliente");
                    Console.WriteLine();


                    Console.WriteLine("Cliente Selecionado");
                    Console.WriteLine(("").PadRight(100, '-'));

                    Console.WriteLine("Código: {0}", customer.Code);
                    var text = Console.ReadLine();
                    if (text != "")
                        customer.Code = Convert.ToInt32(text);

                    Console.WriteLine("Nome: {0}", customer.Name);
                    text = Console.ReadLine();
                    if (text != "")
                        customer.Name = text;

                    Console.WriteLine("Tipo de Pessoa: {0}", customer.PersonType);
                    text = Console.ReadLine();
                    if (text != "")
                        customer.PersonType = text;

                    if (customer.PersonType?.ToUpper() == "PJ")
                    {
                        Console.WriteLine("Nome Fantasia:: {0}", customer.Nickname);
                        text = Console.ReadLine();
                        if (text != "")
                            customer.Nickname = text;
                    }

                    Console.WriteLine("CPF/CNPJ: {0}", customer.Identity);
                    text = Console.ReadLine();
                    if (text != "")
                        customer.Identity = text;

                    if (customer.PersonType?.ToUpper() == "PF" && customer.BirthDate != null)
                    {
                        Console.WriteLine("Data de Nascimento: {0}", ((DateTime)customer.BirthDate).ToString("dd/MM/yyyy"));
                        text = Console.ReadLine();
                        if (text != "")
                        {
                            while (true)
                            {
                                if (DateTime.TryParseExact(
                                        text,
                                        "d/M/yyyy",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out var dt))
                                {
                                    customer.BirthDate = dt;
                                    break;
                                }
                                else
                                {
                                    Console.Write("Data de Nascimento inválida:");
                                }
                            }
                        }
                    }

                    //Console.WriteLine("Endereço: {0}", customer.Address);
                    //text = Console.ReadLine();
                    //if (text != "")
                    //    customer.Address = text;

                    //Console.WriteLine("E-mail: {0}", customer.Email);
                    //text = Console.ReadLine();
                    //if (text != "")
                    //    customer.Email = text;

                    Console.WriteLine("Observação: {0}", customer.Note);
                    text = Console.ReadLine();
                    if (text != "")
                        customer.Note = text;


                    var customerRepository = new CustomerRepository();
                    customerRepository.Save();

                    Console.WriteLine();
                    Console.WriteLine("Cliente atualizado com sucesso");
                }

                Console.WriteLine();
                Console.Write("Informe o código do cliente ou 0 para sair: ");
            }
        }

        public void Delete()
        {
            App.Clear();
            Console.WriteLine("Excluir de Cliente");
            Console.WriteLine();
            Console.Write("Informe o código do cliente ou 0 para sair: ");

            while (true)
            {
                int.TryParse(Console.ReadLine(), out var code);

                if (code == 0)
                    return;

                var customer = App.Customers.FirstOrDefault(x => x.Code == code);

                if (customer == null)
                {
                    App.Clear();
                    Console.WriteLine("Excluir de Cliente");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cliente não encontrato ou código inválido");
                    Console.ResetColor();
                }
                else
                {
                    App.Clear();
                    Console.WriteLine("Excluir de Cliente");
                    Console.WriteLine();

                    Console.WriteLine(("").PadRight(100, '-'));
                    Console.WriteLine("Código: {0}", customer.Code);
                    Console.WriteLine("Nome: {0}", customer.Name);
                    Console.WriteLine(("").PadRight(100, '-'));
                    Console.WriteLine();
                    Console.Write("Deseja excluir o cliente? (S - Sim, N - Não):");
                    var result = Console.ReadLine();
                    if (result?.ToUpper() == "S")
                    {
                        App.Customers.Remove(customer);

                        var customerRepository = new CustomerRepository();
                        customerRepository.Save();

                        App.Clear();
                        Console.WriteLine("Excluir de Cliente");
                        Console.WriteLine();
                        Console.WriteLine("Cliente exluído com sucesso");
                    }
                }

                Console.WriteLine();
                Console.Write("Informe o código do cliente ou 0 para sair: ");
            }
        }

        public static Address NewAddress()
        {
            Console.Write("CEP:");
            var addressZipCode = Console.ReadLine();

            while (addressZipCode.Length != 8)
            {
                Console.WriteLine("CEP Invalido, o CEP deve ter 8 digitos. Digite novamente!");
                Console.Write("CEP:");
                addressZipCode = Console.ReadLine();
            }

            Console.WriteLine("Realizando a consulta do CEP, aguarde alguns instantes.");
            var address = ZipCodeLookup.GetAddressByZipCodeAsync(addressZipCode).Result;

            if (address.Street == null)
            {
                Console.WriteLine("Não foi possível localizar este CEP, por favor siga com o cadastro manualmente.");
                address.ZipCode = addressZipCode;
                Console.Write("Logradouro:");
                address.Street = Console.ReadLine();
                Console.Write("Número:");
                address.Number = Console.ReadLine();
                Console.Write("Complemento:");
                address.Complement = Console.ReadLine();
                Console.Write("Bairro:");
                address.District = Console.ReadLine();
                Console.Write("Cidade:");
                address.City = Console.ReadLine();
                Console.Write("Estado:");
                address.State = Console.ReadLine();
                return address;
            }

            Console.WriteLine("CEP localizado, por favor informe o número do endereço.");
            Console.Write("Número:");
            address.Number = Console.ReadLine();
            return address;
        }

        public static Phone NewPhone()
        {
            var phone = new Phone();
            Console.Write("Telefone com DDD:");
            var phoneInput = Console.ReadLine();
            while (phoneInput.Length < 10 || phoneInput.Length > 11)
            {
                Console.WriteLine("Telefone Invalido, o telefone deve ter entre 10 a 11 digitos. Digite Novamente!");
                Console.Write("Telefone com DDD:");
                phoneInput = Console.ReadLine();
            }
            phone.Ddd = Convert.ToInt32(phoneInput.Substring(0, 2));
            phone.Number = Convert.ToInt64(phoneInput.Substring(2));
            return phone;
        }

        public static Email NewEmail()
        {
            var email = new Email();
            Console.Write("Endereço de email:");
            var emailInput = Console.ReadLine();
            while (!new EmailAddressAttribute().IsValid(emailInput))
            {
                Console.WriteLine("Email invalido, digite novamente!");
                Console.Write("Endereço de email:");
                emailInput = Console.ReadLine();
            }
            email.Address = emailInput;
            return email;
        }

        public static void EditCustomerData(Customer customer, string data)
        {
            var attribute = typeof(Customer).GetProperty(data);
            var attributeValue = (IList)attribute.GetValue(customer);

            if (attributeValue.Count < 1) return;

            customer.PrintCustomerData(attribute.Name);

            Console.WriteLine("Informe o número do dado a ser editado ou 0 para voltar:");
            int.TryParse(Console.ReadLine(), out var dataIndex);

            while (dataIndex < 0 || dataIndex > attributeValue.Count)
            {
                Console.WriteLine("Opção Inválida, tente novamente.");
                Console.WriteLine("Informe o número do dado a ser editado ou 0 para voltar:");
                int.TryParse(Console.ReadLine(), out dataIndex);
            }

            if (dataIndex == 0) return;

            var customerRepository = new CustomerRepository();
            Console.WriteLine("Dado selecionado: " + attributeValue[dataIndex - 1]);

            if (attribute.Name == "Addresses") attributeValue[dataIndex - 1] = NewAddress();
            else if (attribute.Name == "Phones") attributeValue[dataIndex - 1] = NewPhone();
            else if (attribute.Name == "Email") attributeValue[dataIndex - 1] = NewEmail();

            customerRepository.Save();
            Console.WriteLine("Registro Inserido.");
        }

        public static void DeleteCustomerData(Customer customer, string data)
        {
            var attribute = typeof(Customer).GetProperty(data);
            var attributeValue = (IList)attribute.GetValue(customer);

            if (attributeValue.Count < 1) return;

            customer.PrintCustomerData(attribute.Name);

            Console.WriteLine("Informe o número do dado a ser deletado ou 0 para voltar:");
            int.TryParse(Console.ReadLine(), out var dataIndex);

            while (dataIndex < 0 || dataIndex > attributeValue.Count)
            {
                Console.WriteLine("Opção Inválida, tente novamente.");
                Console.WriteLine("Informe o número do dado a ser deletado ou 0 para voltar:");
                int.TryParse(Console.ReadLine(), out dataIndex);
            }

            if (dataIndex == 0) return;

            var customerRepository = new CustomerRepository();
            Console.WriteLine("Dado selecionado: " + attributeValue[dataIndex - 1]);
            Console.WriteLine("Essa operação irá deletar o registro acima. Você confirma a operação? (S / N)");

            if (!(Console.ReadLine().Trim().ToUpper() == "S")) return;
            if (attribute.Name == "Addresses") attributeValue.RemoveAt(dataIndex - 1);
            else if (attribute.Name == "Phones") attributeValue.RemoveAt(dataIndex - 1);
            else if (attribute.Name == "Emails") attributeValue.RemoveAt(dataIndex - 1);

            customerRepository.Save();
            Console.WriteLine("Registro deletado!");
        }
    }
}
