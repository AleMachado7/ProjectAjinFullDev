using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpto.Core.Shared.Entities.Addresses;
using Xpto.Core.Shared.Entities.Emails;
using Xpto.Repositories.Shared.Sql;

namespace Xpto.Repositories.Emails
{
    public class EmailsRepository : IEmailRepository
    {
        private readonly SqlConnectionProvider _connectionProvider;

        public EmailsRepository(SqlConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public Email Insert(Email email)
        {
            var commandText = new StringBuilder()
            .AppendLine(" INSERT INTO [TB_CUSTOMER_EMAIL]")
            .AppendLine(" (")
            .AppendLine(" [id],")
            .AppendLine(" [customer_code],")
            .AppendLine(" [type],")
            .AppendLine(" [address],")
            .AppendLine(" [note]")
            .AppendLine(" )")
            .AppendLine(" VALUES")
            .AppendLine(" (")
            .AppendLine(" @id,")
            .AppendLine(" @customer_code,")
            .AppendLine(" @type,")
            .AppendLine(" @address,")
            .AppendLine(" @note")
            .AppendLine(" )");

            using var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(email, cm);

            cm.ExecuteNonQuery();

            return email;
        }

        public int Delete(Guid id)
        {
            var commandText = new StringBuilder()
            .AppendLine(" DELETE FROM [TB_CUSTOMER_EMAIL]")
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

        public List<Email> Get(int customerCode)
        {
            var emails = new List<Email>();

            var commandText = new StringBuilder()
                .AppendLine(" SELECT")
                .AppendLine(" E.[id],")
                .AppendLine(" E.[customer_code],")
                .AppendLine(" E.[type],")
                .AppendLine(" E.[address],")
                .AppendLine(" E.[note]")
                .AppendLine(" FROM [TB_CUSTOMER_EMAIL] AS E")
                .AppendLine(" WHERE [customer_code] = @customer_code");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);

            connection.Open();

            var cm = connection.CreateCommand();

            cm.Parameters.Add(new SqlParameter("@customer_code", customerCode));

            cm.CommandText = commandText.ToString();

            var dataReader = cm.ExecuteReader();

            while (dataReader.Read())
            {
                var email = LoadDataReader(dataReader);

                emails.Add(email);
            }

            return emails;
        }

        public void Update(Email email)
        {
            var commandText = new StringBuilder()
            .AppendLine(" UPDATE [TB_CUSTOMER_EMAIL]")
            .AppendLine(" SET")
            .AppendLine(" [type] = @type,")
            .AppendLine(" [address] = @address,")
            .AppendLine(" [note] = @note")
            .AppendLine(" WHERE [id] = @id");

            var connection = new SqlConnection(this._connectionProvider.ConnectionString);
            connection.Open();

            var cm = connection.CreateCommand();

            cm.CommandText = commandText.ToString();

            this.SetParameters(email, cm);

            cm.ExecuteNonQuery();

            connection.Close();
        }

        private void SetParameters(Email email, SqlCommand cm)
        {
            cm.Parameters.Add(new SqlParameter("@id", email.Id.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@customer_code", email.CustomerCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@type", email.Type.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@address", email.Address.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@note", email.Note.GetDbValue()));
        }

        private static Email LoadDataReader(SqlDataReader dataReader)
        {
            var email = new Email();

            email.Id = dataReader.GetGuid("id");
            email.CustomerCode = dataReader.GetInt32("customer_code");
            email.Type = dataReader.GetString("type");
            email.Address = dataReader.GetString("address");
            email.Note = dataReader.GetString("note");

            return email;
        }
    }
}
