using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormControls;
using DarkUI;
using DarkUI.Controls;
using Models;

namespace IBS
{
    public partial class IntersectBalanceSystem : DarkUI.Forms.DarkForm
    {
        public IntersectBalanceSystem()
        {
            InitializeComponent();
        }

        //Creating PlayerStatus -  Labels
        public static DarkLabel titleLbl = new DarkLabel();

        public static DarkLabel AttackLbl = new DarkLabel();
        public static DarkLabel defenseLbl = new DarkLabel();
        public static DarkLabel magicAttackLbl = new DarkLabel();
        public static DarkLabel magicDefenseLbl = new DarkLabel();
        public static DarkLabel speedLbl = new DarkLabel();

        public static DarkLabel hitPointsLbl = new DarkLabel();
        public static DarkLabel hitPointsIncreaseLbl = new DarkLabel();

        public static DarkLabel baseDamageLbl = new DarkLabel();
        public static DarkLabel criticalFactorLbl = new DarkLabel();
        public static DarkLabel scallingStatLbl = new DarkLabel();
        public static DarkLabel scallingFactorLbl = new DarkLabel();

        public static DarkLabel pointsLbl = new DarkLabel();
        public static DarkLabel maxPointsLbl = new DarkLabel();
        public static DarkLabel maxLevelLbl = new DarkLabel();

        public static DarkLabel expBaseLbl = new DarkLabel();
        public static DarkLabel expFactorLbl = new DarkLabel();

        //Creating PlayerStatus - NumericsUpDown
        public static DarkNumericUpDown attackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown defenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown magicAttackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown magicDefenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown speedNum = new DarkNumericUpDown();

        public static DarkNumericUpDown hitPointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown hitPointsIncreaseNum = new DarkNumericUpDown();

        public static DarkNumericUpDown baseDamageNum = new DarkNumericUpDown();
        public static DarkNumericUpDown criticalFactorNum = new DarkNumericUpDown();
        public static DarkComboBox scallingStatCbo = new DarkComboBox();
        public static DarkNumericUpDown scallingFactorNum = new DarkNumericUpDown();

        public static DarkNumericUpDown pointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown maxPointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown maxLevelNum = new DarkNumericUpDown();

        public static DarkNumericUpDown expBaseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown expFactorNum = new DarkNumericUpDown();

        //Creating PlayerStatus - Others
        public static DataGridView playerGrid = new DataGridView();

        public static DarkButton updateBtn = new DarkButton();
        public static DarkButton playerGridBtn = new DarkButton();

        public static DarkCheckBox balancedBox = new DarkCheckBox();
        public static DarkCheckBox strongBox = new DarkCheckBox();
        public static DarkCheckBox tankBox = new DarkCheckBox();

        //Creating MonsterStatus - Labels
        public static DarkLabel M_titleLbl = new DarkLabel();

        public static DarkLabel M_AttackLbl = new DarkLabel();
        public static DarkLabel M_defenseLbl = new DarkLabel();
        public static DarkLabel M_magicAttackLbl = new DarkLabel();
        public static DarkLabel M_magicDefenseLbl = new DarkLabel();
        public static DarkLabel M_speedLbl = new DarkLabel();

        public static DarkLabel M_hitPointsLbl = new DarkLabel();
        public static DarkLabel M_hitPointsIncreaseLbl = new DarkLabel();

        public static DarkLabel M_baseDamageLbl = new DarkLabel();
        public static DarkLabel M_criticalFactorLbl = new DarkLabel();
        public static DarkLabel M_scallingStatLbl = new DarkLabel();
        public static DarkLabel M_scallingFactorLbl = new DarkLabel();

        public static DarkLabel M_pointsLbl = new DarkLabel();
        public static DarkLabel M_maxPointsLbl = new DarkLabel();
        public static DarkLabel M_maxLevelLbl = new DarkLabel();

        //Creating MonsterStatusNumerics
        public static DarkNumericUpDown M_attackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_defenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_magicAttackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_magicDefenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_speedNum = new DarkNumericUpDown();

        public static DarkNumericUpDown M_hitPointsIncreaseNum = new DarkNumericUpDown();

