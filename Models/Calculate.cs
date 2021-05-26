using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBS;

namespace Models
{
    public class Calculate
    {
        public static long Exp(int level, long baseExp, double gain)
        {
            long value = (long)Math.Floor(baseExp * Math.Pow(gain, level - 1));
            return value;
        }

        /// <summary>
        /// This function is for assigning points in status
        /// </summary>
        /// <param name="Param"></param>
        /// <param name="StatusBase"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public static int Points(string Param, int StatusBase, int row)
        {
            int points = 0;
            if(IntersectBalanceSystem.rdBalanced.Checked == true)
            {
                points = ((int)IntersectBalanceSystem.nudPlyrPoints.Value / 5) * row;
                StatusBase = StatusBase + points;
            }
            else if(IntersectBalanceSystem.rdStrong.Checked == true)
            {
                points = ((int)IntersectBalanceSystem.nudPlyrPoints.Value * row);
                if (IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex == 0 && Param == "0")
                {
                    StatusBase = StatusBase + points;
                }
                if(IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex == 1 && Param == "1")
                {
                    StatusBase = StatusBase + points;
                }
                if(IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex == 2 && Param == "2")
                {
                    StatusBase = StatusBase + points;
                }
                if(IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex == 3 && Param == "3")
                {
                    StatusBase = StatusBase + points;
                }
                if(IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex == 4 && Param == "4")
                {
                    StatusBase = StatusBase + points;
                }
            }
            else if(IntersectBalanceSystem.rdTanker.Checked == true)
            {
                if (Param == "1")
                {
                    points = ((int)IntersectBalanceSystem.nudPlyrPoints.Value * row);
                    StatusBase = StatusBase + points;
                }
            }
            if (StatusBase > IntersectBalanceSystem.nudPlyrMaxPoints.Value)
            {
                StatusBase = (int)IntersectBalanceSystem.nudPlyrMaxPoints.Value;
            }
            return StatusBase;
        }

        /// <summary>
        /// This function will perform the damage calculation.
        /// </summary>
        /// <param name="Param">0 - True Damage, 1 - True Crit Damage, 2 - Real Damage, 3 - Real Crit Damage</param>
        /// <param name="GridName">Grid Name</param>
        /// <param name="Row">Grid's Row</param>
        /// <param name="BaseDamage">Base Damage</param>
        /// <param name="ScaleFactor">Scale Factor</param>
        /// <param name="Factor">Place a value to multiply the damage to generate the minimum and maximum damages.</param>
        /// <param name="Critical">Critical Value</param>
        /// <returns>Final Damage</returns>
        public static int Formula(int Param, string GridName, int Row, int BaseDamage, double ScaleFactor, double Factor, int Critical)
        {
            int value = 0;
            double ScalingStat = 0;
            int victmDef = 0;

            if(GridName == IntersectBalanceSystem.dgvPlyr.Name)
            {
                victmDef = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[3].Value;
                switch (IntersectBalanceSystem.cboPlyrScalStat.SelectedIndex)
                {
                    case 0:
                        ScalingStat = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[3].Value;
                        break;
                    case 1:
                        ScalingStat = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[4].Value;
                        break;
                    case 2:
                        ScalingStat = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[5].Value;
                        break;
                    case 3:
                        ScalingStat = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[6].Value;
                        break;
                    case 4:
                        ScalingStat = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[7].Value;
                        break;
                }
            }
            else
            {
                victmDef = (int)IntersectBalanceSystem.dgvPlyr.Rows[Row].Cells[4].Value;
                switch (IntersectBalanceSystem.cboEnyScalStat.SelectedIndex)
                {
                    case 0:
                        ScalingStat = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[2].Value;
                        break;
                    case 1:
                        ScalingStat = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[3].Value;
                        break;
                    case 2:
                        ScalingStat = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[4].Value;
                        break;
                    case 3:
                        ScalingStat = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[5].Value;
                        break;
                    case 4:
                        ScalingStat = (int)IntersectBalanceSystem.dgvEny.Rows[Row].Cells[6].Value;
                        break;
                }
            }

            //Change your combat formula here
            double dmg = (BaseDamage + (ScalingStat * ScaleFactor));
            double defFactor = (100 / (100 + (double)victmDef));

            switch (Param)
            {
                //True damage min - max
                case 0:
                    value = (int)Math.Floor((dmg * Factor));
                    break;
                //True critical damage min - max
                case 1:
                    value = (int)Math.Floor((dmg * Critical * Factor));
                    break;
                //Real damage min - max
                case 2:
                    value = (int)(Math.Floor(((dmg * Factor) * defFactor)));
                    break;
                //Real critical damage min - max
                case 3:
                    value = (int)(Math.Floor(((dmg * Critical * Factor) * defFactor)));
                    break;
            }
            return value;
        }
    }
}
