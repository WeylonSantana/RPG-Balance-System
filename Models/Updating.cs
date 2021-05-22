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

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                int cell = -1;
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = lvl = lvl + 1;                                                          //Level
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Exp(lvl, baseExp, gainExp);                                   //Exp
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Status(status, attack, i, "Attack") + status;                 //Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Status(status, defense, i, "Defense") + status;               //Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Status(status, magicAttack, i, "MagicAttack") + status;       //Magic Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Status(status, magicDefense, i, "MagicDefense") + status;     //Magic Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = Calculate.Status(status, speed, i, "Speed") + status;                   //Speed
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = hp;                                                                     //Hit Points
            }
        }
    }
}
