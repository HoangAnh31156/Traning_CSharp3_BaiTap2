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
using System.Xml;
using TrainingCSharp3_BT2.Controllers.Services;
using TrainingCSharp3_BT2.Models.DomainClass;

namespace TrainingCSharp3_BT2.Views
{
    public partial class FrmSach : Form
    {
        SachService _service;
        Guid _idWhenClick;
        List<Guid> _idNXB = new List<Guid>();
        public FrmSach()
        {
            InitializeComponent();
            _service = new SachService();
        }
        private void FrmSach_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            foreach (var item in _service.GetNxbs())
            {
                _idNXB.Add(item.Id);
                cmbNXB.Items.Add(item.Ten);
            }
            cmbNXB.SelectedIndex = -1;
        }
        private void LoadGrid(string input)
        {
            int stt = 1;
            dgvDSSach.ColumnCount = 6;
            dgvDSSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSach.Columns[0].Name = "ID";
            dgvDSSach.Columns[0].Visible = false;
            dgvDSSach.Columns[1].Name = "STT";
            dgvDSSach.Columns[2].Name = "Mã sách";
            dgvDSSach.Columns[3].Name = "Tên sách";
            dgvDSSach.Columns[4].Name = "Nhà xuất bản";
            dgvDSSach.Columns[5].Name = "Trạng thái";
            dgvDSSach.Columns[5].Visible = false;

            dgvDSSach.Rows.Clear();
            foreach (var item in _service.GetSaches(input))
            {
                var NXB = _service.GetNxbs().FirstOrDefault(x => x.Id == item.Idnxb);
                dgvDSSach.Rows.Add(item.Id, stt++, item.Ma, item.Ten, (NXB.Ten != null ? NXB.Ten : "Buôn lậu"), item.Trangthai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                return;
            _idWhenClick = Guid.Parse(dgvDSSach.Rows[index].Cells[0].Value.ToString());
            var book = _service.GetSaches(null).FirstOrDefault(x => x.Id == _idWhenClick);
            txtTen.Text = book.Ten;
            txtMa.Text = book.Ma;
            if(book.Trangthai == true)
            {
                rdbConHang.Checked = true;
            }
            else
            {
                rdbHetHang.Checked = true;
            }
            int indexNXB = _service.GetNxbs().FindIndex(x => x.Id == book.Idnxb);
            if (indexNXB < 0)
            {
                cmbNXB.SelectedIndex = -1;
            }
            else
            {
                cmbNXB.SelectedIndex = indexNXB;
            }
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            if(CheckMa() == false)
            {
                return;
            }
            else
            {
                sach.Ma = txtMa.Text;
            }
            sach.Ten = txtTen.Text;
            if(rdbConHang.Checked )
            {
                sach.Trangthai = true;
            }
            else
            {
                sach.Trangthai = false;
            }
            sach.Idnxb = _idNXB[cmbNXB.SelectedIndex];
            _service.AddBook(sach);
            LoadGrid(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach updatebook = new Sach()
            {
                Ten = txtTen.Text,
                Ma = txtMa.Text,
            };
            if (rdbConHang.Checked)
            {
                updatebook.Trangthai = true;
            }
            else
            {
                updatebook.Trangthai = false;
            }
            updatebook.Idnxb = _idNXB[cmbNXB.SelectedIndex];

            _service.UpdateBook(_idWhenClick, updatebook);
            LoadGrid(null);
        }
        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtTen.Text = string.Empty;
            txtMa.Text = string.Empty;
            rdbConHang.Checked = true;
            cmbNXB.SelectedIndex = -1;
            txtTimKiem.Text = string.Empty;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length == 0)
            {
                LoadGrid(null);
            }
            else
            {
                LoadGrid(txtTimKiem.Text);
            }
        }
        private bool CheckMa()
        {
            if (_service.GetSaches(null).Any(x => x.Ma == txtMa.Text))
            {
                MessageBox.Show("Mã trùng !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                return false;
            }
            return true;           
        }
    }
}
