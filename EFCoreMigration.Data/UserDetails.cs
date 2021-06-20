using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMigration.Data
{
    public class UserDetails : EntityBase<long>
    {
        public string Email { get; set; }

        public string Address { get; set; }

    }
}
