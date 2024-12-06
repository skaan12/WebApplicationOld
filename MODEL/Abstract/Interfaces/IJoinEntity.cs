using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces
{
    public interface IJoinEntity<TKey1,TKey2>
    {
        public TKey1 FirstID { get; set; }

        public TKey2 SecondID { get; set; }
    }
}
