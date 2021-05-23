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
        public void MaxRow(int end, DataGridView dataGridView)
        {
            int row = dataGridView.Rows.Count;

            if (row == end)
            {
                Cells(dataGridView);
            }
            else if (row < end)
            {
                for (int i = row; i < end; i++)
                {
                    dataGridView.Rows.Add();
                    if (i == (end - 1))
                    {
                        Cells(dataGridView);
                    }
                }
            }
            else if (row > end)
            {
                for (int i = row; i > end; i--)
                {
                    DataGridViewRow r = dataGridView.Rows[end];
                    dataGridView.Rows.Remove(r);
                    if (i == (end + 1))
                    {
                        Cells(dataGridView);
                    }
                }
            }
        }

        public void Cells(DataGridView dataGridView)
        {
            int lvl = 0;
            long baseExp = (long)IntersectBalanceSystem.expBaseNum.Value;
            double gainExp = (double)IntersectBalanceSystem.expFactorNum.Value;
            int status = 0;
            int attack = (int)IntersectBalanceSystem.attackNum.Value;
            int defense = (int)IntersectBalanceSystem.defenseNum.Value;
            int magicAttack = (int)IntersectBalanceSystem.magicAttackNum.Value;
            int magicDefense = (int)IntersectBalanceSystem.magicDefenseNum.Value;
            int speed = (int)IntersectBalanceSystem.speedNum.Value;
            int hp = (int)IntersectBalanceSystem.hitPointsNum.Value;
            int stat0, stat1, stat2, stat3, stat4;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                int cell = -1;
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = lvl = lvl + 1;                                                          //Level
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Exp(lvl, baseExp, gainExp);                                   //Exp
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat0 = Calculate.Status(status, attack, i, "Attack") + status;                 //Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat1 = Calculate.Status(status, defense, i, "Defense") + status;               //Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat2 = Calculate.Status(status, magicAttack, i, "MagicAttack") + status;       //Magic Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat3 = Calculate.Status(status, magicDefense, i, "MagicDefense") + status;     //Magic Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat4 = Calculate.Status(status, speed, i, "Speed") + status;                   //Speed
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = hp;                                                                     //Hit Points

                //Calculations must be done before updating the values
                int dmg0 = Calculate.Damage("Dmg0", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg1 = Calculate.Damage("Dmg1", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg2 = Calculate.Damage("Dmg2", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg3 = Calculate.Damage("Dmg3", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg4 = Calculate.Damage("Dmg4", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg5 = Calculate.Damage("Dmg5", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg6 = Calculate.Damage("Dmg6", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);
                int dmg7 = Calculate.Damage("Dmg7", stat0, stat1, stat2, stat3, stat4, 0.975, 1.025);

                dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg0} - {dmg1}";                                                     //Hit Points
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg2} - {dmg3}";                                                     //Hit Points
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg4} - {dmg5}";                                                     //Hit Points
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg6} - {dmg7}";                                                     //Hit Points
            }
        }
    }
}
