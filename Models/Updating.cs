using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBS;

namespace Models
{
    class Updating
    {
        public void MaxRow()
        {
            int end = (int)IntersectBalanceSystem.nudPlyrMaxLvl.Value;
            int row = IntersectBalanceSystem.dgvPlyr.Rows.Count;
            if (row < end)
            {
                for (int i = row; i < end; i++)
                {
                    IntersectBalanceSystem.dgvPlyr.Rows.Add();
                    IntersectBalanceSystem.dgvEny.Rows.Add();
                    IntersectBalanceSystem.dgvSummary.Rows.Add();
                }
            }
            else if (row > end)
            {
                for (int i = row; i > end; i--)
                {
                    DataGridViewRow r = IntersectBalanceSystem.dgvPlyr.Rows[end];
                    IntersectBalanceSystem.dgvPlyr.Rows.Remove(r);
                    r = IntersectBalanceSystem.dgvEny.Rows[end];
                    IntersectBalanceSystem.dgvEny.Rows.Remove(r);
                    r = IntersectBalanceSystem.dgvSummary.Rows[end];
                    IntersectBalanceSystem.dgvSummary.Rows.Remove(r);
                }
            }
            Cells();
        }
        public void Cells()
        {
            int plyrAtk = (int)IntersectBalanceSystem.nudPlyrAtk.Value;
            int plyrDef = (int)IntersectBalanceSystem.nudPlyrDef.Value;
            int plyrMAtk = (int)IntersectBalanceSystem.nudPlyrMAtk.Value;
            int plyrMDef = (int)IntersectBalanceSystem.nudPlyrMDef.Value;
            int plyrSpd = (int)IntersectBalanceSystem.nudPlyrSpd.Value;
            long plyrExpBase = (long)IntersectBalanceSystem.nudPlyrExpBase.Value;
            long plyrHpBase = (int)IntersectBalanceSystem.nudPlyrHpBase.Value;
            double plyrExpFac = (((double)IntersectBalanceSystem.nudPlyrExpFac.Value / 100) + 1);
            double plyrHpFac = (((double)IntersectBalanceSystem.nudPlyrHpInc.Value / 100) + 1);
            int plyrBaseDmg = (int)IntersectBalanceSystem.nudPlyrBaseDmg.Value;
            double plyrScalFac = (double)IntersectBalanceSystem.nudPlyrScalFac.Value / 100;
            int plyrCrit = (int)IntersectBalanceSystem.nudPlyrCrit.Value;

            double enyAtk = (((double)IntersectBalanceSystem.nudEnyAtk.Value / 100) + 1);
            double enyDef = (((double)IntersectBalanceSystem.nudEnyDef.Value / 100) + 1);
            double enyMAtk = (((double)IntersectBalanceSystem.nudEnyMAtk.Value / 100) + 1);
            double enyMDef = (((double)IntersectBalanceSystem.nudEnyMDef.Value / 100) + 1);
            double enySpd = (((double)IntersectBalanceSystem.nudEnySpd.Value / 100) + 1);
            double enyHp = (((double)IntersectBalanceSystem.nudEnyHp.Value / 100) + 1);
            int enyBaseDmg = (int)IntersectBalanceSystem.nudEnyBaseDmg.Value;
            double enyScalFac = (double)IntersectBalanceSystem.nudEnyScalFac.Value / 100;
            int enyCrit = (int)IntersectBalanceSystem.nudEnyCrit.Value;

            int lvl = 0;

            for (int i = 0; i < IntersectBalanceSystem.dgvPlyr.Rows.Count; i++)
            {
                //Updating player grid values
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[0].Value = lvl = (lvl + 1);                                 //Level
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[1].Value = Calculate.Exp(lvl, plyrExpBase, plyrExpFac);     //Exp
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[2].Value = (int)Calculate.Exp(lvl, plyrHpBase, plyrHpFac);       //Hit Points
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[3].Value = Calculate.Points("0", plyrAtk, i);               //Attack
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[4].Value = Calculate.Points("1", plyrDef, i);               //Defense
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[5].Value = Calculate.Points("2", plyrMAtk, i);              //Magic Attack
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[6].Value = Calculate.Points("3", plyrMDef, i);              //Magic Defense
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[7].Value = Calculate.Points("4", plyrSpd, i);               //Speed
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[3].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[4].Value * enyDef);       //Def from Enemy for calculate

                //Calculations must be done before updating the cell values
                int dmg0 = Calculate.Formula(0, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 0.975, plyrCrit);
                int dmg1 = Calculate.Formula(0, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 1.025, plyrCrit);
                int dmg2 = Calculate.Formula(1, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 0.975, plyrCrit);
                int dmg3 = Calculate.Formula(1, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 1.025, plyrCrit);
                int dmg4 = Calculate.Formula(2, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 0.975, plyrCrit);
                int dmg5 = Calculate.Formula(2, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 1.025, plyrCrit);
                int dmg6 = Calculate.Formula(3, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 0.975, plyrCrit);
                int dmg7 = Calculate.Formula(3, IntersectBalanceSystem.dgvPlyr.Name, i, plyrBaseDmg, plyrScalFac, 1.025, plyrCrit);

                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[8].Value = $"{dmg0} - {dmg1}";          //Min - Max True Damage
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[9].Value = $"{dmg2} - {dmg3}";          //Min - Max Critical True Damage
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[10].Value = $"{dmg4} - {dmg5}";         //Min - Max Real Damage
                IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[11].Value = $"{dmg6} - {dmg7}";         //Min - Max Critical Real Damage

                //Updating enemy grid values
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[0].Value = lvl;                                                                             //Level
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[1].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[2].Value * enyHp);       //Hit Points
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[2].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[3].Value * enyAtk);      //Attack
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[4].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[5].Value * enyMAtk);     //Magic Attack
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[5].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[6].Value * enyMDef);     //Magic Defense
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[6].Value = (int)((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[7].Value * enySpd);      //Speed

                //Calculations must be done before updating the cell values
                int dmg8 = Calculate.Formula(0, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 0.975, enyCrit);
                int dmg9 = Calculate.Formula(0, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 1.025, enyCrit);
                int dmg10 = Calculate.Formula(1, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 0.975, enyCrit);
                int dmg11 = Calculate.Formula(1, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 1.025, enyCrit);
                int dmg12 = Calculate.Formula(2, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 0.975, enyCrit);
                int dmg13 = Calculate.Formula(2, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 1.025, enyCrit);
                int dmg14 = Calculate.Formula(3, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 0.975, enyCrit);
                int dmg15 = Calculate.Formula(3, IntersectBalanceSystem.dgvEny.Name, i, enyBaseDmg, enyScalFac, 1.025, enyCrit);

                IntersectBalanceSystem.dgvEny.Rows[i].Cells[7].Value = $"{dmg8} - {dmg9}";           //Min - Max True Damage
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[8].Value = $"{dmg10} - {dmg11}";         //Min - Max Critical True Damage
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[9].Value = $"{dmg12} - {dmg13}";         //Min - Max Real Damage
                IntersectBalanceSystem.dgvEny.Rows[i].Cells[10].Value = $"{dmg14} - {dmg15}";        //Min - Max Critical Real Damage

                //Updating summary grid values
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[0].Value = lvl;
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[1].Value = $"{((int)IntersectBalanceSystem.dgvEny.Rows[i].Cells[1].Value / dmg0)}";
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[2].Value = $"{((int)IntersectBalanceSystem.dgvEny.Rows[i].Cells[1].Value / dmg4)}";
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[3].Value = lvl;
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[4].Value = $"{((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[2].Value / dmg8)}";
                IntersectBalanceSystem.dgvSummary.Rows[i].Cells[5].Value = $"{((int)IntersectBalanceSystem.dgvPlyr.Rows[i].Cells[2].Value / dmg12)}";
            }
        }
    }
}
