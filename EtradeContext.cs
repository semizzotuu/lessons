using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class EtradeContext:DbContext
    {

        public DbSet<Product> Products { get; set; }//bir productım var onu entity seti olarak Products ismiyle kullanılacak tablolarda products arıyor.


    }
}
