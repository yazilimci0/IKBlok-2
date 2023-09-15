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
    public class DataKategoriRepostory : IKategoriesData<Kategories>
    {

        IKBlokContex IKBlokContex = new IKBlokContex();
        public void add(Kategories Kategori)
        {

            IKBlokContex.Add(Kategori);
            IKBlokContex.SaveChanges();
        }


        public List<Kategories> getAllList()
        {
            return IKBlokContex.Set<Kategories>()
               .ToList();

        }

        public void remove(int id)
        {
            IKBlokContex.Remove(id);
            IKBlokContex.SaveChanges(); 
        }

        public void update(Kategories Kategorİ)
        {
            IKBlokContex.Update(Kategorİ);
            IKBlokContex.SaveChanges();
        }

    }
}
    

