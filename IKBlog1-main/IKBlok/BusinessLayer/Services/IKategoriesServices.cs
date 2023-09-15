using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLayer.Class;

namespace BusinessLayer.Services
{
    public interface IKategoriesServices<Kategories>
    {
        void add(Kategories Kategorİ);
        void remove(int id);
        void update(Kategories Kategorİ);
        List<Kategories> getAllList();
    }
}
