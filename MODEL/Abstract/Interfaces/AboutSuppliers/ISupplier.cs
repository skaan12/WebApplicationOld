using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutSuppliers
{
    public interface ISupplier
    {
        public string Name { get; set; }

        public string ContactInfo { get; set; }

        public string? Adress {  get; set; }


    }
}
