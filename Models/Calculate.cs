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
            gain = ((double)IntersectBalanceSystem.expFactorNum.Value / 100) + 1;
            return (long)Math.Floor(baseExp * Math.Pow(gain, level - 1));
        }

        public static int Status(int status, int stat, int row, string prop)
        {
            int points = (int)IntersectBalanceSystem.pointsNum.Value;
            int maxPoints = (int)IntersectBalanceSystem.maxPointsNum.Value;
            int r = ((points / 5) * row);

            if (IntersectBalanceSystem.balancedBox.Checked == true)
            {
                status = stat + r;
            }

            if(IntersectBalanceSystem.strongBox.Checked == true)
            {
                switch (IntersectBalanceSystem.scallingStatCbo.SelectedIndex)
                {
                    case 0:
                        if (prop == "Attack")
                        {
                            status = stat + (r * 5);
                        }
                        else
                        {
                            status = stat;
                        }
                        break;
                    case 1:
                        if (prop == "Defense")
                        {
                            status = stat + (r * 5);
                        }
                        else
                        {
                            status = stat;
                        }
                        break;
                    case 2:
                        if (prop == "MagicAttack")
                        {
                            status = stat + (r * 5);
                        }
                        else
                        {
                            status = stat;
                        }
                        break;
                    case 3:
                        if (prop == "MagicDefense")
                        {
                            status = stat + (r * 5);
                        }
                        else
                        {
                            status = stat;
                        }
                        break;
                    case 4:
                        if (prop == "Speed")
                        {
                            status = stat + (r * 5);
                        }
                        else
                        {
                            status = stat;
                        }
                        break;
                }
            }

            if (IntersectBalanceSystem.tankBox.Checked == true)
            {
                if (prop == "Defense")
                {
                    status = stat + (r * 5);
                }else
                {
                    status = stat;
                }
            }

            if (status > maxPoints)
            {
                status = maxPoints;
            }
            return status;
        }
    }
}
