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
        DBContext _db;
        public SachRepository()
        {
            _db = new DBContext();
        }
        public List<Sach> GetSaches(string input)
        {
            if(input == null)
            {
                return _db.Saches.ToList();
            }
            return _db.Saches.Where(x=>x.Ten.Trim().ToLower().Contains(input.ToLower())).ToList();
        }
        public List<Nxb> GetNxbs()
        {
            return _db.Nxbs.ToList();   
        }
        public bool AddBook(Sach sach)
        {
            if (sach == null)
                return false;
            sach.Id = Guid.NewGuid();
            _db.Saches.Add(sach);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateBook(Guid id,Sach sach) 
        {
            var temp = _db.Saches.FirstOrDefault(x=>x.Id == id);
            if (temp == null || sach == null)
                return false;
            temp.Ten = sach.Ten;
            temp.Ma = sach.Ma;
            temp.Trangthai = sach.Trangthai;
            temp.Idnxb = sach.Idnxb;
            _db.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
