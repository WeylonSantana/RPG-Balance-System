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

        public static DataGridView player = new DataGridView();

        public static DarkButton update = new DarkButton();

        private void Form1_Load(object sender, EventArgs e)
        {
            var updating = new Updating();
            CreatingLabels();
            CreatingNums();
            CreatingDataGrid();
            updating.MaxRow((int)maxLevelNum.Value, player);
        }

        private void CreatingLabels()
        {
            Labels.NewLabel(titleLbl, 10, 10, "Basic Character Status");
            Controls.Add(titleLbl);

            Labels.NewLabel(AttackLbl, 10, 40, "Attack:");
            Controls.Add(AttackLbl);

            Labels.NewLabel(defenseLbl, 10, 70, "Defense:");
            Controls.Add(defenseLbl);
            
            Labels.NewLabel(magicAttackLbl, 10, 100, "Magic Attack:");
            Controls.Add(magicAttackLbl);
            
            Labels.NewLabel(magicDefenseLbl, 10, 130, "Magic Defense:");
            Controls.Add(magicDefenseLbl);
            
            Labels.NewLabel(speedLbl, 10, 160, "Speed:");
            Controls.Add(speedLbl);

            Labels.NewLabel(hitPointsLbl, 10, 190, "Hit Points:");
            Controls.Add(hitPointsLbl);

            Labels.NewLabel(baseDamageLbl, 10, 220, "Base Damage:");
            Controls.Add(baseDamageLbl);
            
            Labels.NewLabel(criticalFactorLbl, 10, 250, "Critical Factor:");
            Controls.Add(criticalFactorLbl);
            
            Labels.NewLabel(scallingStatLbl, 10, 280, "Scalling Status:");
            Controls.Add(scallingStatLbl);
            
            Labels.NewLabel(scallingFactorLbl, 10, 310, "Scalling Factor:");
            Controls.Add(scallingFactorLbl);
            
            Labels.NewLabel(pointsLbl, 10, 340, "Points by Level:");
            Controls.Add(pointsLbl);
            
            Labels.NewLabel(maxPointsLbl, 10, 370, "Max Points:");
            Controls.Add(maxPointsLbl);
            
            Labels.NewLabel(maxLevelLbl, 10, 400, "Max Level:");
            Controls.Add(maxLevelLbl);
            
            Labels.NewLabel(expBaseLbl, 10, 430, "Exp Base:");
            Controls.Add(expBaseLbl);
            
            Labels.NewLabel(expFactorLbl, 10, 460, "Exp Factor:");
            Controls.Add(expFactorLbl);
        }

        private void CreatingNums()
        {
            NumericUpDowns.NewNumeric(attackNum, 100, 36, 1, 0, 32767);
            Controls.Add(attackNum);

            NumericUpDowns.NewNumeric(defenseNum, 100, 66, 1, 0, 32767);
            Controls.Add(defenseNum);

            NumericUpDowns.NewNumeric(magicAttackNum, 100, 96, 1, 0, 32767);
            Controls.Add(magicAttackNum);

            NumericUpDowns.NewNumeric(magicDefenseNum, 100, 126, 1, 0, 32767);
            Controls.Add(magicDefenseNum);

            NumericUpDowns.NewNumeric(speedNum, 100, 156, 1, 0, 32767);
            Controls.Add(speedNum);

            NumericUpDowns.NewNumeric(hitPointsNum, 100, 186, 1, 0, 32767);
            Controls.Add(hitPointsNum);

            NumericUpDowns.NewNumeric(baseDamageNum, 100, 216, 1, 0, 32767);
            Controls.Add(baseDamageNum);

            NumericUpDowns.NewNumeric(criticalFactorNum, 100, 246, 1, 0, 1, true);
            Controls.Add(criticalFactorNum);

            scallingStatCbo.Location = new Point(100, 276);
            scallingStatCbo.Items.Insert(0, "Attack");
            scallingStatCbo.Items.Insert(1, "Defense");
            scallingStatCbo.Items.Insert(2, "Magic Attack");
            scallingStatCbo.Items.Insert(3, "Magic Defense");
            scallingStatCbo.Items.Insert(4, "Speed");
            scallingStatCbo.SelectedIndex = 0;
            Controls.Add(scallingStatCbo);

            NumericUpDowns.NewNumeric(scallingFactorNum, 100, 306, 1, 0, 1, true);
            Controls.Add(scallingFactorNum);

            NumericUpDowns.NewNumeric(pointsNum, 100, 336, 1, 0, 32767);
            Controls.Add(pointsNum);

            NumericUpDowns.NewNumeric(maxPointsNum, 100, 366, 1, 0, 32767);
            Controls.Add(maxPointsNum);

            NumericUpDowns.NewNumeric(maxLevelNum, 100, 396, 1, 0, 500);
            Controls.Add(maxLevelNum);

            NumericUpDowns.NewNumeric(expBaseNum, 100, 426, 1, 0, 32767);
            Controls.Add(expBaseNum);

            NumericUpDowns.NewNumeric(expFactorNum, 100, 456, 1, 0, 1, true);
            Controls.Add(expFactorNum);
        }

        private void CreatingDataGrid()
        {
            DataGridViews.NewDataGrid(player, 230, 36, 1110, 440, "PlayerGrid");
            Controls.Add(player);

            update.Text = "Update";
            update.Location = new Point(100, 486);
            update.MouseClick += Update_MouseClick;
            Controls.Add(update);
        }

        private void Update_MouseClick(object sender, MouseEventArgs e)
        {
            var updating = new Updating();
            updating.MaxRow((int)maxLevelNum.Value, player);
        }
    }
}
