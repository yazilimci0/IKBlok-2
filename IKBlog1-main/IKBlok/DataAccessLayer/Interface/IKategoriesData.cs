using EFLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IKategoriesData<Kategories>
    {
        void add(Kategories Kategorİ);
        void remove(int id);
        void update(Kategories Kategorİ);
        List<Kategories> getAllList();
    }
}
