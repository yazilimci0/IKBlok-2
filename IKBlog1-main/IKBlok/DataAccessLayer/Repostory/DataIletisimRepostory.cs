using DataAccess.Context;
using DataAccessLayer.Interface;
using EFLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
    public class DataIletisimRepostory : IIletisimData<Iletisim>
    {
        IKBlokContex IKBlokContex = new IKBlokContex();
        public void add(Iletisim iletisim)
        {
            IKBlokContex.Add(iletisim);
            IKBlokContex.SaveChanges();
        }

        public List<Iletisim> getAllList()
        {
            return IKBlokContex.Set<Iletisim>()
               .ToList();

        }

        public void remove(int id)
        {
           IKBlokContex.Remove(id);
            IKBlokContex.SaveChanges();
        }

        public void update(Iletisim iletisim)
        {
            IKBlokContex.Update(iletisim);
            IKBlokContex.SaveChanges(); 
        }
    }
}
