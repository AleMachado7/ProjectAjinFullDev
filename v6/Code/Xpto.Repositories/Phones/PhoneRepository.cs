using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;
using Xpto.Core.Shared.Entities.Phones;
using Xpto.Repositories.Shared.Sql;

namespace Xpto.Repositories.Phones
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly SqlConnectionProvider _connectionProvider;

        public PhoneRepository(SqlConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public Phone Insert(Phone phone)
        {
            var commandText = new StringBuilder()
            .AppendLine(" INSERT INTO [TB_CUSTOMER_PHONE]")
            .AppendLine(" (")
            .AppendLine(" [id],")
            .AppendLine(" [customer_code],")
            .AppendLine(" [type],")
            .AppendLine(" [ddd],")
            .AppendLine(" [number],")
            .AppendLine(" [note]")
            .AppendLine(" )")
            .AppendLine(" VALUES")
            .AppendLine(" (")
            .AppendLine(" @id,")
            .AppendLine(" @customer_code,")
            .AppendLine(" @type,")
            .AppendLine(" @ddd,")
            .AppendLine(" @number,")
            .AppendLine(" @note")
            .AppendLine(" )");

            using var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(phone, cm);

            cm.ExecuteNonQuery();

            return phone;
        }

        public int Delete(Guid id)
        {
            var commandText = new StringBuilder()
            .AppendLine(" DELETE FROM [TB_CUSTOMER_PHONE]")
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

        public List<Phone> Get(int customerCode)
        {
            var phones = new List<Phone>();

            var commandText = new StringBuilder()
                .AppendLine(" SELECT")
                .AppendLine(" P.[id],")
                .AppendLine(" P.[customer_code],")
                .AppendLine(" P.[type],")
                .AppendLine(" P.[ddd],")
                .AppendLine(" P.[number],")
                .AppendLine(" P.[note]")
                .AppendLine(" FROM [TB_CUSTOMER_PHONE] AS P")
                .AppendLine(" WHERE [customer_code] = @customer_code");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.Parameters.Add(new SqlParameter("@customer_code", customerCode));

            cm.CommandText = commandText.ToString();

            var dataReader = cm.ExecuteReader();

            while (dataReader.Read())
            {
                var phone = LoadDataReader(dataReader);

                phones.Add(phone);
            }

            return phones;
        }

        public void Update(Phone phone)
        {
            var commandText = new StringBuilder()
            .AppendLine(" UPDATE [TB_CUSTOMER_PHONE]")
            .AppendLine(" SET")
            .AppendLine(" [type] = @type,")
            .AppendLine(" [ddd] = @ddd,")
            .AppendLine(" [number] = @number,")
            .AppendLine(" [note] = @note")
            .AppendLine(" WHERE [id] = @id");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);
            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(phone, cm);

            cm.ExecuteNonQuery();

            connection.Close();
        }

        private void SetParameters(Phone phone, SqlCommand cm)
        {
            cm.Parameters.Add(new SqlParameter("@id", phone.Id.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@customer_code", phone.CustomerCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@type", phone.Type.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@ddd", phone.Ddd.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@number", phone.Number.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@note", phone.Note.GetDbValue()));
        }

        private static Phone LoadDataReader(SqlDataReader dataReader)
        {
            var phone = new Phone();

            phone.Id = dataReader.GetGuid("id");
            phone.CustomerCode = dataReader.GetInt32("customer_code");
            phone.Type = dataReader.GetString("type");
            phone.Ddd = dataReader.GetInt32("ddd");
            phone.Number = dataReader.GetInt64("number");
            phone.Note = dataReader.GetString("note");

            return phone;
        }
    }
}
