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
            int attack = (int)IntersectBalanceSystem.attackNum.Value;
            int defense = (int)IntersectBalanceSystem.defenseNum.Value;
            int magicAttack = (int)IntersectBalanceSystem.magicAttackNum.Value;
            int magicDefense = (int)IntersectBalanceSystem.magicDefenseNum.Value;
            int speed = (int)IntersectBalanceSystem.speedNum.Value;
            int hp = (int)IntersectBalanceSystem.hitPointsNum.Value;
            double gainHp = (double)IntersectBalanceSystem.hitPointsIncreaseNum.Value;

            long baseExp = (long)IntersectBalanceSystem.expBaseNum.Value;
            double gainExp = (double)IntersectBalanceSystem.expFactorNum.Value;

            double m_attack = (double)IntersectBalanceSystem.M_attackNum.Value;
            double m_defense = (double)IntersectBalanceSystem.M_defenseNum.Value;
            double m_magicAttack = (double)IntersectBalanceSystem.M_magicAttackNum.Value;
            double m_magicDefense = (double)IntersectBalanceSystem.M_magicDefenseNum.Value;
            double m_speed = (double)IntersectBalanceSystem.M_speedNum.Value;
            double m_hp = (double)IntersectBalanceSystem.M_hitPointsIncreaseNum.Value;

            int lvl = 0;
            int status = 0;

            int stat0, stat1, stat2, stat3, stat4;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                int cell = -1;
                //Update Player Grid
                if (dataGridView.Name == "PlayerGrid")
                {
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = lvl = lvl + 1;                                                                  //Level
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = baseExp = Calculate.Exp(lvl, baseExp, gainExp);                                 //Exp
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = hp = (int)Calculate.Exp(lvl, hp, gainHp);                                            //Hit Points
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat0 = Calculate.Status(status, attack, i, "Attack") + status;                 //Attack
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat1 = Calculate.Status(status, defense, i, "Defense") + status;               //Defense
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat2 = Calculate.Status(status, magicAttack, i, "MagicAttack") + status;       //Magic Attack
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat3 = Calculate.Status(status, magicDefense, i, "MagicDefense") + status;     //Magic Defense
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat4 = Calculate.Status(status, speed, i, "Speed") + status;                   //Speed

                    //When creating the tables, if the monster's table does not exist rows or if it exists but has no value, we will get error.
                    //The best solution I found was to set a default value when the monster grid table has not rows yet
                    int v_def;
                    if (IntersectBalanceSystem.monsterGrid.Rows.Count >= IntersectBalanceSystem.playerGrid.Rows.Count)
                    {
                        v_def = (int)IntersectBalanceSystem.monsterGrid.Rows[i].Cells[3].Value;
                    }
                    else
                    {
                        v_def = 11;
                    }
                    //Calculations must be done before updating the values
                    int dmg0 = Calculate.Damage("Dmg0", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg1 = Calculate.Damage("Dmg1", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg2 = Calculate.Damage("Dmg2", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg3 = Calculate.Damage("Dmg3", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg4 = Calculate.Damage("Dmg4", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg5 = Calculate.Damage("Dmg5", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg6 = Calculate.Damage("Dmg6", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");
                    int dmg7 = Calculate.Damage("Dmg7", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "player");

                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg0} - {dmg1}";         //Min - Max True Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg2} - {dmg3}";         //Min - Max Critical True Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg4} - {dmg5}";         //Min - Max Real Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg6} - {dmg7}";         //Min - Max Critical Real Damage
                }

                //Update Monster Grid
                if (dataGridView.Name == "MonsterGrid")
                {
                    long p_hp = Convert.ToInt32(IntersectBalanceSystem.playerGrid.Rows[i].Cells[2].Value);
                    int p_attack = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[3].Value;
                    int p_defense = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[4].Value;
                    int p_magicAttack = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[5].Value;
                    int p_magicDefense = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[6].Value;
                    int p_speed = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[7].Value;

                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = lvl = lvl + 1;                                                                   //Level
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = (int)Calculate.Exponential(p_hp, m_hp);                                         //Hit Points
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat0 = status + (int)Calculate.Exponential(p_attack, m_attack);              //Attack
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat1 = status + (int)Calculate.Exponential(p_defense, m_defense);            //Defense
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat2 = status + (int)Calculate.Exponential(p_magicAttack, m_magicAttack);    //Magic Attack
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat3 = status + (int)Calculate.Exponential(p_magicDefense, m_magicDefense);  //Magic Defense
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = stat4 = status + (int)Calculate.Exponential(p_speed, m_speed);                //Speed

                    //Calculations must be done before updating the values
                    int v_def = (int)IntersectBalanceSystem.playerGrid.Rows[i].Cells[3].Value;
                    int dmg0 = Calculate.Damage("Dmg0", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg1 = Calculate.Damage("Dmg1", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg2 = Calculate.Damage("Dmg2", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg3 = Calculate.Damage("Dmg3", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg4 = Calculate.Damage("Dmg4", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg5 = Calculate.Damage("Dmg5", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg6 = Calculate.Damage("Dmg6", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");
                    int dmg7 = Calculate.Damage("Dmg7", stat0, stat1, v_def, stat3, stat4, 0.975, 1.025, "monster");

                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg0} - {dmg1}";         //Min - Max True Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg2} - {dmg3}";         //Min - Max Critical True Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg4} - {dmg5}";         //Min - Max Real Damage
                    dataGridView.Rows[i].Cells[cell = cell + 1].Value = $"{dmg6} - {dmg7}";         //Min - Max Critical Real Damage
                }
            }
        }
    }
}
