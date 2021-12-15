using Entity.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Template : BaseEntity
    {
        public string Name { get; set; }
        //public Guid Foreignid
        //public virtual Relation relation
        //public virtual List<Relation> relations
    }
}
