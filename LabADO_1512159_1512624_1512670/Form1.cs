using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loc dataGridView DanhSachSinhVien");
        }
    }
}
