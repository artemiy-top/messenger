using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class User
    {
        private static int lastId = 0;

        public int Id { get; set; }
        public string Name { get; set; }

        public User(string Name)
        {
            this.Name = Name;
            this.Id = lastId++;
        }
    }
}
