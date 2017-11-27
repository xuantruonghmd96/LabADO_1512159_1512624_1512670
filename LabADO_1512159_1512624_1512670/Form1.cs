using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabADO_1512159_1512624_1512670
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ResetCheckTuoi()
        {
            trbrTuoiMin.Minimum = trbrTuoiMax.Minimum = 18;
            trbrTuoiMin.Maximum = trbrTuoiMax.Maximum = 60;
            trbrTuoiMin.Value = trbrTuoiMax.Value = trbrTuoiMin.Minimum;
            tbxTuoiMin.Text = "";
            tbxTuoiMax.Text = "";
            trbrTuoiMin.Enabled = false;
            trbrTuoiMax.Enabled = false;
            tbxTuoiMin.Enabled = false;
            tbxTuoiMax.Enabled = false;
        }

        private void chbxTuoi_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbxTuoi.Checked == false)
            {
                ResetCheckTuoi();
                ResetCheckTuoi();
            }
            else trbrTuoiMin.Enabled = trbrTuoiMax.Enabled = tbxTuoiMin.Enabled = tbxTuoiMax.Enabled = true;
        }

        private void trbrTuoiMin_ValueChanged(object sender, EventArgs e)
        {
            tbxTuoiMin.Text = trbrTuoiMin.Value.ToString();
            trbrTuoiMax.Minimum = trbrTuoiMin.Value;
        }

        private void trbrTuoiMax_ValueChanged(object sender, EventArgs e)
        {
            tbxTuoiMax.Text = trbrTuoiMax.Value.ToString();
            trbrTuoiMin.Maximum = trbrTuoiMax.Value;
        }

        private void chbxTen_CheckedChanged(object sender, EventArgs e)
        {
            tbxTen.Enabled = chbxTen.Checked;
        }

        private void chbxLop_CheckedChanged(object sender, EventArgs e)
        {
            cbxLop.Enabled = chbxLop.Checked;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Them lop");
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Them sinh vien");
        }

        string GetQuery()
        {
            string sQuery = " select maSV as 'Mã sinh viên', tenSV as 'Tên sinh viên', namSinh as 'Năm sinh', hocLop as 'Học lớp', diemTB as 'Điểm TB' from SinhVien ";
            string sq = "";
            if (chbxLop.Checked)
                sq = " hocLop = " + cbxLop.SelectedValue.ToString();
            if (chbxTen.Checked)
            {
                if (sq != "")
                    sq += " and ";
                sq += " tenSV like N'%" + tbxTen.Text + "%' ";
            }
            if (chbxTuoi.Checked)
            {
                string sqTuoi = "";
                if (tbxTuoiMin.Text != "")
                    sqTuoi = " YEAR(GETDATE()) - namSinh >= " + tbxTuoiMin.Text;
                if (tbxTuoiMax.Text != "")
                {
                    if (sqTuoi != "")
                        sqTuoi += " and ";
                    sqTuoi += " YEAR(GETDATE()) - namSinh <= " + tbxTuoiMax.Text;
                }
                if (sq != "" && sqTuoi != "")
                    sq += " and ";
                sq += sqTuoi;
            }

            if (sq != "")
                sQuery += " where " + sq;
            return sQuery;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Loc dataGridView DanhSachSinhVien");
            string sConnect = @"Data Source=TRUONG-DESKTOP\SQLEXPRESS;Initial Catalog=LabADO_1512159_1512624_1512670;Integrated Security=True";
            SqlConnection sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = sConnect;
            sqlConnect.Open();

            string squery = GetQuery();

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDAdap = new SqlDataAdapter(squery, sqlConnect);
            sqlDAdap.Fill(dataSet);

            if (dataSet.Tables.Count > 0)
                dgvwSV.DataSource = dataSet.Tables[0];

            sqlConnect.Close();
        }

        void LoadData()
        {
            //B0: Lay tham so
            string sConnect = @"Data Source=TRUONG-DESKTOP\SQLEXPRESS;Initial Catalog=LabADO_1512159_1512624_1512670;Integrated Security=True";

            //B1: Tao ket noi
            SqlConnection sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = sConnect;
            sqlConnect.Open();

            //B2: Viet sql
            string squeryLop = "Select idLop as 'Mã lớp', tenLop as 'Tên lớp' from LopHoc";

            //B3: chay sql
            //Neu select: dung SQLDataAdapter: luu ket qua, chua du lieu Dataset
            //tuy nhien neu 1 dong 1 cot: dung SQLCommand/ExecuteScalar() -> Chay SQL tra ve 1 gia tri
            //Neu insert/update: dung SQLCommand, goi ExecuteNoneQuery()
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDAdap = new SqlDataAdapter(squeryLop, sqlConnect);
            sqlDAdap.Fill(dataSet);

            //B4: xu ly du lieu
            if (dataSet.Tables.Count > 0)
            {
                cbxLop.DataSource = dataSet.Tables[0];
                cbxLop.DisplayMember = "Tên lớp";
                cbxLop.ValueMember = "Mã lớp";
                dgvwLop.DataSource = dataSet.Tables[0];
            }

            //B5: dong ket noi
            sqlConnect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
