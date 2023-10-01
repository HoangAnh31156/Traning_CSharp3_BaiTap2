using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCSharp3_BT2.Controllers.Repositories;
using TrainingCSharp3_BT2.Models.DomainClass;

namespace TrainingCSharp3_BT2.Controllers.Services
{
    internal class SachService
    {
        SachRepository _repos;
        public SachService()
        {
            _repos = new SachRepository();
        }
        public List<Sach> GetSaches(string? input)
        {
            return _repos.GetSachs(input);
        }
        public List<Nxb> GetNxbs()
        {
            return _repos.GetNxbs();
        }
        public void AddBook(Sach sach)
        {
            if (_repos.AddBook(sach))
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Fail !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(Guid id, Sach sach)
        {
            if (_repos.UpdateBook(id, sach))
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Fail !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
