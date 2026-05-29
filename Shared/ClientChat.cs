using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ClientChat
    {
        public required string Title { get; set; }
        public required int Id { get; set; }
        public required string? LastMessage { get; set; }
    }
}
