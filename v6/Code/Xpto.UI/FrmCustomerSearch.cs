using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Windows.Forms;
using Xpto.Core.Customers;
using Xpto.Services.Customers;

namespace Xpto.UI
{
    public partial class FrmCustomerSearch : Form
    {
        private readonly ICustomerService _customerService;

        public FrmCustomerSearch(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            var dt = this._customerService.LoadDataTable();
            this.dgvSearch.DataSource = dt;
            this.dgvSearch.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<FrmCustomerRegister>();
            frm.Show(this);
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            var identity = this.txtSearchBoxIdentity.Text;
            var customerName = this.txtSearchBoxCustomerName.Text;
            var customerCode = this.txtSearchBoxCustomerCode.Text;

            this.LoadCustomers();
        }

    }
}
