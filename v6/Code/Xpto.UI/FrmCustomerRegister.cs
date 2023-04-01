using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Xpto.Core.Customers;
using Xpto.Core.Shared.Entities.Addresses;
using Xpto.Core.Shared.Entities.Emails;
using Xpto.Core.Shared.Entities.Phones;
using Xpto.Core.Shared.Functions;

namespace Xpto.UI
{
    public partial class FrmCustomerRegister : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAddressService _addressService;
        private readonly IEmailService _emailService;
        private readonly IPhoneService _phoneService;
        private Customer _customer = new Customer();
        private Address _address = new Address();
        private Phone _phone = new Phone();
        private Email _email = new Email();

        public FrmCustomerRegister(ICustomerService customerService, IAddressService addressService, IPhoneService phoneService, IEmailService emailService)
        {
            _customerService = customerService;
            _addressService = addressService;
            _phoneService = phoneService;
            _emailService = emailService;

            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Salvar Cliente?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                _customer.Name = this.txtName.Text;
                _customer.Nickname = this.txtNickname.Text;
                _customer.Identity = this.txtIdentity.Text;
                _customer.Note = this.txtNote.Text;
                _customer.BirthDate = GlobalFunction.GetIsoDateTime(this.dtpBirthDate.Text);
                _customer.PersonType = this.cboPersonType.Text;


                if (_customer.Code == 0)
                {
                    _customer = this._customerService.Create(_customer);
                }
                else
                {
                    _customer = this._customerService.Update(_customer);
                }


                MessageBox.Show("Cliente cadastrado com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Excluir Cliente?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Cliente inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _customerService.Delete(_customer.Code);
                    _addressService.Delete(_address.Id);
                    _emailService.Delete(_email.Id);
                    _phoneService.Delete(_phone.Id);

                    MessageBox.Show("Cliente deletado com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchZipCode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando CEP, por favor aguarde.", "Consulta de Endereço via CEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _address.ZipCode = this.txtZipCode.Text;
            _address = GlobalFunction.GetAddressByZipCode(_address.ZipCode);
            if (_address.Street == null)
            {
                MessageBox.Show("Não foi possível localizar o endereço para este CEP.\nTente novamente ou preencha os dados de forma manual!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtStreet.Text = _address.Street;
                this.txtComplement.Text = _address.Complement;
                this.txtDistrict.Text = _address.District;
                this.txtCity.Text = _address.City;
                this.cboState.Text = _address.State;

                MessageBox.Show("Endereço localizado com sucesso!\nPreencha o numero da residencial manualmente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Salvar Endereço?", "Endereço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                _address.CustomerCode = _customer.Code;
                _address.Type = cboAddressType.SelectedItem.ToString();
                _address.Street = this.txtStreet.Text;
                _address.Number = this.txtAddressNumber.Text;
                _address.Complement = this.txtComplement.Text;
                _address.District = this.txtDistrict.Text;
                _address.City = this.txtCity.Text;
                _address.State = this.cboState.SelectedItem.ToString();
                _address.ZipCode = this.txtZipCode.Text;
                _address.Note = this.txtNote.Text;

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível cadastrar um endereço sem um cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_customer.Addresses.Count == 0)
                {
                    this._addressService.Create(_address);
                    MessageBox.Show("Endereço cadastrado com sucesso!", "Endereço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Addresses.Add(_address);
                }
                else
                {
                    this._addressService.Update(_address);
                    MessageBox.Show("Endereço atualizado com sucesso!", "Endereço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Excluir Endereço?", "Endereço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }
                // melhorar
                _address = _addressService.Get(_customer.Code)[0];

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível excluir um endereço sem cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_address.Street != null)
                {
                    this._addressService.Delete(_address.Id);
                    MessageBox.Show("Endereço excluido com sucesso!", "Endereço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Addresses.Remove(_address);
                }
                else
                {
                    MessageBox.Show("Este endereço não está cadastrado, sendo assim não é possível excluí-lo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePhone_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Salvar Telefone?", "Telefone", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                int.TryParse(txtPhoneDDD.Text, out var ddd);
                int.TryParse(txtPhoneNumber.Text, out var number);

                _phone.Type = cboPhoneType.SelectedItem.ToString();
                _phone.CustomerCode = _customer.Code;
                _phone.Ddd = ddd;
                _phone.Number = number;
                _phone.Note = txtPhoneNote.Text;

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível cadastrar um telefone sem um cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_customer.Phones.Count == 0)
                {
                    this._phoneService.Create(_phone);
                    MessageBox.Show("Telefone cadastrado com sucesso!", "Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Phones.Add(_phone);
                }
                else
                {
                    this._phoneService.Update(_phone);
                    MessageBox.Show("Telefone atualizado com sucesso!", "Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Excluir Telefone?", "Telefone", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                _phone = _phoneService.Get(_customer.Code)[0];

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível excluir um telefone sem cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_phone.Number > 0)
                {
                    // melhorar
                    this._phoneService.Delete(_phone.Id);
                    MessageBox.Show("Telefone excluido com sucesso!", "Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Phones.Remove(_phone);
                }
                else
                {
                    MessageBox.Show("Este telefone não está cadastrado, sendo assim não é possível excluí-lo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Salvar Email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                _email.Type = cboEmailType.SelectedItem.ToString();
                _email.CustomerCode = _customer.Code;
                _email.Address = txtEmailAddress.Text;
                _email.Note = txtEmailNote.Text;

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível cadastrar um email sem um cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_customer.Emails.Count == 0)
                {
                    this._emailService.Create(_email);
                    MessageBox.Show("Email cadastrado com sucesso!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Emails.Add(_email);
                }
                else
                {
                    this._emailService.Update(_email);
                    MessageBox.Show("Email atualizado com sucesso!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Excluir Email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) { return; }

                _email = _emailService.Get(_customer.Code)[0];

                if (_customer.Code == 0)
                {
                    MessageBox.Show("Não é possível excluir um email sem cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_email.Address != null)
                {
                    // melhorar
                    this._emailService.Delete(_email.Id);
                    MessageBox.Show("Email excluido com sucesso!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _customer.Emails.Remove(_email);
                }
                else
                {
                    MessageBox.Show("Este email não está cadastrado, sendo assim não é possível excluí-lo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
