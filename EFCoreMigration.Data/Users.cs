using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreMigration.Data
{
    public class Users : EntityBase
    {

        public  string UserName { get; set; }

        public int UserNo { get; set; }

        public string Password { get; set; }
    }
}
