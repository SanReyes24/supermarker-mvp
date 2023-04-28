using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ISellModelRepository
    {
        void Add(SellModel sellModel);
        void Edit(SellModel sellModel);
        void Delete(int id);
        IEnumerable<SellModel> GetAll();
        IEnumerable<SellModel> GetByValue(string value);

    }
}
