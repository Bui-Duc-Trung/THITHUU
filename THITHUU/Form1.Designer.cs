namespace THITHUU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCau1 = new GroupBox();
            cboLuaChon = new ComboBox();
            label2 = new Label();
            txtThongDiep = new TextBox();
            label1 = new Label();
            btnLoadC1 = new Button();
            btnThongBao = new Button();
            grpCau2 = new GroupBox();
            txtCau2 = new TextBox();
            btnGhi = new Button();
            btnDoc = new Button();
            grpCau3 = new GroupBox();
            dgvC3 = new DataGridView();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label5 = new Label();
            txtNganh = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            btnClear = new Button();
            btnLoadC3 = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            grpCau1.SuspendLayout();
            grpCau2.SuspendLayout();
            grpCau3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvC3).BeginInit();
            SuspendLayout();
            // 
            // grpCau1
            // 
            grpCau1.Controls.Add(cboLuaChon);
            grpCau1.Controls.Add(label2);
            grpCau1.Controls.Add(txtThongDiep);
            grpCau1.Controls.Add(label1);
            grpCau1.Controls.Add(btnLoadC1);
            grpCau1.Controls.Add(btnThongBao);
            grpCau1.Location = new Point(12, 12);
            grpCau1.Name = "grpCau1";
            grpCau1.Size = new Size(437, 273);
            grpCau1.TabIndex = 0;
            grpCau1.TabStop = false;
            grpCau1.Text = "Câu 1";
            // 
            // cboLuaChon
            // 
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Location = new Point(29, 215);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(364, 33);
            cboLuaChon.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 187);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Lựa chọn";
            // 
            // txtThongDiep
            // 
            txtThongDiep.Location = new Point(29, 134);
            txtThongDiep.Name = "txtThongDiep";
            txtThongDiep.Size = new Size(364, 31);
            txtThongDiep.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 106);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 2;
            label1.Text = "Thông điệp";
            // 
            // btnLoadC1
            // 
            btnLoadC1.Location = new Point(281, 46);
            btnLoadC1.Name = "btnLoadC1";
            btnLoadC1.Size = new Size(112, 34);
            btnLoadC1.TabIndex = 1;
            btnLoadC1.Text = "Load";
            btnLoadC1.UseVisualStyleBackColor = true;
            btnLoadC1.Click += btnLoadC1_Click;
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(29, 46);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(112, 34);
            btnThongBao.TabIndex = 0;
            btnThongBao.Text = "Thông báo";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // grpCau2
            // 
            grpCau2.Controls.Add(txtCau2);
            grpCau2.Controls.Add(btnGhi);
            grpCau2.Controls.Add(btnDoc);
            grpCau2.Location = new Point(12, 294);
            grpCau2.Name = "grpCau2";
            grpCau2.Size = new Size(437, 273);
            grpCau2.TabIndex = 1;
            grpCau2.TabStop = false;
            grpCau2.Text = "Câu 2";
            // 
            // txtCau2
            // 
            txtCau2.Location = new Point(6, 81);
            txtCau2.Multiline = true;
            txtCau2.Name = "txtCau2";
            txtCau2.Size = new Size(425, 186);
            txtCau2.TabIndex = 4;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(281, 41);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(112, 34);
            btnGhi.TabIndex = 3;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(29, 41);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 34);
            btnDoc.TabIndex = 2;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // grpCau3
            // 
            grpCau3.Controls.Add(btnXoa);
            grpCau3.Controls.Add(btnSua);
            grpCau3.Controls.Add(btnThem);
            grpCau3.Controls.Add(dgvC3);
            grpCau3.Controls.Add(rdoNu);
            grpCau3.Controls.Add(rdoNam);
            grpCau3.Controls.Add(label5);
            grpCau3.Controls.Add(txtNganh);
            grpCau3.Controls.Add(label4);
            grpCau3.Controls.Add(label3);
            grpCau3.Controls.Add(txtTen);
            grpCau3.Controls.Add(btnClear);
            grpCau3.Controls.Add(btnLoadC3);
            grpCau3.Location = new Point(467, 12);
            grpCau3.Name = "grpCau3";
            grpCau3.Size = new Size(487, 555);
            grpCau3.TabIndex = 2;
            grpCau3.TabStop = false;
            grpCau3.Text = "Câu 3";
            // 
            // dgvC3
            // 
            dgvC3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvC3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvC3.Location = new Point(6, 308);
            dgvC3.Name = "dgvC3";
            dgvC3.RowHeadersWidth = 62;
            dgvC3.RowTemplate.Height = 33;
            dgvC3.Size = new Size(475, 241);
            dgvC3.TabIndex = 13;
            dgvC3.CellClick += dgvC3_CellClick;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(302, 273);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 12;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(132, 273);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 11;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 273);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 10;
            label5.Text = "Giới tính";
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(33, 215);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(344, 31);
            txtNganh.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 187);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 8;
            label4.Text = "Ngành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 7;
            label3.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(33, 134);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(344, 31);
            txtTen.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(340, 46);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLoadC3
            // 
            btnLoadC3.Location = new Point(33, 46);
            btnLoadC3.Name = "btnLoadC3";
            btnLoadC3.Size = new Size(112, 34);
            btnLoadC3.TabIndex = 4;
            btnLoadC3.Text = "Load";
            btnLoadC3.UseVisualStyleBackColor = true;
            btnLoadC3.Click += btnLoadC3_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(186, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(186, 94);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(340, 94);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 579);
            Controls.Add(grpCau3);
            Controls.Add(grpCau2);
            Controls.Add(grpCau1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpCau1.ResumeLayout(false);
            grpCau1.PerformLayout();
            grpCau2.ResumeLayout(false);
            grpCau2.PerformLayout();
            grpCau3.ResumeLayout(false);
            grpCau3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvC3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCau1;
        private Label label1;
        private Button btnLoadC1;
        private Button btnThongBao;
        private GroupBox grpCau2;
        private GroupBox grpCau3;
        private ComboBox cboLuaChon;
        private Label label2;
        private TextBox txtThongDiep;
        private TextBox txtCau2;
        private Button btnGhi;
        private Button btnDoc;
        private Button btnClear;
        private Button btnLoadC3;
        private DataGridView dgvC3;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label5;
        private TextBox txtNganh;
        private Label label4;
        private Label label3;
        private TextBox txtTen;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}
