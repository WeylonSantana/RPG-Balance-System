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
            gain = (gain / 100) + 1;
            return (long)Math.Floor(baseExp * Math.Pow(gain, level - 1));
        }

        public static int Exponential(double valueBase, double valueIncrease)
        {
            valueIncrease = (valueIncrease / 100) + 1;
            return (int)Math.Floor(valueBase * valueIncrease);
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

        public static int Damage(string prop, int atk, double def, int matk, int mdef, int spd, double factorMin, double factorMax, string datagrid)
        {
            int value = 0;
            double scalling = (double)IntersectBalanceSystem.scallingFactorNum.Value / 100;
            double critical = (double)IntersectBalanceSystem.criticalFactorNum.Value;
            double defenseFactor = (100 / (100 + def));
            int damageBase = 0;
            if (datagrid == "player")
            {
                damageBase = (int)IntersectBalanceSystem.baseDamageNum.Value;

            }else if (datagrid == "monster")
            {
                damageBase = (int)IntersectBalanceSystem.M_baseDamageNum.Value;
            }
            switch (IntersectBalanceSystem.scallingStatCbo.SelectedIndex)
            {
                case 0:
                    int dmg = (int)Math.Floor(damageBase + (atk * scalling));
                    switch (prop)
                    {
                        case "Dmg0":
                            value = (int)(dmg * factorMin);
                            break;
                        case "Dmg1":
                            value = (int)(dmg * factorMax);
                            break;
                        case "Dmg2":
                            value = (int)(dmg * critical * factorMin);
                            break;
                        case "Dmg3":
                            value = (int)(dmg * critical * factorMax);
                            break;
                        case "Dmg4":
                            value = (int)((dmg * factorMin) * defenseFactor);
                            break;
                        case "Dmg5":
                            value = (int)((dmg * factorMax) * defenseFactor);
                            break;
                        case "Dmg6":
                            value = (int)((dmg * critical * factorMin) * defenseFactor);
                            break;
                        case "Dmg7":
                            value = (int)((dmg * critical * factorMax) * defenseFactor);
                            break;
                    }
                    break;
                case 1:
                    dmg = (int)Math.Floor(damageBase + (def * scalling));
                    switch (prop)
                    {
                        case "Dmg0":
                            value = (int)(dmg * factorMin);
                            break;
                        case "Dmg1":
                            value = (int)(dmg * factorMax);
                            break;
                        case "Dmg2":
                            value = (int)(dmg * critical * factorMin);
                            break;
                        case "Dmg3":
                            value = (int)(dmg * critical * factorMax);
                            break;
                        case "Dmg4":
                            value = (int)((dmg * factorMin) * defenseFactor);
                            break;
                        case "Dmg5":
                            value = (int)((dmg * factorMax) * defenseFactor);
                            break;
                        case "Dmg6":
                            value = (int)((dmg * critical * factorMin) * defenseFactor);
                            break;
                        case "Dmg7":
                            value = (int)((dmg * critical * factorMax) * defenseFactor);
                            break;
                    }
                    break;
                case 2:
                    dmg = (int)Math.Floor(damageBase + (matk * scalling));
                    switch (prop)
                    {
                        case "Dmg0":
                            value = (int)(dmg * factorMin);
                            break;
                        case "Dmg1":
                            value = (int)(dmg * factorMax);
                            break;
                        case "Dmg2":
                            value = (int)(dmg * critical * factorMin);
                            break;
                        case "Dmg3":
                            value = (int)(dmg * critical * factorMax);
                            break;
                        case "Dmg4":
                            value = (int)((dmg * factorMin) * defenseFactor);
                            break;
                        case "Dmg5":
                            value = (int)((dmg * factorMax) * defenseFactor);
                            break;
                        case "Dmg6":
                            value = (int)((dmg * critical * factorMin) * defenseFactor);
                            break;
                        case "Dmg7":
                            value = (int)((dmg * critical * factorMax) * defenseFactor);
                            break;
                    }
                    break;
                case 3:
                    dmg = (int)Math.Floor(damageBase + (mdef * scalling));
                    switch (prop)
                    {
                        case "Dmg0":
                            value = (int)(dmg * factorMin);
                            break;
                        case "Dmg1":
                            value = (int)(dmg * factorMax);
                            break;
                        case "Dmg2":
                            value = (int)(dmg * critical * factorMin);
                            break;
                        case "Dmg3":
                            value = (int)(dmg * critical * factorMax);
                            break;
                        case "Dmg4":
                            value = (int)((dmg * factorMin) * defenseFactor);
                            break;
                        case "Dmg5":
                            value = (int)((dmg * factorMax) * defenseFactor);
                            break;
                        case "Dmg6":
                            value = (int)((dmg * critical * factorMin) * defenseFactor);
                            break;
                        case "Dmg7":
                            value = (int)((dmg * critical * factorMax) * defenseFactor);
                            break;
                    }
                    break;
                case 4:
                    dmg = (int)Math.Floor(damageBase + (spd * scalling));
                    switch (prop)
                    {
                        case "Dmg0":
                            value = (int)(dmg * factorMin);
                            break;
                        case "Dmg1":
                            value = (int)(dmg * factorMax);
                            break;
                        case "Dmg2":
                            value = (int)(dmg * critical * factorMin);
                            break;
                        case "Dmg3":
                            value = (int)(dmg * critical * factorMax);
                            break;
                        case "Dmg4":
                            value = (int)((dmg * factorMin) * defenseFactor);
                            break;
                        case "Dmg5":
                            value = (int)((dmg * factorMax) * defenseFactor);
                            break;
                        case "Dmg6":
                            value = (int)((dmg * critical * factorMin) * defenseFactor);
                            break;
                        case "Dmg7":
                            value = (int)((dmg * critical * factorMax) * defenseFactor);
                            break;
                    }
                    break;
            }
            return value;
        }
    }
}
