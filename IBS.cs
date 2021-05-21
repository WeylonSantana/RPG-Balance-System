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

namespace IBS
{
    public partial class IBS : DarkUI.Forms.DarkForm
    {
        public IBS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreatingLabels();
            CreatingNums();
        }

        private void CreatingLabels()
        {
            DarkLabel titleLbl = new DarkLabel();
            Labels.NewLabel(titleLbl, "Basic Character Status", 10, 10);
            Controls.Add(titleLbl);

            DarkLabel AttackLbl = new DarkLabel();
            Labels.NewLabel(AttackLbl, "Attack:", 10, 40);
            Controls.Add(AttackLbl);

            DarkLabel defenseLbl = new DarkLabel();
            Labels.NewLabel(defenseLbl, "Defense:", 10, 70);
            Controls.Add(defenseLbl);
            
            DarkLabel magicAttackLbl = new DarkLabel();
            Labels.NewLabel(magicAttackLbl, "Magic Attack:", 10, 100);
            Controls.Add(magicAttackLbl);
            
            DarkLabel magicDefenseLbl = new DarkLabel();
            Labels.NewLabel(magicDefenseLbl, "Magic Defense:", 10, 130);
            Controls.Add(magicDefenseLbl);
            
            DarkLabel speedLbl = new DarkLabel();
            Labels.NewLabel(speedLbl, "Speed:", 10, 160);
            Controls.Add(speedLbl);

            DarkLabel hitPointsLbl = new DarkLabel();
            Labels.NewLabel(hitPointsLbl, "Hit Points:", 10, 190);
            Controls.Add(hitPointsLbl);

            DarkLabel baseDamageLbl = new DarkLabel();
            Labels.NewLabel(baseDamageLbl, "Base Damage:", 10, 220);
            Controls.Add(baseDamageLbl);
            
            DarkLabel scallingStatLbl = new DarkLabel();
            Labels.NewLabel(scallingStatLbl, "Scalling Status:", 10, 250);
            Controls.Add(scallingStatLbl);
            
            DarkLabel scallingFactorLbl = new DarkLabel();
            Labels.NewLabel(scallingFactorLbl, "Scalling Factor:", 10, 280);
            Controls.Add(scallingFactorLbl);
            
            DarkLabel pointsLbl = new DarkLabel();
            Labels.NewLabel(pointsLbl, "Points by Level:", 10, 310);
            Controls.Add(pointsLbl);
            
            DarkLabel maxPointsLbl = new DarkLabel();
            Labels.NewLabel(maxPointsLbl, "Max Points:", 10, 340);
            Controls.Add(maxPointsLbl);
            
            DarkLabel maxLevelLbl = new DarkLabel();
            Labels.NewLabel(maxLevelLbl, "Max Level:", 10, 370);
            Controls.Add(maxLevelLbl);
            
            DarkLabel expBaseLbl = new DarkLabel();
            Labels.NewLabel(expBaseLbl, "Exp Base:", 10, 400);
            Controls.Add(expBaseLbl);
            
            DarkLabel expFactorLbl = new DarkLabel();
            Labels.NewLabel(expFactorLbl, "Exp Factor:", 10, 430);
            Controls.Add(expFactorLbl);
        }

        private void CreatingNums()
        {
            //Creating NumericsUpDown
            DarkNumericUpDown attackNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(attackNum, 100, 36, 1, 0, 32767);
            Controls.Add(attackNum);

            DarkNumericUpDown defenseNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(defenseNum, 100, 66, 1, 0, 32767);
            Controls.Add(defenseNum);

            DarkNumericUpDown magicAttackNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(magicAttackNum, 100, 96, 1, 0, 32767);
            Controls.Add(magicAttackNum);

            DarkNumericUpDown magicDefenseNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(magicDefenseNum, 100, 126, 1, 0, 32767);
            Controls.Add(magicDefenseNum);

            DarkNumericUpDown speedNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(speedNum, 100, 156, 1, 0, 32767);
            Controls.Add(speedNum);

            DarkNumericUpDown hitPointsNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(hitPointsNum, 100, 186, 1, 0, 32767);
            Controls.Add(hitPointsNum);

            DarkNumericUpDown baseDamageNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(baseDamageNum, 100, 216, 1, 0, 32767);
            Controls.Add(baseDamageNum);

            DarkNumericUpDown scallingStatNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(scallingStatNum, 100, 246, 1, 0, 32767);
            Controls.Add(scallingStatNum);

            DarkNumericUpDown scallingFactorNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(scallingFactorNum, 100, 276, 1, 0, 32767);
            Controls.Add(scallingFactorNum);

            DarkNumericUpDown pointsNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(pointsNum, 100, 306, 1, 0, 32767);
            Controls.Add(pointsNum);

            DarkNumericUpDown maxPointsNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(maxPointsNum, 100, 336, 1, 0, 32767);
            Controls.Add(maxPointsNum);

            DarkNumericUpDown maxLevelNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(maxLevelNum, 100, 366, 1, 0, 32767);
            Controls.Add(maxLevelNum);

            DarkNumericUpDown expBaseNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(expBaseNum, 100, 396, 1, 0, 32767);
            Controls.Add(expBaseNum);

            DarkNumericUpDown expFactorNum = new DarkNumericUpDown();
            NumericUpDowns.NewNumeric(expFactorNum, 100, 426, 1, 0, 32767);
            Controls.Add(expFactorNum);
        }
    }
}
