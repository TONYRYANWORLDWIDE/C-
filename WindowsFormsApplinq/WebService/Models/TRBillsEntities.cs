using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public partial class TRBillsEntities
    {
        public TRBillsEntities(string password)
            : base("name = TRBillsEntities")
        {
            this.Database.Connection.ConnectionString += $";Password = {password}";
        }

    }
}