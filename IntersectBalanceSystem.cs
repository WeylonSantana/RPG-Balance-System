using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Controls;
using Models;

namespace IBS
{
    public partial class IntersectBalanceSystem : DarkUI.Forms.DarkForm
    {
        public IntersectBalanceSystem()
        {
            InitializeComponent();
        }

        Updating update = new Updating();

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPlyrScalStat.SelectedIndex = 0;
            cboEnyScalStat.SelectedIndex = 0;
            rdBalanced.Checked = true;
            dgvEny.Hide();
            dgvSummary.Hide();
            ControlCreate.NewDataGrid();
            update.MaxRow();
            //update.MaxRow((int)nudPlyrMaxLvl.Value, dgvEny);
            //update.MaxRow((int)nudPlyrMaxLvl.Value, dgvSummary);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update.MaxRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnPlyrGrid_Click(object sender, EventArgs e)
        {
            if (dgvEny.Visible == true || dgvSummary.Visible == true)
            {
                dgvEny.Hide();
                dgvSummary.Hide();
                dgvPlyr.Show();
            }
        }

        private void btnEnyGrid_Click(object sender, EventArgs e)
        {
            if (dgvPlyr.Visible == true || dgvSummary.Visible == true)
            {
                dgvPlyr.Hide();
                dgvSummary.Hide();
                dgvEny.Show();
            }
        }

        private void btnSummaryGrid_Click(object sender, EventArgs e)
        {
            if (dgvPlyr.Visible == true || dgvEny.Visible == true)
            {
                dgvPlyr.Hide();
                dgvEny.Hide();
                dgvSummary.Show();
            }
        }
    }
}
