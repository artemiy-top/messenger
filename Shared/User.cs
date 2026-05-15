using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class User
    {
        private static int lastId = 0;

        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }

        public required string? SessionId { get; set; } = null;

        [SetsRequiredMembers]
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.Id = lastId++;
        }
    }
}