        public static DarkNumericUpDown M_baseDamageNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_criticalFactorNum = new DarkNumericUpDown();
        public static DarkComboBox M_scallingStatCbo = new DarkComboBox();
        public static DarkNumericUpDown M_scallingFactorNum = new DarkNumericUpDown();

        public static DarkNumericUpDown M_pointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_maxPointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown M_maxLevelNum = new DarkNumericUpDown();

        //Creating MonsterStatus - Others
        public static DataGridView monsterGrid = new DataGridView();

        public static DarkButton monsterGridBtn = new DarkButton();

        private void Form1_Load(object sender, EventArgs e)
        {
            var updating = new Updating();
            CreatingPlayer();
            CreatingMonster();
            updating.MaxRow((int)maxLevelNum.Value, playerGrid);
            updating.MaxRow((int)maxLevelNum.Value, monsterGrid);
        }

        private void CreatingPlayer()
        {
            //Creating PlayerStatus -  Labels
            ControlCreate.NewLabel(titleLbl, 10, 10, "Basic Character Status");

            ControlCreate.NewLabel(AttackLbl, 10, 40, "Attack:");
            ControlCreate.NewLabel(defenseLbl, 225, 40, "Defense:");
            ControlCreate.NewLabel(magicAttackLbl, 10, 70, "Magic Attack:");
            ControlCreate.NewLabel(magicDefenseLbl, 225, 70, "Magic Defense:");
            ControlCreate.NewLabel(speedLbl, 10, 100, "Speed:");

            ControlCreate.NewLabel(hitPointsLbl, 225, 100, "HP Initial:");
            ControlCreate.NewLabel(hitPointsIncreaseLbl, 225, 130, "HP Inc./Lvl (%):");

            ControlCreate.NewLabel(baseDamageLbl, 10, 130, "Base Damage:");
            ControlCreate.NewLabel(criticalFactorLbl, 225, 190, "Critical (%):");
            ControlCreate.NewLabel(scallingStatLbl, 10, 160, "Scalling Status:");
            ControlCreate.NewLabel(scallingFactorLbl, 225, 160, "Scalling (%):");

            ControlCreate.NewLabel(pointsLbl, 10, 190, "Points by Level:");
            ControlCreate.NewLabel(maxPointsLbl, 225, 220, "Max Points:");
            ControlCreate.NewLabel(maxLevelLbl, 10, 220, "Max Level:");

            ControlCreate.NewLabel(expBaseLbl, 10, 250, "Exp Base:");
            ControlCreate.NewLabel(expFactorLbl, 225, 250, "Exp Factor (%):");

            Controls.Add(titleLbl);

            Controls.Add(AttackLbl);
            Controls.Add(defenseLbl);            
            Controls.Add(magicAttackLbl);            
            Controls.Add(magicDefenseLbl);            
            Controls.Add(speedLbl);

            Controls.Add(hitPointsLbl);
            Controls.Add(hitPointsIncreaseLbl);

            Controls.Add(baseDamageLbl);
            Controls.Add(criticalFactorLbl);            
            Controls.Add(scallingStatLbl);            
            Controls.Add(scallingFactorLbl);
            
            Controls.Add(pointsLbl);            
            Controls.Add(maxPointsLbl);            
            Controls.Add(maxLevelLbl);
            
            Controls.Add(expBaseLbl);            
            Controls.Add(expFactorLbl);

            //Creating PlayerStatus - NumericsUpDown
            ControlCreate.NewNumeric(attackNum, 100, 36, 10, 0, 32767);
            ControlCreate.NewNumeric(defenseNum, 315, 36, 10, 0, 32767);
            ControlCreate.NewNumeric(magicAttackNum, 100, 66, 10, 0, 32767);
            ControlCreate.NewNumeric(magicDefenseNum, 315, 66, 10, 0, 32767);
            ControlCreate.NewNumeric(speedNum, 100, 96, 10, 0, 32767);

            ControlCreate.NewNumeric(hitPointsNum, 315, 96, 100, 0, 32767);
            ControlCreate.NewNumeric(hitPointsIncreaseNum, 315, 126, 20, 0, 100);

            ControlCreate.NewNumeric(baseDamageNum, 100, 126, 10, 0, 32767);
            ControlCreate.NewNumeric(criticalFactorNum, 315, 186, 2, 1, 5);
            ControlCreate.NewComboBox(scallingStatCbo, 100, 156);
            ControlCreate.NewNumeric(scallingFactorNum, 315, 156, 100, 0, 100);

            ControlCreate.NewNumeric(pointsNum, 100, 186, 1, 0, 32767);
            ControlCreate.NewNumeric(maxPointsNum, 315, 216, 100, 0, 32767);
            ControlCreate.NewNumeric(maxLevelNum, 100, 216, 1, 0, 500);

            ControlCreate.NewNumeric(expBaseNum, 100, 246, 100, 0, 32767);
            ControlCreate.NewNumeric(expFactorNum, 315, 246, 50, 0, 100);

            Controls.Add(attackNum);
            Controls.Add(defenseNum);
            Controls.Add(magicAttackNum);
            Controls.Add(magicDefenseNum);
            Controls.Add(speedNum);

            Controls.Add(hitPointsNum);
            Controls.Add(hitPointsIncreaseNum);

            Controls.Add(baseDamageNum);
            Controls.Add(criticalFactorNum);
            Controls.Add(scallingStatCbo);
            Controls.Add(scallingFactorNum);

            Controls.Add(pointsNum);
            Controls.Add(maxPointsNum);
            Controls.Add(maxLevelNum);

            Controls.Add(expBaseNum);
            Controls.Add(expFactorNum);

            //Creating PlayerStatus - Others
            ControlCreate.NewDataGrid(playerGrid, 450, 36, 885, 677, "PlayerGrid");
            ControlCreate.NewButton(playerGridBtn, 450, 10, 120, 25, "PlayerGrid");
            ControlCreate.NewButton(updateBtn, 315, 688, 120, 25, "Update!");
            ControlCreate.NewCheckBox(balancedBox, 70, 280, "Balanced Build");
            ControlCreate.NewCheckBox(strongBox, 200, 280, "Strong Build");
            ControlCreate.NewCheckBox(tankBox, 320, 280, "Tanker Build");

            balancedBox.Checked = true;

            updateBtn.MouseClick += Update_MouseClick;
            playerGridBtn.MouseClick += PlayerGridBtn_MouseClick;
            balancedBox.CheckedChanged += BalancedBox_CheckedChanged;
            strongBox.CheckedChanged += StrongBox_CheckedChanged;
            tankBox.CheckedChanged += TankBox_CheckedChanged;

            Controls.Add(playerGrid);
            Controls.Add(updateBtn);
            Controls.Add(balancedBox);
            Controls.Add(strongBox);
            Controls.Add(tankBox);
            Controls.Add(playerGridBtn);
        }

