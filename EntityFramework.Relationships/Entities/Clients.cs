using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Relationships.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Boolean IsMale { get; set; }
        public int AccountId { get; set; }

        //
        public ICollection<Accounts> Accounts { get; set; }
    }
}
