using System.Data;
using THITHUU.Models;

namespace THITHUU
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        private NET1021_FinalContext dbContext = new NET1021_FinalContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string ThongDiep = txtThongDiep.Text;
            MessageBox.Show(ThongDiep, "Thông điệp");
        }

        private void btnLoadC1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cboLuaChon.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Ngành", typeof(string));
            dt.Columns.Add("Giới tính", typeof(bool));
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string link = "C:\\Users\\Admin\\Desktop\\data.txt";
            StreamReader sr = new StreamReader(link);
            string noidung = sr.ReadToEnd();
            txtCau2.Text = noidung;
            sr.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string link = "C:\\Users\\Admin\\Desktop\\data.txt";
            StreamWriter sw = new StreamWriter(link);
            sw.Write(txtCau2.Text);
            sw.Close();
        }

        private void btnLoadC3_Click(object sender, EventArgs e)
        {
            var sinhviens = dbContext.Sinhviens.ToList();
            int stt = 0;
            foreach (var sv in sinhviens)
            {
                stt++;
                DataRow dataRow = dt.NewRow();
                dataRow["STT"] = stt;
                dataRow["Tên"] = sv.Ten;
                dataRow["Ngành"] = sv.Nganh;
                dataRow["Giới tính"] = sv.Gioitinh;

                dt.Rows.Add(dataRow);
            }
            dgvC3.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtNganh.Text = "";
            rdoNam.Checked = true;
        }

        private void dgvC3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var donghientai = dgvC3.Rows[e.RowIndex];
            var ten = donghientai.Cells[1].Value;
            var nganh = donghientai.Cells[2].Value;
            var gioitinh = (bool)donghientai.Cells[3].Value;

            txtTen.Text = ten.ToString();
            txtNganh.Text = nganh.ToString();
            if (gioitinh == true)
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            var nganh = txtNganh.Text;
            bool gioitinh;
            if (rdoNam.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }


            var svdangthem = new Sinhvien();
            {
                svdangthem.Ten = ten;
                svdangthem.Nganh = nganh;
                svdangthem.Gioitinh = gioitinh;
            }
            dbContext.Sinhviens.Add(svdangthem);
            dbContext.SaveChanges();
        }
    }
}
