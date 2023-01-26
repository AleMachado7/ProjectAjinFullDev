using System.IO;
using System.Reflection.Emit;
using System.Text;

namespace Xpto.Core.Shared.Entities
{
    public class Phone
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Ddd { get; set; }
        public long Number { get; set; }
        public string Note { get; set; }

        public Phone()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Ddd > 0) sb.Append($"({Ddd})");
            if (Number > 0)
            {;
                var fullNumber = Number.ToString();
                var lastDigits = fullNumber.Substring(fullNumber.Length - 4);
                var index = fullNumber.IndexOf(lastDigits);
                var firstDigits = (index < 0) ? "" : fullNumber.Remove(index, lastDigits.Length);
                sb.Append($" {firstDigits}-{lastDigits}");
            }
            return sb.ToString();
        }
    }
}