        private void CreatingMonster()
        {
            //Creating MonsterStatus -  Labels
            ControlCreate.NewLabel(M_titleLbl, 10, 370, "Basic Monster Status");

            ControlCreate.NewLabel(M_AttackLbl, 10, 400, "Attack (%):");
            ControlCreate.NewLabel(M_defenseLbl, 225, 400, "Defense (%):");
            ControlCreate.NewLabel(M_magicAttackLbl, 10, 430, "Magic Attack (%):");
            ControlCreate.NewLabel(M_magicDefenseLbl, 225, 430, "Magic Def. (%):");
            ControlCreate.NewLabel(M_speedLbl, 10, 460, "Speed (%):");

            ControlCreate.NewLabel(M_hitPointsIncreaseLbl, 225, 460, "HP Increase (%):");

            ControlCreate.NewLabel(M_baseDamageLbl, 10, 490, "Base Damage:");
            ControlCreate.NewLabel(M_criticalFactorLbl, 225, 520, "Critical (%):");
            ControlCreate.NewLabel(M_scallingStatLbl, 10, 520, "Scalling Status:");
            ControlCreate.NewLabel(M_scallingFactorLbl, 225, 490, "Scalling (%):");

            Controls.Add(M_titleLbl);

            Controls.Add(M_AttackLbl);
            Controls.Add(M_defenseLbl);
            Controls.Add(M_magicAttackLbl);
            Controls.Add(M_magicDefenseLbl);
            Controls.Add(M_speedLbl);

            Controls.Add(M_hitPointsLbl);
            Controls.Add(M_hitPointsIncreaseLbl);

            Controls.Add(M_baseDamageLbl);
            Controls.Add(M_criticalFactorLbl);
            Controls.Add(M_scallingStatLbl);
            Controls.Add(M_scallingFactorLbl);

            //Creating MonsterStatus - NumericsUpDown
            ControlCreate.NewNumeric(M_attackNum, 100, 396, 10, 0, 32767);
            ControlCreate.NewNumeric(M_defenseNum, 315, 396, 10, 0, 32767);
            ControlCreate.NewNumeric(M_magicAttackNum, 100, 426, 10, 0, 32767);
            ControlCreate.NewNumeric(M_magicDefenseNum, 315, 426, 10, 0, 32767);
            ControlCreate.NewNumeric(M_speedNum, 100, 456, 10, 0, 32767);

            ControlCreate.NewNumeric(M_hitPointsIncreaseNum, 315, 456, 20, 0, 100);

            ControlCreate.NewNumeric(M_baseDamageNum, 100, 486, 10, 0, 32767);
            ControlCreate.NewNumeric(M_criticalFactorNum, 315, 516, 2, 1, 5);
            ControlCreate.NewComboBox(M_scallingStatCbo, 100, 516);
            ControlCreate.NewNumeric(M_scallingFactorNum, 315, 486, 100, 0, 100);

            Controls.Add(M_attackNum);
            Controls.Add(M_defenseNum);
            Controls.Add(M_magicAttackNum);
            Controls.Add(M_magicDefenseNum);
            Controls.Add(M_speedNum);

            Controls.Add(M_hitPointsIncreaseNum);

            Controls.Add(M_baseDamageNum);
            Controls.Add(M_criticalFactorNum);
            Controls.Add(M_scallingStatCbo);
            Controls.Add(M_scallingFactorNum);

            //Creating MonsterStatus - Others
            ControlCreate.NewDataGrid(monsterGrid, 450, 36, 885, 677, "MonsterGrid");
            ControlCreate.NewButton(monsterGridBtn, 570, 10, 120, 25, "MonsterGrid");

            monsterGridBtn.MouseClick += MonsterGridBtn_MouseClick1;

            Controls.Add(monsterGrid);
            Controls.Add(monsterGridBtn);
        }

