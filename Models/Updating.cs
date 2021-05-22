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
            int hp = (int)IntersectBalanceSystem.hitPointsNum.Value;
            int attack = (int)IntersectBalanceSystem.attackNum.Value;
            int defense = (int)IntersectBalanceSystem.defenseNum.Value;
            int magicAttack = (int)IntersectBalanceSystem.magicAttackNum.Value;
            int magicDefense = (int)IntersectBalanceSystem.magicDefenseNum.Value;
            int speed = (int)IntersectBalanceSystem.speedNum.Value;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                int cell = -1;
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = lvl + 1;                        //Level
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = 0;                              //Exp
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = attack;                         //Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = defense;                        //Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = magicAttack;                    //Magic Attack
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = magicDefense;                   //Magic Defense
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = speed;                          //Speed
                dataGridView.Rows[i].Cells[cell = cell + 1].Value = hp;                             //Hit Points
            }
        }
    }
}
