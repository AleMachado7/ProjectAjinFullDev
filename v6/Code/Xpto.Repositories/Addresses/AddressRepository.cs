using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Customers;
using Xpto.Repositories.Shared.Sql;
using Xpto.Core.Shared.Entities.Addresses;

namespace Xpto.Repositories.Addresses
{
    public class AddressRepository : IAddressRepository
    {
        private readonly SqlConnectionProvider _connectionProvider;

        public AddressRepository(SqlConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public Address Insert(Address address)
        {
            var commandText = new StringBuilder()
            .AppendLine(" INSERT INTO [tb_customer_address]")
            .AppendLine(" (")
            .AppendLine(" [id],")
            .AppendLine(" [customer_code],")
            .AppendLine(" [type],")
            .AppendLine(" [street],")
            .AppendLine(" [number],")
            .AppendLine(" [complement],")
            .AppendLine(" [district],")
            .AppendLine(" [city],")
            .AppendLine(" [state],")
            .AppendLine(" [zip_code],")
            .AppendLine(" [note]")
            .AppendLine(" )")
            .AppendLine(" VALUES")
            .AppendLine(" (")
            .AppendLine(" @id,")
            .AppendLine(" @customer_code,")
            .AppendLine(" @type,")
            .AppendLine(" @street,")
            .AppendLine(" @number,")
            .AppendLine(" @complement,")
            .AppendLine(" @district,")
            .AppendLine(" @city,")
            .AppendLine(" @state,")
            .AppendLine(" @zip_code,")
            .AppendLine(" @note")
            .AppendLine(" )");

            using var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(address, cm);

            cm.ExecuteNonQuery();

            return address;
        }

        public int Delete(Guid id)
        {
            var commandText = new StringBuilder()
            .AppendLine(" DELETE FROM [tb_customer_address]")
            .AppendLine(" WHERE [id] = @id");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            cm.Parameters.Add(new SqlParameter("@id", id));

            var result = cm.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public List<Address> Get(int customerCode)
        {
            var adresses = new List<Address>();

            var commandText = new StringBuilder()
                .AppendLine(" SELECT")
                .AppendLine(" A.[id],")
                .AppendLine(" A.[customer_code],")
                .AppendLine(" A.[type],")
                .AppendLine(" A.[street],")
                .AppendLine(" A.[number],")
                .AppendLine(" A.[complement],")
                .AppendLine(" A.[district],")
                .AppendLine(" A.[city],")
                .AppendLine(" A.[state],")
                .AppendLine(" A.[zip_code],")
                .AppendLine(" A.[note]")
                .AppendLine(" FROM [tb_customer_address] AS A")
                .AppendLine(" WHERE [customer_code] = @customer_code");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.Parameters.Add(new SqlParameter("@customer_code", customerCode));

            cm.CommandText = commandText.ToString();

            var dataReader = cm.ExecuteReader();

            while (dataReader.Read())
            {
                var address = LoadDataReader(dataReader);

               adresses.Add(address);
            }

            return adresses;
        }

        public void Update(Address address)
        {
            var commandText = new StringBuilder()
            .AppendLine(" UPDATE [tb_customer_address]")
            .AppendLine(" SET")
            .AppendLine(" [type] = @type,")
            .AppendLine(" [street] = @street,")
            .AppendLine(" [number] = @number,")
            .AppendLine(" [complement] = @complement,")
            .AppendLine(" [district] = @district,")
            .AppendLine(" [city] = @city,")
            .AppendLine(" [state] = @state,")
            .AppendLine(" [zip_code] = @zip_code,")
            .AppendLine(" [note] = @note")
            .AppendLine(" WHERE [id] = @id");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);
            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(address, cm);

            cm.ExecuteNonQuery();

            connection.Close();
        }

        private void SetParameters(Address address, SqlCommand cm)
        {
            cm.Parameters.Add(new SqlParameter("@id", address.Id.GetDbValue()));

            cm.Parameters.Add(new SqlParameter("@customer_code", address.CustomerCode.GetDbValue()));

            if (string.IsNullOrWhiteSpace(address.Type))
                cm.Parameters.Add(new SqlParameter("@type", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@type", address.Type));

            cm.Parameters.Add(new SqlParameter("@street", address.Street.GetDbValue()));

            if (string.IsNullOrWhiteSpace(address.Number))
                cm.Parameters.Add(new SqlParameter("@number", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@number", address.Number));

            if (string.IsNullOrWhiteSpace(address.Complement))
                cm.Parameters.Add(new SqlParameter("@complement", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@complement", address.Complement));

            if (string.IsNullOrWhiteSpace(address.District))
                cm.Parameters.Add(new SqlParameter("@district", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@district", address.District));

            if (string.IsNullOrWhiteSpace(address.City))
                cm.Parameters.Add(new SqlParameter("@city", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@city", address.City));

            if (string.IsNullOrWhiteSpace(address.State))
                cm.Parameters.Add(new SqlParameter("@state", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@state", address.State));

            if (string.IsNullOrWhiteSpace(address.ZipCode))
                cm.Parameters.Add(new SqlParameter("@zip_code", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@zip_code", address.ZipCode));

            if (string.IsNullOrWhiteSpace(address.Note))
                cm.Parameters.Add(new SqlParameter("@note", DBNull.Value));
            else
                cm.Parameters.Add(new SqlParameter("@note", address.Note));
        }

        private static Address LoadDataReader(SqlDataReader dataReader)
        {
            var address = new Address();

            address.Id = dataReader.GetGuid("id");
            address.CustomerCode = dataReader.GetInt32("customer_code");
            address.Type = dataReader.GetString("type");
            address.Street = dataReader.GetString("street");
            address.Number = dataReader.GetString("number");
            address.Complement = dataReader.GetString("complement");
            address.District = dataReader.GetString("district");
            address.City = dataReader.GetString("city");
            address.State = dataReader.GetString("state");
            address.ZipCode = dataReader.GetString("zipcode");
            address.Note = dataReader.GetString("note");
 
            return address;
        }
    }
}