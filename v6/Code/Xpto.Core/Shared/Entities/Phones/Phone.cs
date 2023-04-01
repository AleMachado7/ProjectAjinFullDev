using System.IO;
using System.Reflection.Emit;
using System.Text;

namespace Xpto.Core.Shared.Entities.Phones
{
    public class Phone
    {
        public Guid Id { get; set; }
        public int CustomerCode { get; set; }
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
            if (Ddd > 0 && Number > 0)
            {
                sb.Append(Ddd.ToString("(##)"));
                sb.Append(" ");
                sb.Append(Number.ToString("#####-####"));
            }
            return sb.ToString();
        }
    }
}
