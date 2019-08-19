using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
    class BbContext:DbContext
    {
        public BbContext():base("")
        {

        }
    }
}
