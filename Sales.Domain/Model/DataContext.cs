using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Model
{
    public class DataContext : DbContext
    {
        //cagranos contrusctor a esta clase
        public DataContext():base("DefaultConnection") {

        }
    }
}
