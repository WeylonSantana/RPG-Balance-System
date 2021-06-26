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
using Microsoft.Office.Interop.Excel;
using System.IO;
using DarkUI.Forms;

namespace IBS
{
    public partial class RPGBalanceSystem : DarkUI.Forms.DarkForm
    {
        public RPGBalanceSystem()
        {
            InitializeComponent();
        }

        IBS.Classes.Updating update = new IBS.Classes.Updating();

        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
            UpdateMaxRow();
        }

        private void Setup()
        {
            Classes.Properties.PlyrLevel = (int)nudPlyrMaxLvl.Value;
            Classes.Properties.PlyrAttack = (int)nudPlyrAtk.Value;
            Classes.Properties.PlyrDefese = (int)nudPlyrDef.Value;
            Classes.Properties.PlyrMagicAttack = (int)nudPlyrMAtk.Value;
            Classes.Properties.PlyrMagicDefense = (int)nudPlyrMDef.Value;
            Classes.Properties.PlyrSpeed = (int)nudPlyrSpd.Value;
            Classes.Properties.PlyrHpBase = (int)nudPlyrHpBase.Value;
            Classes.Properties.PlyrHpFac = ((double)nudPlyrHpInc.Value / 100) + 1;
            Classes.Properties.PlyrExpBase = (int)nudPlyrExpBase.Value;
            Classes.Properties.PlyrExpFac = ((double)nudPlyrExpFac.Value / 100) + 1;
            Classes.Properties.PlyrPoints = (int)nudPlyrPoints.Value;
            Classes.Properties.PlyrMaxPoints = (int)nudPlyrMaxPoints.Value;
            Classes.Properties.PlyrBaseDmg = (int)nudPlyrBaseDmg.Value;
            Classes.Properties.PlyrScalingFac = (double)nudPlyrScalFac.Value / 100;
            Classes.Properties.PlyrCriticalFac = (double)nudPlyrCrit.Value;
            Classes.Properties.EnyAttack = ((double)nudEnyAtk.Value / 100) + 1;
            Classes.Properties.EnyDefese = ((double)nudEnyDef.Value / 100) + 1;
            Classes.Properties.EnyMagicAttack = ((double)nudEnyMAtk.Value / 100) + 1;
            Classes.Properties.EnyMagicDefense = ((double)nudEnyMDef.Value / 100) + 1;
            Classes.Properties.EnySpeed = ((double)nudEnySpd.Value / 100) + 1;
            Classes.Properties.EnyHpFac = ((double)nudEnyHp.Value / 100) + 1;
            Classes.Properties.EnyBaseDmg = (int)nudEnyBaseDmg.Value;
            Classes.Properties.EnyScalingFac = (double)nudEnyScalFac.Value / 100;
            Classes.Properties.EnyCriticalFac = (double)nudEnyCrit.Value;
            Classes.Properties.Balanced = true;
            Classes.Properties.MinTrueFormula = tbMinTrue.Text.ToString();
            Classes.Properties.MaxTrueFormula = tbMaxTrue.Text.ToString();
            Classes.Properties.MinRealFormula = tbMinReal.Text.ToString();
            Classes.Properties.MaxRealFormula = tbMaxReal.Text.ToString();
            cboPlyrScalStat.SelectedIndex = 0;
            cboEnyScalStat.SelectedIndex = 0;
            rdBalanced.Checked = true;
            dgvEny.Hide();
            dgvSummary.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Classes.Properties.PlyrScalingStat = cboPlyrScalStat.SelectedIndex;
            Classes.Properties.EnyScalingStat = cboEnyScalStat.SelectedIndex;
            Classes.Properties.MinTrueFormula = tbMinTrue.Text.ToString();
            Classes.Properties.MaxTrueFormula = tbMaxTrue.Text.ToString();
            Classes.Properties.MinRealFormula = tbMinReal.Text.ToString();
            Classes.Properties.MaxRealFormula = tbMaxReal.Text.ToString();
            if (rdBalanced.Checked == true)
            {
                Classes.Properties.Balanced = true;
                Classes.Properties.Strong = false;
                Classes.Properties.Tanker = false;

            }else if (rdStrong.Checked == true)
            {
                Classes.Properties.Balanced = false;
                Classes.Properties.Strong = true;
                Classes.Properties.Tanker = false;
            }
            else if (rdTanker.Checked == true)
            {
                Classes.Properties.Balanced = false;
                Classes.Properties.Strong = false;
                Classes.Properties.Tanker = true;
            }
            UpdateMaxRow();
        }

