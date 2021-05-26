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
using Microsoft.Office.Interop.Excel;
using System.IO;

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
            //Export file to txt
            using (TextWriter tw = new StreamWriter("plyrgrid.txt"))
            {
                for (int i = 0; i < dgvPlyr.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPlyr.Columns.Count; j++)
                    {
                        tw.Write($"{dgvPlyr.Rows[i].Cells[j].Value.ToString()}");
                        if (!(j == dgvPlyr.Columns.Count - 1))
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
            using (TextWriter tw = new StreamWriter("enygrid.txt"))
            {
                for (int i = 0; i < dgvEny.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvEny.Columns.Count; j++)
                    {
                        tw.Write($"{dgvEny.Rows[i].Cells[j].Value.ToString()}");
                        if (!(j == dgvEny.Columns.Count - 1))
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
            using (TextWriter tw = new StreamWriter("summarygrid.txt"))
            {
                for (int i = 0; i < dgvSummary.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSummary.Columns.Count; j++)
                    {
                        tw.Write($"{dgvSummary.Rows[i].Cells[j].Value.ToString()}");
                        if (!(j == dgvSummary.Columns.Count - 1))
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
            DarkUI.Forms.DarkMessageBox.ShowInformation("The tables were saved to the executable location.", "Save Tables");
            //Export file to excel
            //Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            //xcelApp.Application.Workbooks.Add(Type.Missing);

            //for (int i = 1; i < dgvPlyr.Columns.Count + 1; i++)
            //{
            //    xcelApp.Cells[1, i] = dgvPlyr.Columns[i - 1].HeaderText;    
            //}

            //for (int i = 0; i < dgvPlyr.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dgvPlyr.Columns.Count; j++)
            //    {
            //        xcelApp.Cells[i + 2, j + 1] = dgvPlyr.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //xcelApp.Columns.AutoFit();
            //xcelApp.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvPlyr.Rows.Remove(dgvPlyr.CurrentRow);
            dgvEny.Rows.Remove(dgvEny.CurrentRow);
            dgvSummary.Rows.Remove(dgvSummary.CurrentRow);
            string[] plyrlines = File.ReadAllLines("plyrgrid.txt");
            string[] plyrvalues;

            for (int i = 0; i < plyrlines.Length; i++)
            {
                plyrvalues = plyrlines[i].ToString().Split(',');
                string[] row = new string[plyrvalues.Length];

                for (int j = 0; j < plyrvalues.Length; j++)
                {
                    row[j] = plyrvalues[j].Trim();
                }
                dgvPlyr.Rows.Add(row);
            }

            string[] enylines = File.ReadAllLines("enygrid.txt");
            string[] enyvalues;

            for (int i = 0; i < enylines.Length; i++)
            {
                enyvalues = enylines[i].ToString().Split(',');
                string[] row = new string[enyvalues.Length];

                for (int j = 0; j < enyvalues.Length; j++)
                {
                    row[j] = enyvalues[j].Trim();
                }
                dgvEny.Rows.Add(row);
            }

            string[] summarylines = File.ReadAllLines("summarygrid.txt");
            string[] summaryvalues;

            for (int i = 0; i < summarylines.Length; i++)
            {
                summaryvalues = summarylines[i].ToString().Split(',');
                string[] row = new string[summaryvalues.Length];

                for (int j = 0; j < summaryvalues.Length; j++)
                {
                    row[j] = summaryvalues[j].Trim();
                }
                dgvSummary.Rows.Add(row);
            }
            DarkUI.Forms.DarkMessageBox.ShowInformation("Tables Loaded.", "Load Tables");
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
