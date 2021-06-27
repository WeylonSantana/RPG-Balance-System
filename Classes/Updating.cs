using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGBalanceSystem.Classes
{
    class Updating
    {
        public static void UpdateCells(DataGridView dataGridView, int rowsCount)
        {
            int lvl = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                //Updating player grid values
                dataGridView.Rows[i].Cells[0].Value = lvl = (lvl + 1);                                                                      //Level
                dataGridView.Rows[i].Cells[1].Value = Calculate.Exp(lvl, Properties.PlyrHpBase, Properties.PlyrHpFac);                      //Hit Points
                dataGridView.Rows[i].Cells[2].Value = Calculate.Points(Properties.PlyrScalingStat, "atk", Properties.PlyrAttack, i);        //Attack
                dataGridView.Rows[i].Cells[3].Value = Calculate.Points(Properties.PlyrScalingStat, "def", Properties.PlyrDefese, i);        //Defense
                dataGridView.Rows[i].Cells[4].Value = Calculate.Points(Properties.PlyrScalingStat, "matk", Properties.PlyrMagicAttack, i);  //Magic Attack
                dataGridView.Rows[i].Cells[5].Value = Calculate.Points(Properties.PlyrScalingStat, "mdef", Properties.PlyrMagicDefense, i); //Magic Defense
                dataGridView.Rows[i].Cells[6].Value = Calculate.Points(Properties.PlyrScalingStat, "spd", Properties.PlyrSpeed, i);         //Speed
                dataGridView.Rows[i].Cells[7].Value = Calculate.Exp(lvl, Properties.PlyrExpBase, Properties.PlyrExpFac);                    //Exp

            }
        }

        public static void UpdateCells(DataGridView enyGrid, DataGridView plyrGrid, int rowsCount)
        {
            int lvl = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                //Updating enemy grid values
                enyGrid.Rows[i].Cells[0].Value = lvl = (lvl + 1);                                                                 //Level
                enyGrid.Rows[i].Cells[1].Value = (int)((long)plyrGrid.Rows[i].Cells[1].Value * Properties.EnyHpFac);         //Hit Points
                enyGrid.Rows[i].Cells[2].Value = (int)((int)plyrGrid.Rows[i].Cells[2].Value * Properties.EnyAttack);         //Attack
                enyGrid.Rows[i].Cells[3].Value = (int)((int)plyrGrid.Rows[i].Cells[3].Value * Properties.EnyDefese);         //Defense
                enyGrid.Rows[i].Cells[4].Value = (int)((int)plyrGrid.Rows[i].Cells[4].Value * Properties.EnyMagicAttack);    //Magic Attack
                enyGrid.Rows[i].Cells[5].Value = (int)((int)plyrGrid.Rows[i].Cells[5].Value * Properties.EnyMagicDefense);   //Magic Defense
                enyGrid.Rows[i].Cells[6].Value = (int)((int)plyrGrid.Rows[i].Cells[6].Value * Properties.EnySpeed);          //Speed
            }
        }

        public static void UpdateCells(DataGridView sumGrid, DataGridView plyrGrid, DataGridView enyGrid, int rowsCount)
        {
            int lvl = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                //Updating Summary grid values
                sumGrid.Rows[i].Cells[0].Value = lvl = (lvl + 1);                                                                                                                                           //Player Level
                sumGrid.Rows[i].Cells[1].Value = $"" +
                    $"{Calculate.Damage(plyrGrid, enyGrid, i, "MinTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)} - " +                                              //Player True Damage
                    $"{Calculate.Damage(plyrGrid, enyGrid, i, "MaxTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)}";                                                  //Player True Damage
                sumGrid.Rows[i].Cells[2].Value = $"" +
                    $"{Math.Round(Calculate.Damage(plyrGrid, enyGrid, i, "MinTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac) * Properties.PlyrCriticalFac, 0)} - " +  //Player Critical True Damage
                    $"{Math.Round(Calculate.Damage(plyrGrid, enyGrid, i, "MaxTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac) * Properties.PlyrCriticalFac, 0)}";      //Player Critical True Damage
                sumGrid.Rows[i].Cells[3].Value = $"" +
                    $"{Calculate.Damage(plyrGrid, enyGrid, i, "MinReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)} - " +                                              //Player Real Damage
                    $"{Calculate.Damage(plyrGrid, enyGrid, i, "MaxReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)}";                                                  //Player Real Damage
                sumGrid.Rows[i].Cells[4].Value = $"" +
                    $"{Math.Round(Calculate.Damage(plyrGrid, enyGrid, i, "MinReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac) * Properties.PlyrCriticalFac, 0)} - " +  //Player Critical Real Damage
                    $"{Math.Round(Calculate.Damage(plyrGrid, enyGrid, i, "MaxReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac) * Properties.PlyrCriticalFac, 0)}";      //Player Critical Real Damage
                sumGrid.Rows[i].Cells[5].Value = $"" +
                    $"±{(int)enyGrid.Rows[i].Cells[1].Value / Calculate.Damage(plyrGrid, enyGrid, i, "MaxTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)} - " +       //Player Hits True Damage
                    $"{(int)enyGrid.Rows[i].Cells[1].Value / Calculate.Damage(plyrGrid, enyGrid, i, "MinTrue", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)}";            //Player Critical True Damage
                sumGrid.Rows[i].Cells[6].Value = $"" +
                    $"±{(int)enyGrid.Rows[i].Cells[1].Value / Calculate.Damage(plyrGrid, enyGrid, i, "MaxReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)} - " +       //Player Hits Real Damage
                    $"{(int)enyGrid.Rows[i].Cells[1].Value / Calculate.Damage(plyrGrid, enyGrid, i, "MinReal", Properties.PlyrBaseDmg, Properties.PlyrScalingStat, Properties.PlyrScalingFac)}";            //Player Hits Real Damage

                sumGrid.Rows[i].Cells[7].Value = lvl;                                                                                                                                                       //Enemy Level
                sumGrid.Rows[i].Cells[8].Value = $"" +
                    $"{Calculate.Damage(enyGrid, plyrGrid, i, "MinTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)} - " +                                                 //Enemy True Damage
                    $"{Calculate.Damage(enyGrid, plyrGrid, i, "MaxTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)}";                                                     //Enemy True Damage
                sumGrid.Rows[i].Cells[9].Value = $"" +
                    $"{Math.Round(Calculate.Damage(enyGrid, plyrGrid, i, "MinTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac) * Properties.EnyCriticalFac, 0)} - " +      //Enemy Critical True Damage
                    $"{Math.Round(Calculate.Damage(enyGrid, plyrGrid, i, "MaxTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac) * Properties.EnyCriticalFac, 0)}";          //Enemy Critical True Damage
                sumGrid.Rows[i].Cells[10].Value = $"" +
                    $"{Calculate.Damage(enyGrid, plyrGrid, i, "MinReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)} - " +                                                 //Enemy Real Damage
                    $"{Calculate.Damage(enyGrid, plyrGrid, i, "MaxReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)}";                                                     //Enemy Real Damage
                sumGrid.Rows[i].Cells[11].Value = $"" +
                    $"{Math.Round(Calculate.Damage(enyGrid, plyrGrid, i, "MinReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac) * Properties.EnyCriticalFac, 0)} - " +      //Enemy Critical Real Damage
                    $"{Math.Round(Calculate.Damage(enyGrid, plyrGrid, i, "MaxReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac) * Properties.EnyCriticalFac, 0)}";          //Enemy Critical Real Damage
                sumGrid.Rows[i].Cells[12].Value = $"" +
                    $"±{(long)plyrGrid.Rows[i].Cells[1].Value / Calculate.Damage(enyGrid, plyrGrid, i, "MaxTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)} - " +         //Enemy Hits True Damage
                    $"{(long)plyrGrid.Rows[i].Cells[1].Value / Calculate.Damage(enyGrid, plyrGrid, i, "MinTrue", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)}";              //Enemy Critical True Damage
                sumGrid.Rows[i].Cells[13].Value = $"" +
                    $"±{(long)plyrGrid.Rows[i].Cells[1].Value / Calculate.Damage(enyGrid, plyrGrid, i, "MaxReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)} - " +         //Enemy Hits Real Damage
                    $"{(long)plyrGrid.Rows[i].Cells[1].Value / Calculate.Damage(enyGrid, plyrGrid, i, "MinReal", Properties.EnyBaseDmg, Properties.EnyScalingStat, Properties.EnyScalingFac)}";              //Enemy Hits Real Damage

            }
        }
    }
}
