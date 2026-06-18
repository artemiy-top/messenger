using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ClientUser
    {
        public required int Id { get; set; }
        public required string Name { get; set; }

        public override string ToString()
        {
            return $"[{this.Id}] {this.Name}";
        }
    }
}
