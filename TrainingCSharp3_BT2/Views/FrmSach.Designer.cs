namespace TrainingCSharp3_BT2.Views
{
    partial class FrmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmbNXB = new ComboBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            rbdHetHang = new RadioButton();
            rdbConHang = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnHienThi = new Button();
            btnXoaForm = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvDSSach = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNXB);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(rbdHetHang);
            groupBox1.Controls.Add(rdbConHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbNXB
            // 
            cmbNXB.FormattingEnabled = true;
            cmbNXB.Location = new Point(130, 174);
            cmbNXB.Name = "cmbNXB";
            cmbNXB.Size = new Size(280, 28);
            cmbNXB.TabIndex = 8;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(130, 85);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(280, 27);
            txtMa.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(130, 39);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(280, 27);
            txtTen.TabIndex = 6;
            // 
            // rbdHetHang
            // 
            rbdHetHang.AutoSize = true;
            rbdHetHang.Location = new Point(319, 131);
            rbdHetHang.Name = "rbdHetHang";
            rbdHetHang.Size = new Size(91, 24);
            rbdHetHang.TabIndex = 5;
            rbdHetHang.TabStop = true;
            rbdHetHang.Text = "Hết hàng";
            rbdHetHang.UseVisualStyleBackColor = true;
            // 
            // rdbConHang
            // 
            rdbConHang.AutoSize = true;
            rdbConHang.Location = new Point(130, 130);
            rdbConHang.Name = "rdbConHang";
            rdbConHang.Size = new Size(93, 24);
            rdbConHang.TabIndex = 4;
            rdbConHang.TabStop = true;
            rdbConHang.Text = "Còn hàng";
            rdbConHang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 177);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHienThi);
            groupBox2.Controls.Add(btnXoaForm);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(520, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 238);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(6, 137);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(268, 42);
            btnHienThi.TabIndex = 3;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(6, 190);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(268, 42);
            btnXoaForm.TabIndex = 2;
            btnXoaForm.Text = "Xóa form";
            btnXoaForm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(6, 84);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(268, 42);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(268, 42);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDSSach);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(788, 204);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvDSSach
            // 
            dgvDSSach.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDSSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSach.GridColor = SystemColors.GradientActiveCaption;
            dgvDSSach.Location = new Point(0, 70);
            dgvDSSach.Name = "dgvDSSach";
            dgvDSSach.RowHeadersWidth = 51;
            dgvDSSach.RowTemplate.Height = 29;
            dgvDSSach.Size = new Size(788, 134);
            dgvDSSach.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(130, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.Size = new Size(372, 27);
            txtTimKiem.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 40);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // FrmSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 467);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSach";
            Load += FrmSach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbNXB;
        private TextBox txtMa;
        private TextBox txtTen;
        private RadioButton rbdHetHang;
        private RadioButton rdbConHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnHienThi;
        private Button btnXoaForm;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvDSSach;
        private TextBox txtTimKiem;
        private Label label5;
    }
}