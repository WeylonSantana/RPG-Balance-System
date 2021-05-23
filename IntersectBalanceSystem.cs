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

        //Creating Labels
        public static DarkLabel titleLbl = new DarkLabel();
        public static DarkLabel AttackLbl = new DarkLabel();
        public static DarkLabel defenseLbl = new DarkLabel();
        public static DarkLabel magicAttackLbl = new DarkLabel();
        public static DarkLabel magicDefenseLbl = new DarkLabel();
        public static DarkLabel speedLbl = new DarkLabel();
        public static DarkLabel hitPointsLbl = new DarkLabel();
        public static DarkLabel baseDamageLbl = new DarkLabel();
        public static DarkLabel criticalFactorLbl = new DarkLabel();
        public static DarkLabel scallingStatLbl = new DarkLabel();
        public static DarkLabel scallingFactorLbl = new DarkLabel();
        public static DarkLabel pointsLbl = new DarkLabel();
        public static DarkLabel maxPointsLbl = new DarkLabel();
        public static DarkLabel maxLevelLbl = new DarkLabel();
        public static DarkLabel expBaseLbl = new DarkLabel();
        public static DarkLabel expFactorLbl = new DarkLabel();

        //Creating NumericsUpDown
        public static DarkNumericUpDown attackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown defenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown magicAttackNum = new DarkNumericUpDown();
        public static DarkNumericUpDown magicDefenseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown speedNum = new DarkNumericUpDown();
        public static DarkNumericUpDown hitPointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown baseDamageNum = new DarkNumericUpDown();
        public static DarkNumericUpDown criticalFactorNum = new DarkNumericUpDown();
        public static DarkComboBox scallingStatCbo = new DarkComboBox();
        public static DarkNumericUpDown scallingFactorNum = new DarkNumericUpDown();
        public static DarkNumericUpDown pointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown maxPointsNum = new DarkNumericUpDown();
        public static DarkNumericUpDown maxLevelNum = new DarkNumericUpDown();
        public static DarkNumericUpDown expBaseNum = new DarkNumericUpDown();
        public static DarkNumericUpDown expFactorNum = new DarkNumericUpDown();

        //Creating Others
        public static DataGridView playerGrid = new DataGridView();
        public static DarkButton updateBtn = new DarkButton();
        public static DarkCheckBox balancedBox = new DarkCheckBox();
        public static DarkCheckBox strongBox = new DarkCheckBox();
        public static DarkCheckBox tankBox = new DarkCheckBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            var updating = new Updating();
            CreatingLabels();
            CreatingNums();
            CreatingOthers();
            updating.MaxRow((int)maxLevelNum.Value, playerGrid);
        }

        private void CreatingLabels()
        {
            ControlCreate.NewLabel(titleLbl, 10, 10, "Basic Character Status");
            Controls.Add(titleLbl);

            ControlCreate.NewLabel(AttackLbl, 10, 40, "Attack:");
            Controls.Add(AttackLbl);

            ControlCreate.NewLabel(defenseLbl, 225, 40, "Defense:");
            Controls.Add(defenseLbl);
            
            ControlCreate.NewLabel(magicAttackLbl, 10, 70, "Magic Attack:");
            Controls.Add(magicAttackLbl);
            
            ControlCreate.NewLabel(magicDefenseLbl, 225, 70, "Magic Defense:");
            Controls.Add(magicDefenseLbl);
            
            ControlCreate.NewLabel(speedLbl, 10, 100, "Speed:");
            Controls.Add(speedLbl);

            ControlCreate.NewLabel(hitPointsLbl, 225, 100, "Hit Points:");
            Controls.Add(hitPointsLbl);

            ControlCreate.NewLabel(baseDamageLbl, 10, 130, "Base Damage:");
            Controls.Add(baseDamageLbl);
            
            ControlCreate.NewLabel(criticalFactorLbl, 225, 130, "Critical (%):");
            Controls.Add(criticalFactorLbl);
            
            ControlCreate.NewLabel(scallingStatLbl, 10, 160, "Scalling Status:");
            Controls.Add(scallingStatLbl);
            
            ControlCreate.NewLabel(scallingFactorLbl, 225, 160, "Scalling (%):");
            Controls.Add(scallingFactorLbl);
            
            ControlCreate.NewLabel(pointsLbl, 10, 190, "Points by Level:");
            Controls.Add(pointsLbl);
            
            ControlCreate.NewLabel(maxPointsLbl, 225, 190, "Max Points:");
            Controls.Add(maxPointsLbl);
            
            ControlCreate.NewLabel(maxLevelLbl, 10, 220, "Max Level:");
            Controls.Add(maxLevelLbl);
            
            ControlCreate.NewLabel(expBaseLbl, 225, 220, "Exp Base:");
            Controls.Add(expBaseLbl);
            
            ControlCreate.NewLabel(expFactorLbl, 10, 250, "Exp Factor (%):");
            Controls.Add(expFactorLbl);
        }

        private void CreatingNums()
        {
            ControlCreate.NewNumeric(attackNum, 100, 36, 10, 0, 32767);
            Controls.Add(attackNum);

            ControlCreate.NewNumeric(defenseNum, 315, 36, 10, 0, 32767);
            Controls.Add(defenseNum);

            ControlCreate.NewNumeric(magicAttackNum, 100, 66, 10, 0, 32767);
            Controls.Add(magicAttackNum);

            ControlCreate.NewNumeric(magicDefenseNum, 315, 66, 10, 0, 32767);
            Controls.Add(magicDefenseNum);

            ControlCreate.NewNumeric(speedNum, 100, 96, 10, 0, 32767);
            Controls.Add(speedNum);

            ControlCreate.NewNumeric(hitPointsNum, 315, 96, 100, 0, 32767);
            Controls.Add(hitPointsNum);

            ControlCreate.NewNumeric(baseDamageNum, 100, 126, 10, 0, 32767);
            Controls.Add(baseDamageNum);

            ControlCreate.NewNumeric(criticalFactorNum, 315, 126, 2, 1, 5);
            Controls.Add(criticalFactorNum);

            scallingStatCbo.Location = new Point(100, 156);
            scallingStatCbo.Items.Insert(0, "Attack");
            scallingStatCbo.Items.Insert(1, "Defense");
            scallingStatCbo.Items.Insert(2, "Magic Attack");
            scallingStatCbo.Items.Insert(3, "Magic Defense");
            scallingStatCbo.Items.Insert(4, "Speed");
            scallingStatCbo.SelectedIndex = 0;
            Controls.Add(scallingStatCbo);

            ControlCreate.NewNumeric(scallingFactorNum, 315, 156, 100, 0, 100);
            Controls.Add(scallingFactorNum);

            ControlCreate.NewNumeric(pointsNum, 100, 186, 1, 0, 32767);
            Controls.Add(pointsNum);

            ControlCreate.NewNumeric(maxPointsNum, 315, 186, 100, 0, 32767);
            Controls.Add(maxPointsNum);

            ControlCreate.NewNumeric(maxLevelNum, 100, 216, 1, 0, 500);
            Controls.Add(maxLevelNum);

            ControlCreate.NewNumeric(expBaseNum, 315, 216, 100, 0, 32767);
            Controls.Add(expBaseNum);

            ControlCreate.NewNumeric(expFactorNum, 100, 246, 50, 0, 100);
            Controls.Add(expFactorNum);
        }

        private void CreatingOthers()
        {
            ControlCreate.NewDataGrid(playerGrid, 450, 36, 885, 230, "PlayerGrid");
            Controls.Add(playerGrid);

            ControlCreate.NewButton(updateBtn, 330, 275, 120, 25, "Update!");
            updateBtn.MouseClick += Update_MouseClick;
            Controls.Add(updateBtn);

            ControlCreate.NewCheckBox(balancedBox, 10, 280, "Balanced Build");
            balancedBox.Checked = true;
            balancedBox.CheckedChanged += BalancedBox_CheckedChanged;
            Controls.Add(balancedBox);

            ControlCreate.NewCheckBox(strongBox, 115, 280, "Strong Build");
            strongBox.Checked = false;
            strongBox.CheckedChanged += StrongBox_CheckedChanged;
            Controls.Add(strongBox);

            ControlCreate.NewCheckBox(tankBox, 220, 280, "Tanker Build");
            tankBox.Checked = false;
            tankBox.CheckedChanged += TankBox_CheckedChanged;
            Controls.Add(tankBox);
        }

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
        }
    }
}
