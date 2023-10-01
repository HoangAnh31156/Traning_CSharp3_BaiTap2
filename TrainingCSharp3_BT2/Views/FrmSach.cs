using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCSharp3_BT2.Controllers.Services;

namespace TrainingCSharp3_BT2.Views
{
    public partial class FrmSach : Form
    {
        SachService _service;
        List<Guid> _lstIdSach = new List<Guid>();
        Guid _idWhenClick;
        public FrmSach()
        {
            InitializeComponent();
            _service = new SachService();
        }
        private void FrmSach_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadGrid(null);
        }
        public void LoadCombobox()
        {
            foreach (var item in _service.GetNxbs())
            {
                _lstIdSach.Add(item.Id);
                cmbNXB.Items.Add(item.Ten);
            }
            cmbNXB.SelectedIndex = 0;
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dgvDSSach.ColumnCount = 5;
            dgvDSSach.AutoSizeColumnsMode  = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSach.Columns[0].Name = "ID";
            dgvDSSach.Columns[0].Visible = false;
            dgvDSSach.Columns[1].Name = "STT";
            dgvDSSach.Columns[2].Name = "Mã sách";
            dgvDSSach.Columns[3].Name = "Tên sách";
            dgvDSSach.Columns[4].Name = "Nhà xuất bản";
            dgvDSSach.Rows.Clear();
            foreach (var item in _service.GetSaches(input))
            {
                var NXB = _service.GetNxbs().FirstOrDefault(x => x.Id == item.IdNxb);
                dgvDSSach.Rows.Add(item.Id, stt++, item.Ma, item.Ten, (NXB.Ten == null ? "Sách Fa Ke" : NXB.Ten));
            }
        }
    }
}