        //Player Interactions
        private void BalancedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (balancedBox.Checked == false && strongBox.Checked == false && tankBox.Checked == false)
            {
                balancedBox.Checked = true;
            }
            else if (strongBox.Checked == true)
            {
                strongBox.Checked = false;
            }
            else if (tankBox.Checked == true)
            {
                tankBox.Checked = false;
            }
        }

        private void StrongBox_CheckedChanged(object sender, EventArgs e)
        {
            if (balancedBox.Checked == false && strongBox.Checked == false && tankBox.Checked == false)
            {
                strongBox.Checked = true;
            }
            else if (balancedBox.Checked == true)
            {
                balancedBox.Checked = false;
            }
            else if (tankBox.Checked == true)
            {
                tankBox.Checked = false;
            }
        }

        private void TankBox_CheckedChanged(object sender, EventArgs e)
        {
            if (balancedBox.Checked == false && strongBox.Checked == false && tankBox.Checked == false)
            {
                tankBox.Checked = true;
            }
            else if (balancedBox.Checked == true)
            {
                balancedBox.Checked = false;
            }
            else if (strongBox.Checked == true)
            {
                strongBox.Checked = false;
            }
        }

        private void Update_MouseClick(object sender, MouseEventArgs e)
        {
            var updating = new Updating();
            updating.MaxRow((int)maxLevelNum.Value, playerGrid);
            updating.MaxRow((int)maxLevelNum.Value, monsterGrid);
        }

        private void PlayerGridBtn_MouseClick(object sender, MouseEventArgs e)
        {
            monsterGrid.Hide();
            playerGrid.Show();
        }

        private void MonsterGridBtn_MouseClick1(object sender, MouseEventArgs e)
        {
            playerGrid.Hide();
            monsterGrid.Show();
        }
    }
}
