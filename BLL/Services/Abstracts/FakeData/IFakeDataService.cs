using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstracts.FakeData
{
    public interface IFakeDataService<T> where T : BaseEntity
    {
         Task AddFakeDataAsync(int count);//Method for adding fake data.
    }
}
