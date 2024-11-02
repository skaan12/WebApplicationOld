using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interface
{
    public interface IBaseEntity<T>
    {
        public int ID { get; set; }

        #region Created Properties
        public DateTime CreatedDate { get; set; }

        public string ComputerName { get; set; }

        public string CreatedIpAdress { get; set; }



        #endregion

        #region Modified Properties

        public DateTime? UpdatedTime { get; set; }

        public string? UpdatedComputerName { get; set; }

        public string? UpdatedIpAdress { get; set ; }

        #endregion

        public DataStatus Status { get; set; }
    }
}
