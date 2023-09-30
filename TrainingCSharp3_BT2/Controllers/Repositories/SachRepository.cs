using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCSharp3_BT2.Models.Context;
using TrainingCSharp3_BT2.Models.DomainClass;

namespace TrainingCSharp3_BT2.Controllers.Repositories
{
    internal class SachRepository
    {
        DBContext _DBcontext;

        public SachRepository()
        {
            _DBcontext = new DBContext();
        }

        public List<Sach> GetSachs(string? input)
        {
            if (input == null)
            {
                return _DBcontext.Saches.ToList();
            }
            return _DBcontext.Saches.Where(x => x.Ten.Trim().ToLower().Contains(input.ToLower())).ToList();
        }

        public List<Nxb> GetNxbs()
        {
            return _DBcontext.Nxbs.ToList();
        }

        public bool AddBook(Sach sach)
        {
            if (sach == null)
                return false;
            sach.Id = Guid.NewGuid();
            _DBcontext.Saches.Add(sach);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool UpdateBook(Guid id, Sach sach)
        {
            var temp = _DBcontext.Saches.FirstOrDefault(x => x.Id == id);
            if (temp == null || sach == null)
                return false;
            temp.Ten = sach.Ten;
            temp.Ma = sach.Ma;
            temp.TrangThai = sach.TrangThai;
            temp.IdNxb = sach.IdNxb;

            _DBcontext.Update(temp);
            _DBcontext.SaveChanges();
            return true;
        }

    }
}
