using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xpto.Core.Shared.Entities.Addresses
{
    public class Address
    {
        public Guid Id { get; set; }
        public int CustomerCode { get; set; }
        public string? Type { get; set; }
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
        public string? Number { get; set; }
        [JsonPropertyName("complemento")]
        public string? Complement { get; set; }
        [JsonPropertyName("bairro")]
        public string? District { get; set; }
        [JsonPropertyName("localidade")]
        public string? City { get; set; }
        [JsonPropertyName("uf")]
        public string? State { get; set; }
        [JsonPropertyName("cep")]
        public string? ZipCode { get; set; }
        public string? Note { get; set; }

        public Address()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var separators = new Dictionary<string, string>
            {
                {"Number", ", "},
                {"Complement", " "},
                {"District", " - "},
                {"City", ", "},
                {"State", " - "},
                {"ZipCode", ", CEP: "}
            };

            foreach (var prop in typeof(Address).GetProperties()
                .Where(p => p.PropertyType == typeof(string)))
            {
                var value = (string)prop.GetValue(this, null);
                var isValid = !string.IsNullOrEmpty(value);

                if (isValid)
                {
                    if (sb.Length > 0) sb.Append(separators[prop.Name]);
                    sb.Append(value);
                }
            }
            return sb.ToString();
        }
    }
}
