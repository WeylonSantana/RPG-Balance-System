using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using NCalc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBS.Classes
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
        /// <param name="scalingStat">Get the value of Properties.PlyrScalingStat which will be the value of CboScalingStat.SelectedIndex</param>
        /// <param name="statusName">To compare with scalingStat and add in the right status</param>
        /// <param name="statusBase">What status should the points be added</param>
        /// <param name="row">Row index of datagridview</param>
        /// <returns></returns>
        public static int Points(int scalingStat, string statusName, int statusBase, int row)
        {
            int points = 0;
            if(Properties.Balanced == true)
            {
                points = (Properties.PlyrPoints / 5) * row;
                statusBase = statusBase + points;
            }
            else if(Properties.Strong == true)
            {
                points = (Properties.PlyrPoints * row);
                if (scalingStat == 0 && statusName == "atk")
                {
                    statusBase = statusBase + points;
                }
                if(scalingStat == 1 && statusName == "def")
                {
                    statusBase = statusBase + points;
                }
                if(scalingStat == 2 && statusName == "matk")
                {
                    statusBase = statusBase + points;
                }
                if(scalingStat == 3 && statusName == "mdef")
                {
                    statusBase = statusBase + points;
                }
                if(scalingStat == 4 && statusName == "spd")
                {
                    statusBase = statusBase + points;
                }
            }
            else if(Properties.Tanker == true)
            {
                points = (Properties.PlyrPoints * row);
                if (statusName == "def")
                {
                    statusBase = statusBase + points;
                }
            }
            if (statusBase > Properties.PlyrMaxPoints)
            {
                statusBase = Properties.PlyrMaxPoints;
            }
            return statusBase;
        }

        /// <summary>
        /// This function calculates damage
        /// </summary>
        /// <param name="attackerGrid">Attacker's DataGridView</param>
        /// <param name="victmimGrid">Victmin's DataGridView</param>
        /// <param name="row">Current row</param>
        /// <param name="type">Damage Type</param>
        /// <param name="baseDamage">Attacker's Base Damage</param>
        /// <param name="scalingStat">Attacker's scaling Stat</param>
        /// <param name="scalingFactor">Attacker's Scaling Factor</param>
        /// <returns></returns>
        public static int Damage(
            DataGridView attackerGrid,
            DataGridView victmimGrid,
            int row,
            string type,
            int baseDamage,
            int scalingStat,
            double scalingFactor
        )
        {
            switch (scalingStat)
            {
                case 0:
                    scalingStat = (int)attackerGrid.Rows[row].Cells[2].Value;
                    break;
                case 1:
                    scalingStat = (int)attackerGrid.Rows[row].Cells[3].Value;
                    break;
                case 2:
                    scalingStat = (int)attackerGrid.Rows[row].Cells[4].Value;
                    break;
                case 3:
                    scalingStat = (int)attackerGrid.Rows[row].Cells[5].Value;
                    break;
                case 4:
                    scalingStat = (int)attackerGrid.Rows[row].Cells[6].Value;
                    break;
            }

            string expressionString = null;
            switch (type)
            {
                case "MinTrue":
                    expressionString = Properties.MinTrueFormula;
                    break;
                case "MaxTrue":
                    expressionString = Properties.MaxTrueFormula;
                    break;
                case "MinReal":
                    expressionString = Properties.MinRealFormula;
                    break;
                case "MaxReal":
                    expressionString = Properties.MaxRealFormula;
                    break;
            }

            var expression = new Expression(expressionString);
            var negate = false;
            if (baseDamage < 0)
            {
                baseDamage = Math.Abs(baseDamage);
                negate = true;
            }

            if (expression.Parameters == null)
            {
                throw new ArgumentNullException(nameof(expression.Parameters));
            }

            try
            {
                expression.Parameters["BaseDamage"] = baseDamage;
                expression.Parameters["ScalingStat"] = scalingStat;
                expression.Parameters["ScaleFactor"] = scalingFactor;
                expression.Parameters["A_Attack"] = (int)attackerGrid.Rows[row].Cells[2].Value;
                expression.Parameters["A_Defense"] = (int)attackerGrid.Rows[row].Cells[3].Value;
                expression.Parameters["A_MagicAttack"] = (int)attackerGrid.Rows[row].Cells[4].Value;
                expression.Parameters["A_MagicDefense"] = (int)attackerGrid.Rows[row].Cells[5].Value;
                expression.Parameters["A_Speed"] = (int)attackerGrid.Rows[row].Cells[6].Value;
                expression.Parameters["V_Attack"] = (int)victmimGrid.Rows[row].Cells[2].Value;
                expression.Parameters["V_Defense"] = (int)victmimGrid.Rows[row].Cells[3].Value;
                expression.Parameters["V_MagicAttack"] = (int)victmimGrid.Rows[row].Cells[4].Value;
                expression.Parameters["V_MagicDefense"] = (int)victmimGrid.Rows[row].Cells[5].Value;
                expression.Parameters["V_Speed"] = (int)victmimGrid.Rows[row].Cells[6].Value;
                expression.EvaluateFunction += delegate (string name, FunctionArgs args)
                {
                    if (args == null)
                    {
                        throw new ArgumentNullException(nameof(args));
                    }
                };

                var result = Convert.ToDouble(expression.Evaluate());
                if (negate)
                {
                    result = -result;
                }

                return (int)Math.Round(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to evaluate damage formula", ex);
            }
        }
    }
}