        public void UpdateMaxRow()
        {
            int end = Classes.Properties.PlyrLevel;
            int row = dgvPlyr.Rows.Count;
            if (row < end)
            {
                for (int i = row; i < end; i++)
                {
                    dgvPlyr.Rows.Add();
                    dgvEny.Rows.Add();
                    dgvSummary.Rows.Add();
                }
            }
            else if (row > end)
            {
                for (int i = row; i > end; i--)
                {
                    DataGridViewRow r = dgvPlyr.Rows[end];
                    dgvPlyr.Rows.Remove(r);
                    r = dgvEny.Rows[end];
                    dgvEny.Rows.Remove(r);
                    r = dgvSummary.Rows[end];
                    dgvSummary.Rows.Remove(r);
                }
            }
            Classes.Updating.UpdateCells(dgvPlyr, dgvPlyr.RowCount);
            Classes.Updating.UpdateCells(dgvEny, dgvPlyr, dgvPlyr.RowCount);
            Classes.Updating.UpdateCells(dgvSummary, dgvPlyr, dgvEny, dgvPlyr.RowCount);
        }

        private void nudPlyrMaxLvl_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrLevel = (int)nudPlyrMaxLvl.Value;
        }

        private void nudPlyrAtk_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrAttack = (int)nudPlyrAtk.Value;
        }

        private void nudPlyrDef_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrDefese = (int)nudPlyrDef.Value;
        }

        private void nudPlyrMAtk_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrMagicAttack = (int)nudPlyrMAtk.Value;
        }

        private void nudPlyrMDef_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrMagicDefense = (int)nudPlyrMDef.Value;
        }

        private void nudPlyrSpd_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrSpeed = (int)nudPlyrSpd.Value;
        }

        private void nudPlyrHpBase_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrHpBase = (int)nudPlyrHpBase.Value;
        }

        private void nudPlyrHpInc_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrHpFac = (((double)nudPlyrHpInc.Value / 100) + 1);
        }

        private void nudPlyrExpBase_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrExpBase = (int)nudPlyrExpBase.Value;
        }

        private void nudPlyrExpFac_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrExpFac = (((double)nudPlyrExpFac.Value / 100) + 1);
        }

        private void nudPlyrPoints_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrPoints = (int)nudPlyrPoints.Value;
        }

        private void nudPlyrMaxPoints_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrMaxPoints = (int)nudPlyrMaxPoints.Value;
        }

        private void nudPlyrBaseDmg_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrBaseDmg = (int)nudPlyrBaseDmg.Value;
        }

        private void nudPlyrScalFac_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrScalingFac = ((double)nudPlyrScalFac.Value / 100);
        }

        private void nudPlyrCrit_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.PlyrCriticalFac = (double)nudPlyrCrit.Value;
        }

        private void nudEnyAtk_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyAttack = (((double)nudEnyAtk.Value / 100) + 1);
        }

        private void nudEnyDef_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyDefese = (((double)nudEnyDef.Value / 100) + 1);
        }

        private void nudEnyMAtk_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyMagicAttack = (((double)nudEnyMAtk.Value / 100) + 1);
        }

        private void nudEnyMDef_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyMagicDefense = (((double)nudEnyMDef.Value / 100) + 1);
        }

        private void nudEnySpd_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnySpeed = (((double)nudEnySpd.Value / 100) + 1);
        }

        private void nudEnyHp_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyHpFac = (((double)nudEnyHp.Value / 100) + 1);
        }

        private void nudEnyBaseDmg_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyBaseDmg = (int)nudEnyBaseDmg.Value;
        }

        private void nudEnyScalFac_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyScalingFac = (double)nudEnyScalFac.Value / 100;
        }

        private void nudEnyCrit_ValueChanged(object sender, EventArgs e)
        {
            Classes.Properties.EnyCriticalFac = (double)nudEnyCrit.Value;
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
            }

            dgvPlyr.Show();
        }

        private void btnEnyGrid_Click(object sender, EventArgs e)
        {
            if (dgvPlyr.Visible == true || dgvSummary.Visible == true)
            {
                dgvPlyr.Hide();
                dgvSummary.Hide();
            }

            dgvEny.Show();
        }

        private void btnSummaryGrid_Click(object sender, EventArgs e)
        {
            if (dgvPlyr.Visible == true || dgvEny.Visible == true)
            {
                dgvPlyr.Hide();
                dgvEny.Hide();
            }

            dgvSummary.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowInformation("Accepted values:\n\n BaseDamage, ScalingStat, ScaleFactor \n A_Attack ---------- V_Attack \n A_Defense --------- V_Defense \n A_MagicAttack ---- V_MagicAttack \n A_MagicDefense -- V_MagicDefense, \n A_Speed ----------- V_Speed \n The amount of rows in the tables is defined by the maximum level of the player.", "Balancing System Information");
        }
    }
}
