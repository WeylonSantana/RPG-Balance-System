
namespace IBS
{
    partial class IntersectBalanceSystem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nudPlyrMaxLvl = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrAtk = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrMAtk = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrMDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrSpd = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlyrMaxLvl = new DarkUI.Controls.DarkLabel();
            this.lblPlyrAtk = new DarkUI.Controls.DarkLabel();
            this.lblPlyrDef = new DarkUI.Controls.DarkLabel();
            this.lblPlyrMAtk = new DarkUI.Controls.DarkLabel();
            this.lblPlyrMDef = new DarkUI.Controls.DarkLabel();
            this.lblPlyrSpd = new DarkUI.Controls.DarkLabel();
            this.lblPlyrExpBase = new DarkUI.Controls.DarkLabel();
            this.nudPlyrExpBase = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlyrExpFac = new DarkUI.Controls.DarkLabel();
            this.lblPlyrBaseDmg = new DarkUI.Controls.DarkLabel();
            this.lblPlyrScalStat = new DarkUI.Controls.DarkLabel();
            this.lblPlyrScalFac = new DarkUI.Controls.DarkLabel();
            this.lblPlyrCrit = new DarkUI.Controls.DarkLabel();
            this.nudPlyrExpFac = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrBaseDmg = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrScalFac = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrCrit = new DarkUI.Controls.DarkNumericUpDown();
            this.cboPlyrScalStat = new DarkUI.Controls.DarkComboBox();
            this.nudPlyrPoints = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrMaxPoints = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlyrPoints = new DarkUI.Controls.DarkLabel();
            this.lblPlyrMaxPoints = new DarkUI.Controls.DarkLabel();
            this.lblPlyrHpBase = new DarkUI.Controls.DarkLabel();
            this.lblPlyrHpInc = new DarkUI.Controls.DarkLabel();
            this.nudPlyrHpBase = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPlyrHpInc = new DarkUI.Controls.DarkNumericUpDown();
            this.dgvPlyr = new System.Windows.Forms.DataGridView();
            this.PlyrLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrHitPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrMagicAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrMagicDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPlyrStatus = new DarkUI.Controls.DarkGroupBox();
            this.gbBuilds = new DarkUI.Controls.DarkGroupBox();
            this.rdTanker = new DarkUI.Controls.DarkRadioButton();
            this.rdStrong = new DarkUI.Controls.DarkRadioButton();
            this.rdBalanced = new DarkUI.Controls.DarkRadioButton();
            this.gbEnyStatus = new DarkUI.Controls.DarkGroupBox();
            this.lblEnyHp = new DarkUI.Controls.DarkLabel();
            this.cboEnyScalStat = new DarkUI.Controls.DarkComboBox();
            this.nudEnyCrit = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEnyHp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEnyAtk = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEnyScalFac = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEnyDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEnyBaseDmg = new DarkUI.Controls.DarkNumericUpDown();
            this.lblEnySpd = new DarkUI.Controls.DarkLabel();
            this.lblEnyCrit = new DarkUI.Controls.DarkLabel();
            this.nudEnyMAtk = new DarkUI.Controls.DarkNumericUpDown();
            this.lblEnyScalFac = new DarkUI.Controls.DarkLabel();
            this.lblEnyMDef = new DarkUI.Controls.DarkLabel();
            this.lblEnyScalStat = new DarkUI.Controls.DarkLabel();
            this.nudEnyMDef = new DarkUI.Controls.DarkNumericUpDown();
            this.lblEnyBaseDmg = new DarkUI.Controls.DarkLabel();
            this.lblEnyMAtk = new DarkUI.Controls.DarkLabel();
            this.nudEnySpd = new DarkUI.Controls.DarkNumericUpDown();
            this.lblEnyDef = new DarkUI.Controls.DarkLabel();
            this.lblEnyAtk = new DarkUI.Controls.DarkLabel();
            this.gbFunctions = new DarkUI.Controls.DarkGroupBox();
            this.btnSummaryGrid = new DarkUI.Controls.DarkButton();
            this.btnEnyGrid = new DarkUI.Controls.DarkButton();
            this.btnPlyrGrid = new DarkUI.Controls.DarkButton();
            this.btnLoad = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnUpdate = new DarkUI.Controls.DarkButton();
            this.dgvEny = new System.Windows.Forms.DataGridView();
            this.EnyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyHitPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyMagicAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyMagicDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnySpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.PlayerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrTrueDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrCritTrueDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrRealDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrCritRealDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrHitsTrue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlyrHitsReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyTrueDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyCritTrueDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyRealDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyCritRealDmg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyHitsTrue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnyHitsReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMaxLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrExpBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrExpFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrBaseDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrScalFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMaxPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrHpBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrHpInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlyr)).BeginInit();
            this.gbPlyrStatus.SuspendLayout();
            this.gbBuilds.SuspendLayout();
            this.gbEnyStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyScalFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyBaseDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyMAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyMDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnySpd)).BeginInit();
            this.gbFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPlyrMaxLvl
            // 
            this.nudPlyrMaxLvl.Location = new System.Drawing.Point(116, 19);
            this.nudPlyrMaxLvl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrMaxLvl.Name = "nudPlyrMaxLvl";
            this.nudPlyrMaxLvl.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrMaxLvl.TabIndex = 17;
            this.nudPlyrMaxLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlyrMaxLvl.ValueChanged += new System.EventHandler(this.nudPlyrMaxLvl_ValueChanged);
            // 
            // nudPlyrAtk
            // 
            this.nudPlyrAtk.Location = new System.Drawing.Point(116, 45);
            this.nudPlyrAtk.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrAtk.Name = "nudPlyrAtk";
            this.nudPlyrAtk.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrAtk.TabIndex = 18;
            this.nudPlyrAtk.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrAtk.ValueChanged += new System.EventHandler(this.nudPlyrAtk_ValueChanged);
            // 
            // nudPlyrDef
            // 
            this.nudPlyrDef.Location = new System.Drawing.Point(116, 71);
            this.nudPlyrDef.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrDef.Name = "nudPlyrDef";
            this.nudPlyrDef.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrDef.TabIndex = 19;
            this.nudPlyrDef.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrDef.ValueChanged += new System.EventHandler(this.nudPlyrDef_ValueChanged);
            // 
            // nudPlyrMAtk
            // 
            this.nudPlyrMAtk.Location = new System.Drawing.Point(116, 97);
            this.nudPlyrMAtk.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrMAtk.Name = "nudPlyrMAtk";
            this.nudPlyrMAtk.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrMAtk.TabIndex = 20;
            this.nudPlyrMAtk.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrMAtk.ValueChanged += new System.EventHandler(this.nudPlyrMAtk_ValueChanged);
            // 
            // nudPlyrMDef
            // 
            this.nudPlyrMDef.Location = new System.Drawing.Point(116, 123);
            this.nudPlyrMDef.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrMDef.Name = "nudPlyrMDef";
            this.nudPlyrMDef.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrMDef.TabIndex = 21;
            this.nudPlyrMDef.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrMDef.ValueChanged += new System.EventHandler(this.nudPlyrMDef_ValueChanged);
            // 
            // nudPlyrSpd
            // 
            this.nudPlyrSpd.Location = new System.Drawing.Point(116, 149);
            this.nudPlyrSpd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrSpd.Name = "nudPlyrSpd";
            this.nudPlyrSpd.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrSpd.TabIndex = 22;
            this.nudPlyrSpd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrSpd.ValueChanged += new System.EventHandler(this.nudPlyrSpd_ValueChanged);
            // 
            // lblPlyrMaxLvl
            // 
            this.lblPlyrMaxLvl.AutoSize = true;
            this.lblPlyrMaxLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrMaxLvl.Location = new System.Drawing.Point(6, 21);
            this.lblPlyrMaxLvl.Name = "lblPlyrMaxLvl";
            this.lblPlyrMaxLvl.Size = new System.Drawing.Size(59, 13);
            this.lblPlyrMaxLvl.TabIndex = 1;
            this.lblPlyrMaxLvl.Text = "Level Max:";
            // 
            // lblPlyrAtk
            // 
            this.lblPlyrAtk.AutoSize = true;
            this.lblPlyrAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrAtk.Location = new System.Drawing.Point(6, 47);
            this.lblPlyrAtk.Name = "lblPlyrAtk";
            this.lblPlyrAtk.Size = new System.Drawing.Size(41, 13);
            this.lblPlyrAtk.TabIndex = 2;
            this.lblPlyrAtk.Text = "Attack:";
            // 
            // lblPlyrDef
            // 
            this.lblPlyrDef.AutoSize = true;
            this.lblPlyrDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrDef.Location = new System.Drawing.Point(6, 73);
            this.lblPlyrDef.Name = "lblPlyrDef";
            this.lblPlyrDef.Size = new System.Drawing.Size(50, 13);
            this.lblPlyrDef.TabIndex = 3;
            this.lblPlyrDef.Text = "Defense:";
            // 
            // lblPlyrMAtk
            // 
            this.lblPlyrMAtk.AutoSize = true;
            this.lblPlyrMAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrMAtk.Location = new System.Drawing.Point(6, 99);
            this.lblPlyrMAtk.Name = "lblPlyrMAtk";
            this.lblPlyrMAtk.Size = new System.Drawing.Size(73, 13);
            this.lblPlyrMAtk.TabIndex = 4;
            this.lblPlyrMAtk.Text = "Magic Attack:";
            // 
            // lblPlyrMDef
            // 
            this.lblPlyrMDef.AutoSize = true;
            this.lblPlyrMDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrMDef.Location = new System.Drawing.Point(6, 125);
            this.lblPlyrMDef.Name = "lblPlyrMDef";
            this.lblPlyrMDef.Size = new System.Drawing.Size(82, 13);
            this.lblPlyrMDef.TabIndex = 5;
            this.lblPlyrMDef.Text = "Magic Defense:";
            // 
            // lblPlyrSpd
            // 
            this.lblPlyrSpd.AutoSize = true;
            this.lblPlyrSpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrSpd.Location = new System.Drawing.Point(6, 151);
            this.lblPlyrSpd.Name = "lblPlyrSpd";
            this.lblPlyrSpd.Size = new System.Drawing.Size(41, 13);
            this.lblPlyrSpd.TabIndex = 6;
            this.lblPlyrSpd.Text = "Speed:";
            // 
            // lblPlyrExpBase
            // 
            this.lblPlyrExpBase.AutoSize = true;
            this.lblPlyrExpBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrExpBase.Location = new System.Drawing.Point(247, 21);
            this.lblPlyrExpBase.Name = "lblPlyrExpBase";
            this.lblPlyrExpBase.Size = new System.Drawing.Size(55, 13);
            this.lblPlyrExpBase.TabIndex = 9;
            this.lblPlyrExpBase.Text = "Exp Base:";
            // 
            // nudPlyrExpBase
            // 
            this.nudPlyrExpBase.Location = new System.Drawing.Point(361, 19);
            this.nudPlyrExpBase.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrExpBase.Name = "nudPlyrExpBase";
            this.nudPlyrExpBase.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrExpBase.TabIndex = 25;
            this.nudPlyrExpBase.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPlyrExpBase.ValueChanged += new System.EventHandler(this.nudPlyrExpBase_ValueChanged);
            // 
            // lblPlyrExpFac
            // 
            this.lblPlyrExpFac.AutoSize = true;
            this.lblPlyrExpFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrExpFac.Location = new System.Drawing.Point(247, 47);
            this.lblPlyrExpFac.Name = "lblPlyrExpFac";
            this.lblPlyrExpFac.Size = new System.Drawing.Size(78, 13);
            this.lblPlyrExpFac.TabIndex = 10;
            this.lblPlyrExpFac.Text = "Exp Factor (%):";
            // 
            // lblPlyrBaseDmg
            // 
            this.lblPlyrBaseDmg.AutoSize = true;
            this.lblPlyrBaseDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrBaseDmg.Location = new System.Drawing.Point(247, 125);
            this.lblPlyrBaseDmg.Name = "lblPlyrBaseDmg";
            this.lblPlyrBaseDmg.Size = new System.Drawing.Size(77, 13);
            this.lblPlyrBaseDmg.TabIndex = 13;
            this.lblPlyrBaseDmg.Text = "Base Damage:";
            // 
            // lblPlyrScalStat
            // 
            this.lblPlyrScalStat.AutoSize = true;
            this.lblPlyrScalStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrScalStat.Location = new System.Drawing.Point(246, 151);
            this.lblPlyrScalStat.Name = "lblPlyrScalStat";
            this.lblPlyrScalStat.Size = new System.Drawing.Size(80, 13);
            this.lblPlyrScalStat.TabIndex = 14;
            this.lblPlyrScalStat.Text = "Scalling Status:";
            // 
            // lblPlyrScalFac
            // 
            this.lblPlyrScalFac.AutoSize = true;
            this.lblPlyrScalFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrScalFac.Location = new System.Drawing.Point(246, 177);
            this.lblPlyrScalFac.Name = "lblPlyrScalFac";
            this.lblPlyrScalFac.Size = new System.Drawing.Size(97, 13);
            this.lblPlyrScalFac.TabIndex = 15;
            this.lblPlyrScalFac.Text = "Scalling Factor (%):";
            // 
            // lblPlyrCrit
            // 
            this.lblPlyrCrit.AutoSize = true;
            this.lblPlyrCrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrCrit.Location = new System.Drawing.Point(246, 203);
            this.lblPlyrCrit.Name = "lblPlyrCrit";
            this.lblPlyrCrit.Size = new System.Drawing.Size(85, 13);
            this.lblPlyrCrit.TabIndex = 16;
            this.lblPlyrCrit.Text = "Critical Multiplier:";
            // 
            // nudPlyrExpFac
            // 
            this.nudPlyrExpFac.Location = new System.Drawing.Point(360, 45);
            this.nudPlyrExpFac.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrExpFac.Name = "nudPlyrExpFac";
            this.nudPlyrExpFac.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrExpFac.TabIndex = 26;
            this.nudPlyrExpFac.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPlyrExpFac.ValueChanged += new System.EventHandler(this.nudPlyrExpFac_ValueChanged);
            // 
            // nudPlyrBaseDmg
            // 
            this.nudPlyrBaseDmg.Location = new System.Drawing.Point(360, 123);
            this.nudPlyrBaseDmg.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrBaseDmg.Name = "nudPlyrBaseDmg";
            this.nudPlyrBaseDmg.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrBaseDmg.TabIndex = 29;
            this.nudPlyrBaseDmg.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrBaseDmg.ValueChanged += new System.EventHandler(this.nudPlyrBaseDmg_ValueChanged);
            // 
            // nudPlyrScalFac
            // 
            this.nudPlyrScalFac.Location = new System.Drawing.Point(360, 175);
            this.nudPlyrScalFac.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrScalFac.Name = "nudPlyrScalFac";
            this.nudPlyrScalFac.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrScalFac.TabIndex = 31;
            this.nudPlyrScalFac.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPlyrScalFac.ValueChanged += new System.EventHandler(this.nudPlyrScalFac_ValueChanged);
            // 
            // nudPlyrCrit
            // 
            this.nudPlyrCrit.DecimalPlaces = 1;
            this.nudPlyrCrit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPlyrCrit.Location = new System.Drawing.Point(360, 201);
            this.nudPlyrCrit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrCrit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlyrCrit.Name = "nudPlyrCrit";
            this.nudPlyrCrit.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrCrit.TabIndex = 32;
            this.nudPlyrCrit.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nudPlyrCrit.ValueChanged += new System.EventHandler(this.nudPlyrCrit_ValueChanged);
            // 
            // cboPlyrScalStat
            // 
            this.cboPlyrScalStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPlyrScalStat.FormattingEnabled = true;
            this.cboPlyrScalStat.Items.AddRange(new object[] {
            "Attack",
            "Defense",
            "Magic Attack",
            "Magic Defense",
            "Speed"});
            this.cboPlyrScalStat.Location = new System.Drawing.Point(360, 148);
            this.cboPlyrScalStat.Name = "cboPlyrScalStat";
            this.cboPlyrScalStat.Size = new System.Drawing.Size(100, 21);
            this.cboPlyrScalStat.TabIndex = 30;
            // 
            // nudPlyrPoints
            // 
            this.nudPlyrPoints.Location = new System.Drawing.Point(361, 71);
            this.nudPlyrPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrPoints.Name = "nudPlyrPoints";
            this.nudPlyrPoints.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrPoints.TabIndex = 27;
            this.nudPlyrPoints.ValueChanged += new System.EventHandler(this.nudPlyrPoints_ValueChanged);
            // 
            // nudPlyrMaxPoints
            // 
            this.nudPlyrMaxPoints.Location = new System.Drawing.Point(360, 97);
            this.nudPlyrMaxPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrMaxPoints.Name = "nudPlyrMaxPoints";
            this.nudPlyrMaxPoints.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrMaxPoints.TabIndex = 28;
            this.nudPlyrMaxPoints.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrMaxPoints.ValueChanged += new System.EventHandler(this.nudPlyrMaxPoints_ValueChanged);
            // 
            // lblPlyrPoints
            // 
            this.lblPlyrPoints.AutoSize = true;
            this.lblPlyrPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrPoints.Location = new System.Drawing.Point(247, 73);
            this.lblPlyrPoints.Name = "lblPlyrPoints";
            this.lblPlyrPoints.Size = new System.Drawing.Size(83, 13);
            this.lblPlyrPoints.TabIndex = 11;
            this.lblPlyrPoints.Text = "Points By Level:";
            // 
            // lblPlyrMaxPoints
            // 
            this.lblPlyrMaxPoints.AutoSize = true;
            this.lblPlyrMaxPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrMaxPoints.Location = new System.Drawing.Point(246, 99);
            this.lblPlyrMaxPoints.Name = "lblPlyrMaxPoints";
            this.lblPlyrMaxPoints.Size = new System.Drawing.Size(86, 13);
            this.lblPlyrMaxPoints.TabIndex = 12;
            this.lblPlyrMaxPoints.Text = "Maximum Points:";
            // 
            // lblPlyrHpBase
            // 
            this.lblPlyrHpBase.AutoSize = true;
            this.lblPlyrHpBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrHpBase.Location = new System.Drawing.Point(6, 177);
            this.lblPlyrHpBase.Name = "lblPlyrHpBase";
            this.lblPlyrHpBase.Size = new System.Drawing.Size(52, 13);
            this.lblPlyrHpBase.TabIndex = 7;
            this.lblPlyrHpBase.Text = "HP Base:";
            // 
            // lblPlyrHpInc
            // 
            this.lblPlyrHpInc.AutoSize = true;
            this.lblPlyrHpInc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPlyrHpInc.Location = new System.Drawing.Point(6, 203);
            this.lblPlyrHpInc.Name = "lblPlyrHpInc";
            this.lblPlyrHpInc.Size = new System.Drawing.Size(94, 13);
            this.lblPlyrHpInc.TabIndex = 8;
            this.lblPlyrHpInc.Text = "HP Inc. by Lvl (%):";
            // 
            // nudPlyrHpBase
            // 
            this.nudPlyrHpBase.Location = new System.Drawing.Point(116, 175);
            this.nudPlyrHpBase.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPlyrHpBase.Name = "nudPlyrHpBase";
            this.nudPlyrHpBase.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrHpBase.TabIndex = 23;
            this.nudPlyrHpBase.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPlyrHpBase.ValueChanged += new System.EventHandler(this.nudPlyrHpBase_ValueChanged);
            // 
            // nudPlyrHpInc
            // 
            this.nudPlyrHpInc.Location = new System.Drawing.Point(116, 201);
            this.nudPlyrHpInc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPlyrHpInc.Name = "nudPlyrHpInc";
            this.nudPlyrHpInc.Size = new System.Drawing.Size(100, 20);
            this.nudPlyrHpInc.TabIndex = 24;
            this.nudPlyrHpInc.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudPlyrHpInc.ValueChanged += new System.EventHandler(this.nudPlyrHpInc_ValueChanged);
            // 
            // dgvPlyr
            // 
            this.dgvPlyr.AllowUserToAddRows = false;
            this.dgvPlyr.AllowUserToDeleteRows = false;
            this.dgvPlyr.AllowUserToResizeColumns = false;
            this.dgvPlyr.AllowUserToResizeRows = false;
            this.dgvPlyr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvPlyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlyr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlyrLevel,
            this.PlyrHitPoints,
            this.PlyrAttack,
            this.PlyrDefense,
            this.PlyrMagicAttack,
            this.PlyrMagicDefense,
            this.PlyrSpeed,
            this.PlyrExp});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlyr.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPlyr.GridColor = System.Drawing.Color.Black;
            this.dgvPlyr.Location = new System.Drawing.Point(485, 12);
            this.dgvPlyr.Name = "dgvPlyr";
            this.dgvPlyr.ReadOnly = true;
            this.dgvPlyr.Size = new System.Drawing.Size(853, 705);
            this.dgvPlyr.TabIndex = 4;
            // 
            // PlyrLevel
            // 
            this.PlyrLevel.HeaderText = "Level";
            this.PlyrLevel.Name = "PlyrLevel";
            this.PlyrLevel.ReadOnly = true;
            // 
            // PlyrHitPoints
            // 
            this.PlyrHitPoints.HeaderText = "HitPoints";
            this.PlyrHitPoints.Name = "PlyrHitPoints";
            this.PlyrHitPoints.ReadOnly = true;
            // 
            // PlyrAttack
            // 
            this.PlyrAttack.HeaderText = "Attack";
            this.PlyrAttack.Name = "PlyrAttack";
            this.PlyrAttack.ReadOnly = true;
            // 
            // PlyrDefense
            // 
            this.PlyrDefense.HeaderText = "Defense";
            this.PlyrDefense.Name = "PlyrDefense";
            this.PlyrDefense.ReadOnly = true;
            // 
            // PlyrMagicAttack
            // 
            this.PlyrMagicAttack.HeaderText = "Magic Attack";
            this.PlyrMagicAttack.Name = "PlyrMagicAttack";
            this.PlyrMagicAttack.ReadOnly = true;
            // 
            // PlyrMagicDefense
            // 
            this.PlyrMagicDefense.HeaderText = "Magic Defense";
            this.PlyrMagicDefense.Name = "PlyrMagicDefense";
            this.PlyrMagicDefense.ReadOnly = true;
            // 
            // PlyrSpeed
            // 
            this.PlyrSpeed.HeaderText = "Speed";
            this.PlyrSpeed.Name = "PlyrSpeed";
            this.PlyrSpeed.ReadOnly = true;
            // 
            // PlyrExp
            // 
            this.PlyrExp.HeaderText = "Exp";
            this.PlyrExp.Name = "PlyrExp";
            this.PlyrExp.ReadOnly = true;
            // 
            // gbPlyrStatus
            // 
            this.gbPlyrStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbPlyrStatus.Controls.Add(this.lblPlyrMaxLvl);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrMaxLvl);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrMaxPoints);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrMaxPoints);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrPoints);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrAtk);
            this.gbPlyrStatus.Controls.Add(this.cboPlyrScalStat);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrPoints);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrCrit);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrHpInc);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrScalFac);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrDef);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrBaseDmg);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrHpBase);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrExpFac);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrHpInc);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrExpBase);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrMAtk);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrHpBase);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrMDef);
            this.gbPlyrStatus.Controls.Add(this.nudPlyrSpd);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrCrit);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrAtk);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrScalFac);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrDef);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrScalStat);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrMAtk);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrBaseDmg);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrMDef);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrExpFac);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrSpd);
            this.gbPlyrStatus.Controls.Add(this.lblPlyrExpBase);
            this.gbPlyrStatus.Location = new System.Drawing.Point(12, 12);
            this.gbPlyrStatus.Name = "gbPlyrStatus";
            this.gbPlyrStatus.Size = new System.Drawing.Size(467, 232);
            this.gbPlyrStatus.TabIndex = 0;
            this.gbPlyrStatus.TabStop = false;
            this.gbPlyrStatus.Text = "Basic Player Status:";
            // 
            // gbBuilds
            // 
            this.gbBuilds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbBuilds.Controls.Add(this.rdTanker);
            this.gbBuilds.Controls.Add(this.rdStrong);
            this.gbBuilds.Controls.Add(this.rdBalanced);
            this.gbBuilds.Location = new System.Drawing.Point(12, 250);
            this.gbBuilds.Name = "gbBuilds";
            this.gbBuilds.Size = new System.Drawing.Size(467, 49);
            this.gbBuilds.TabIndex = 1;
            this.gbBuilds.TabStop = false;
            this.gbBuilds.Text = "Builds";
            // 
            // rdTanker
            // 
            this.rdTanker.AutoSize = true;
            this.rdTanker.Location = new System.Drawing.Point(400, 19);
            this.rdTanker.Name = "rdTanker";
            this.rdTanker.Size = new System.Drawing.Size(59, 17);
            this.rdTanker.TabIndex = 2;
            this.rdTanker.TabStop = true;
            this.rdTanker.Text = "Tanker";
            // 
            // rdStrong
            // 
            this.rdStrong.AutoSize = true;
            this.rdStrong.Location = new System.Drawing.Point(205, 19);
            this.rdStrong.Name = "rdStrong";
            this.rdStrong.Size = new System.Drawing.Size(56, 17);
            this.rdStrong.TabIndex = 1;
            this.rdStrong.TabStop = true;
            this.rdStrong.Text = "Strong";
            // 
            // rdBalanced
            // 
            this.rdBalanced.AutoSize = true;
            this.rdBalanced.Location = new System.Drawing.Point(9, 19);
            this.rdBalanced.Name = "rdBalanced";
            this.rdBalanced.Size = new System.Drawing.Size(70, 17);
            this.rdBalanced.TabIndex = 0;
            this.rdBalanced.TabStop = true;
            this.rdBalanced.Text = "Balanced";
            // 
            // gbEnyStatus
            // 
            this.gbEnyStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbEnyStatus.Controls.Add(this.lblEnyHp);
            this.gbEnyStatus.Controls.Add(this.cboEnyScalStat);
            this.gbEnyStatus.Controls.Add(this.nudEnyCrit);
            this.gbEnyStatus.Controls.Add(this.nudEnyHp);
            this.gbEnyStatus.Controls.Add(this.nudEnyAtk);
            this.gbEnyStatus.Controls.Add(this.nudEnyScalFac);
            this.gbEnyStatus.Controls.Add(this.nudEnyDef);
            this.gbEnyStatus.Controls.Add(this.nudEnyBaseDmg);
            this.gbEnyStatus.Controls.Add(this.lblEnySpd);
            this.gbEnyStatus.Controls.Add(this.lblEnyCrit);
            this.gbEnyStatus.Controls.Add(this.nudEnyMAtk);
            this.gbEnyStatus.Controls.Add(this.lblEnyScalFac);
            this.gbEnyStatus.Controls.Add(this.lblEnyMDef);
            this.gbEnyStatus.Controls.Add(this.lblEnyScalStat);
            this.gbEnyStatus.Controls.Add(this.nudEnyMDef);
            this.gbEnyStatus.Controls.Add(this.lblEnyBaseDmg);
            this.gbEnyStatus.Controls.Add(this.lblEnyMAtk);
            this.gbEnyStatus.Controls.Add(this.nudEnySpd);
            this.gbEnyStatus.Controls.Add(this.lblEnyDef);
            this.gbEnyStatus.Controls.Add(this.lblEnyAtk);
            this.gbEnyStatus.Location = new System.Drawing.Point(12, 305);
            this.gbEnyStatus.Name = "gbEnyStatus";
            this.gbEnyStatus.Size = new System.Drawing.Size(467, 156);
            this.gbEnyStatus.TabIndex = 2;
            this.gbEnyStatus.TabStop = false;
            this.gbEnyStatus.Text = "Enemy Basic Status:";
            // 
            // lblEnyHp
            // 
            this.lblEnyHp.AutoSize = true;
            this.lblEnyHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyHp.Location = new System.Drawing.Point(249, 21);
            this.lblEnyHp.Name = "lblEnyHp";
            this.lblEnyHp.Size = new System.Drawing.Size(42, 13);
            this.lblEnyHp.TabIndex = 5;
            this.lblEnyHp.Text = "HP (%):";
            // 
            // cboEnyScalStat
            // 
            this.cboEnyScalStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEnyScalStat.FormattingEnabled = true;
            this.cboEnyScalStat.Items.AddRange(new object[] {
            "Attack",
            "Defense",
            "Magic Attack",
            "Magic Defense",
            "Speed"});
            this.cboEnyScalStat.Location = new System.Drawing.Point(361, 70);
            this.cboEnyScalStat.Name = "cboEnyScalStat";
            this.cboEnyScalStat.Size = new System.Drawing.Size(100, 21);
            this.cboEnyScalStat.TabIndex = 17;
            // 
            // nudEnyCrit
            // 
            this.nudEnyCrit.DecimalPlaces = 1;
            this.nudEnyCrit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudEnyCrit.Location = new System.Drawing.Point(361, 123);
            this.nudEnyCrit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyCrit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnyCrit.Name = "nudEnyCrit";
            this.nudEnyCrit.Size = new System.Drawing.Size(100, 20);
            this.nudEnyCrit.TabIndex = 19;
            this.nudEnyCrit.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nudEnyCrit.ValueChanged += new System.EventHandler(this.nudEnyCrit_ValueChanged);
            // 
            // nudEnyHp
            // 
            this.nudEnyHp.Location = new System.Drawing.Point(361, 19);
            this.nudEnyHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyHp.Name = "nudEnyHp";
            this.nudEnyHp.Size = new System.Drawing.Size(100, 20);
            this.nudEnyHp.TabIndex = 15;
            this.nudEnyHp.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnyHp.ValueChanged += new System.EventHandler(this.nudEnyHp_ValueChanged);
            // 
            // nudEnyAtk
            // 
            this.nudEnyAtk.Location = new System.Drawing.Point(116, 19);
            this.nudEnyAtk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyAtk.Name = "nudEnyAtk";
            this.nudEnyAtk.Size = new System.Drawing.Size(100, 20);
            this.nudEnyAtk.TabIndex = 10;
            this.nudEnyAtk.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnyAtk.ValueChanged += new System.EventHandler(this.nudEnyAtk_ValueChanged);
            // 
            // nudEnyScalFac
            // 
            this.nudEnyScalFac.Location = new System.Drawing.Point(361, 97);
            this.nudEnyScalFac.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyScalFac.Name = "nudEnyScalFac";
            this.nudEnyScalFac.Size = new System.Drawing.Size(100, 20);
            this.nudEnyScalFac.TabIndex = 18;
            this.nudEnyScalFac.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEnyScalFac.ValueChanged += new System.EventHandler(this.nudEnyScalFac_ValueChanged);
            // 
            // nudEnyDef
            // 
            this.nudEnyDef.Location = new System.Drawing.Point(116, 45);
            this.nudEnyDef.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyDef.Name = "nudEnyDef";
            this.nudEnyDef.Size = new System.Drawing.Size(100, 20);
            this.nudEnyDef.TabIndex = 11;
            this.nudEnyDef.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnyDef.ValueChanged += new System.EventHandler(this.nudEnyDef_ValueChanged);
            // 
            // nudEnyBaseDmg
            // 
            this.nudEnyBaseDmg.Location = new System.Drawing.Point(361, 45);
            this.nudEnyBaseDmg.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudEnyBaseDmg.Name = "nudEnyBaseDmg";
            this.nudEnyBaseDmg.Size = new System.Drawing.Size(100, 20);
            this.nudEnyBaseDmg.TabIndex = 16;
            this.nudEnyBaseDmg.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEnyBaseDmg.ValueChanged += new System.EventHandler(this.nudEnyBaseDmg_ValueChanged);
            // 
            // lblEnySpd
            // 
            this.lblEnySpd.AutoSize = true;
            this.lblEnySpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnySpd.Location = new System.Drawing.Point(6, 125);
            this.lblEnySpd.Name = "lblEnySpd";
            this.lblEnySpd.Size = new System.Drawing.Size(58, 13);
            this.lblEnySpd.TabIndex = 4;
            this.lblEnySpd.Text = "Speed (%):";
            // 
            // lblEnyCrit
            // 
            this.lblEnyCrit.AutoSize = true;
            this.lblEnyCrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyCrit.Location = new System.Drawing.Point(247, 125);
            this.lblEnyCrit.Name = "lblEnyCrit";
            this.lblEnyCrit.Size = new System.Drawing.Size(85, 13);
            this.lblEnyCrit.TabIndex = 9;
            this.lblEnyCrit.Text = "Critical Multiplier:";
            // 
            // nudEnyMAtk
            // 
            this.nudEnyMAtk.Location = new System.Drawing.Point(116, 71);
            this.nudEnyMAtk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyMAtk.Name = "nudEnyMAtk";
            this.nudEnyMAtk.Size = new System.Drawing.Size(100, 20);
            this.nudEnyMAtk.TabIndex = 12;
            this.nudEnyMAtk.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnyMAtk.ValueChanged += new System.EventHandler(this.nudEnyMAtk_ValueChanged);
            // 
            // lblEnyScalFac
            // 
            this.lblEnyScalFac.AutoSize = true;
            this.lblEnyScalFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyScalFac.Location = new System.Drawing.Point(247, 99);
            this.lblEnyScalFac.Name = "lblEnyScalFac";
            this.lblEnyScalFac.Size = new System.Drawing.Size(97, 13);
            this.lblEnyScalFac.TabIndex = 8;
            this.lblEnyScalFac.Text = "Scalling Factor (%):";
            // 
            // lblEnyMDef
            // 
            this.lblEnyMDef.AutoSize = true;
            this.lblEnyMDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyMDef.Location = new System.Drawing.Point(6, 99);
            this.lblEnyMDef.Name = "lblEnyMDef";
            this.lblEnyMDef.Size = new System.Drawing.Size(99, 13);
            this.lblEnyMDef.TabIndex = 3;
            this.lblEnyMDef.Text = "Magic Defense (%):";
            // 
            // lblEnyScalStat
            // 
            this.lblEnyScalStat.AutoSize = true;
            this.lblEnyScalStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyScalStat.Location = new System.Drawing.Point(247, 73);
            this.lblEnyScalStat.Name = "lblEnyScalStat";
            this.lblEnyScalStat.Size = new System.Drawing.Size(80, 13);
            this.lblEnyScalStat.TabIndex = 7;
            this.lblEnyScalStat.Text = "Scalling Status:";
            // 
            // nudEnyMDef
            // 
            this.nudEnyMDef.Location = new System.Drawing.Point(116, 97);
            this.nudEnyMDef.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnyMDef.Name = "nudEnyMDef";
            this.nudEnyMDef.Size = new System.Drawing.Size(100, 20);
            this.nudEnyMDef.TabIndex = 13;
            this.nudEnyMDef.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnyMDef.ValueChanged += new System.EventHandler(this.nudEnyMDef_ValueChanged);
            // 
            // lblEnyBaseDmg
            // 
            this.lblEnyBaseDmg.AutoSize = true;
            this.lblEnyBaseDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyBaseDmg.Location = new System.Drawing.Point(248, 47);
            this.lblEnyBaseDmg.Name = "lblEnyBaseDmg";
            this.lblEnyBaseDmg.Size = new System.Drawing.Size(77, 13);
            this.lblEnyBaseDmg.TabIndex = 6;
            this.lblEnyBaseDmg.Text = "Base Damage:";
            // 
            // lblEnyMAtk
            // 
            this.lblEnyMAtk.AutoSize = true;
            this.lblEnyMAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyMAtk.Location = new System.Drawing.Point(6, 73);
            this.lblEnyMAtk.Name = "lblEnyMAtk";
            this.lblEnyMAtk.Size = new System.Drawing.Size(90, 13);
            this.lblEnyMAtk.TabIndex = 2;
            this.lblEnyMAtk.Text = "Magic Attack (%):";
            // 
            // nudEnySpd
            // 
            this.nudEnySpd.Location = new System.Drawing.Point(116, 123);
            this.nudEnySpd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEnySpd.Name = "nudEnySpd";
            this.nudEnySpd.Size = new System.Drawing.Size(100, 20);
            this.nudEnySpd.TabIndex = 14;
            this.nudEnySpd.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEnySpd.ValueChanged += new System.EventHandler(this.nudEnySpd_ValueChanged);
            // 
            // lblEnyDef
            // 
            this.lblEnyDef.AutoSize = true;
            this.lblEnyDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyDef.Location = new System.Drawing.Point(6, 47);
            this.lblEnyDef.Name = "lblEnyDef";
            this.lblEnyDef.Size = new System.Drawing.Size(67, 13);
            this.lblEnyDef.TabIndex = 1;
            this.lblEnyDef.Text = "Defense (%):";
            // 
            // lblEnyAtk
            // 
            this.lblEnyAtk.AutoSize = true;
            this.lblEnyAtk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEnyAtk.Location = new System.Drawing.Point(6, 21);
            this.lblEnyAtk.Name = "lblEnyAtk";
            this.lblEnyAtk.Size = new System.Drawing.Size(58, 13);
            this.lblEnyAtk.TabIndex = 0;
            this.lblEnyAtk.Text = "Attack (%):";
            // 
            // gbFunctions
            // 
            this.gbFunctions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbFunctions.Controls.Add(this.btnSummaryGrid);
            this.gbFunctions.Controls.Add(this.btnEnyGrid);
            this.gbFunctions.Controls.Add(this.btnPlyrGrid);
            this.gbFunctions.Controls.Add(this.btnLoad);
            this.gbFunctions.Controls.Add(this.btnSave);
            this.gbFunctions.Controls.Add(this.btnUpdate);
            this.gbFunctions.Location = new System.Drawing.Point(12, 467);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(467, 89);
            this.gbFunctions.TabIndex = 3;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Functions:";
            // 
            // btnSummaryGrid
            // 
            this.btnSummaryGrid.Location = new System.Drawing.Point(359, 50);
            this.btnSummaryGrid.Name = "btnSummaryGrid";
            this.btnSummaryGrid.Padding = new System.Windows.Forms.Padding(5);
            this.btnSummaryGrid.Size = new System.Drawing.Size(100, 25);
            this.btnSummaryGrid.TabIndex = 5;
            this.btnSummaryGrid.Text = "Summary Grid";
            this.btnSummaryGrid.Click += new System.EventHandler(this.btnSummaryGrid_Click);
            // 
            // btnEnyGrid
            // 
            this.btnEnyGrid.Location = new System.Drawing.Point(182, 50);
            this.btnEnyGrid.Name = "btnEnyGrid";
            this.btnEnyGrid.Padding = new System.Windows.Forms.Padding(5);
            this.btnEnyGrid.Size = new System.Drawing.Size(100, 25);
            this.btnEnyGrid.TabIndex = 4;
            this.btnEnyGrid.Text = "Enemy Grid";
            this.btnEnyGrid.Click += new System.EventHandler(this.btnEnyGrid_Click);
            // 
            // btnPlyrGrid
            // 
            this.btnPlyrGrid.Location = new System.Drawing.Point(9, 50);
            this.btnPlyrGrid.Name = "btnPlyrGrid";
            this.btnPlyrGrid.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlyrGrid.Size = new System.Drawing.Size(100, 25);
            this.btnPlyrGrid.TabIndex = 3;
            this.btnPlyrGrid.Text = "Player Grid";
            this.btnPlyrGrid.Click += new System.EventHandler(this.btnPlyrGrid_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(359, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(5);
            this.btnLoad.Size = new System.Drawing.Size(100, 25);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update!";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvEny
            // 
            this.dgvEny.AllowUserToAddRows = false;
            this.dgvEny.AllowUserToDeleteRows = false;
            this.dgvEny.AllowUserToResizeColumns = false;
            this.dgvEny.AllowUserToResizeRows = false;
            this.dgvEny.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvEny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnyLevel,
            this.EnyHitPoints,
            this.EnyAttack,
            this.EnyDefense,
            this.EnyMagicAttack,
            this.EnyMagicDefense,
            this.EnySpeed});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEny.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEny.GridColor = System.Drawing.Color.Black;
            this.dgvEny.Location = new System.Drawing.Point(485, 12);
            this.dgvEny.Name = "dgvEny";
            this.dgvEny.ReadOnly = true;
            this.dgvEny.Size = new System.Drawing.Size(853, 705);
            this.dgvEny.TabIndex = 5;
            // 
            // EnyLevel
            // 
            this.EnyLevel.HeaderText = "Level";
            this.EnyLevel.Name = "EnyLevel";
            this.EnyLevel.ReadOnly = true;
            // 
            // EnyHitPoints
            // 
            this.EnyHitPoints.HeaderText = "Hit Points";
            this.EnyHitPoints.Name = "EnyHitPoints";
            this.EnyHitPoints.ReadOnly = true;
            // 
            // EnyAttack
            // 
            this.EnyAttack.HeaderText = "Attack";
            this.EnyAttack.Name = "EnyAttack";
            this.EnyAttack.ReadOnly = true;
            // 
            // EnyDefense
            // 
            this.EnyDefense.HeaderText = "Defense";
            this.EnyDefense.Name = "EnyDefense";
            this.EnyDefense.ReadOnly = true;
            // 
            // EnyMagicAttack
            // 
            this.EnyMagicAttack.HeaderText = "Magic Attack";
            this.EnyMagicAttack.Name = "EnyMagicAttack";
            this.EnyMagicAttack.ReadOnly = true;
            // 
            // EnyMagicDefense
            // 
            this.EnyMagicDefense.HeaderText = "Magic Defense";
            this.EnyMagicDefense.Name = "EnyMagicDefense";
            this.EnyMagicDefense.ReadOnly = true;
            // 
            // EnySpeed
            // 
            this.EnySpeed.HeaderText = "Speed";
            this.EnySpeed.Name = "EnySpeed";
            this.EnySpeed.ReadOnly = true;
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.AllowUserToResizeColumns = false;
            this.dgvSummary.AllowUserToResizeRows = false;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerLevel,
            this.PlyrTrueDmg,
            this.PlyrCritTrueDmg,
            this.PlyrRealDmg,
            this.PlyrCritRealDmg,
            this.PlyrHitsTrue,
            this.PlyrHitsReal,
            this.EnemyLevel,
            this.EnyTrueDmg,
            this.EnyCritTrueDmg,
            this.EnyRealDmg,
            this.EnyCritRealDmg,
            this.EnyHitsTrue,
            this.EnyHitsReal});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSummary.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSummary.GridColor = System.Drawing.Color.Black;
            this.dgvSummary.Location = new System.Drawing.Point(485, 12);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.Size = new System.Drawing.Size(853, 705);
            this.dgvSummary.TabIndex = 6;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.HeaderText = "Player Level";
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.ReadOnly = true;
            this.PlayerLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PlyrTrueDmg
            // 
            this.PlyrTrueDmg.HeaderText = "True Damage";
            this.PlyrTrueDmg.Name = "PlyrTrueDmg";
            this.PlyrTrueDmg.ReadOnly = true;
            this.PlyrTrueDmg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PlyrCritTrueDmg
            // 
            this.PlyrCritTrueDmg.HeaderText = "Critical True Damage";
            this.PlyrCritTrueDmg.Name = "PlyrCritTrueDmg";
            this.PlyrCritTrueDmg.ReadOnly = true;
            // 
            // PlyrRealDmg
            // 
            this.PlyrRealDmg.HeaderText = "Real Damage";
            this.PlyrRealDmg.Name = "PlyrRealDmg";
            this.PlyrRealDmg.ReadOnly = true;
            // 
            // PlyrCritRealDmg
            // 
            this.PlyrCritRealDmg.HeaderText = "Critical Real Damage";
            this.PlyrCritRealDmg.Name = "PlyrCritRealDmg";
            this.PlyrCritRealDmg.ReadOnly = true;
            // 
            // PlyrHitsTrue
            // 
            this.PlyrHitsTrue.HeaderText = "Hits True";
            this.PlyrHitsTrue.Name = "PlyrHitsTrue";
            this.PlyrHitsTrue.ReadOnly = true;
            // 
            // PlyrHitsReal
            // 
            this.PlyrHitsReal.HeaderText = "Hits Real";
            this.PlyrHitsReal.Name = "PlyrHitsReal";
            this.PlyrHitsReal.ReadOnly = true;
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.HeaderText = "Enemy Level";
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.ReadOnly = true;
            // 
            // EnyTrueDmg
            // 
            this.EnyTrueDmg.HeaderText = "True Damage";
            this.EnyTrueDmg.Name = "EnyTrueDmg";
            this.EnyTrueDmg.ReadOnly = true;
            // 
            // EnyCritTrueDmg
            // 
            this.EnyCritTrueDmg.HeaderText = "Critical True Damage";
            this.EnyCritTrueDmg.Name = "EnyCritTrueDmg";
            this.EnyCritTrueDmg.ReadOnly = true;
            // 
            // EnyRealDmg
            // 
            this.EnyRealDmg.HeaderText = "Real Damage";
            this.EnyRealDmg.Name = "EnyRealDmg";
            this.EnyRealDmg.ReadOnly = true;
            // 
            // EnyCritRealDmg
            // 
            this.EnyCritRealDmg.HeaderText = "Critical Real Damage";
            this.EnyCritRealDmg.Name = "EnyCritRealDmg";
            this.EnyCritRealDmg.ReadOnly = true;
            // 
            // EnyHitsTrue
            // 
            this.EnyHitsTrue.HeaderText = "Hits True";
            this.EnyHitsTrue.Name = "EnyHitsTrue";
            this.EnyHitsTrue.ReadOnly = true;
            // 
            // EnyHitsReal
            // 
            this.EnyHitsReal.HeaderText = "Hits Real";
            this.EnyHitsReal.Name = "EnyHitsReal";
            this.EnyHitsReal.ReadOnly = true;
            // 
            // IntersectBalanceSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.gbEnyStatus);
            this.Controls.Add(this.gbBuilds);
            this.Controls.Add(this.gbPlyrStatus);
            this.Controls.Add(this.dgvPlyr);
            this.Controls.Add(this.dgvEny);
            this.Controls.Add(this.dgvSummary);
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(6, 151);
            this.MaximizeBox = false;
            this.Name = "IntersectBalanceSystem";
            this.Text = "Intersect Balancing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMaxLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrExpBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrExpFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrBaseDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrScalFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrMaxPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrHpBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrHpInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlyr)).EndInit();
            this.gbPlyrStatus.ResumeLayout(false);
            this.gbPlyrStatus.PerformLayout();
            this.gbBuilds.ResumeLayout(false);
            this.gbBuilds.PerformLayout();
            this.gbEnyStatus.ResumeLayout(false);
            this.gbEnyStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyScalFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyBaseDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyMAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnyMDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnySpd)).EndInit();
            this.gbFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DarkUI.Controls.DarkGroupBox gbPlyrStatus;
        public DarkUI.Controls.DarkLabel lblPlyrMaxLvl;
        public DarkUI.Controls.DarkLabel lblPlyrAtk;
        public DarkUI.Controls.DarkLabel lblPlyrDef;
        public DarkUI.Controls.DarkLabel lblPlyrMAtk;
        public DarkUI.Controls.DarkLabel lblPlyrMDef;
        public DarkUI.Controls.DarkLabel lblPlyrSpd;
        public DarkUI.Controls.DarkLabel lblPlyrExpBase;
        public DarkUI.Controls.DarkLabel lblPlyrExpFac;
        public DarkUI.Controls.DarkLabel lblPlyrBaseDmg;
        public DarkUI.Controls.DarkLabel lblPlyrScalStat;
        public DarkUI.Controls.DarkLabel lblPlyrScalFac;
        public DarkUI.Controls.DarkLabel lblPlyrCrit;
        public DarkUI.Controls.DarkLabel lblPlyrPoints;
        public DarkUI.Controls.DarkLabel lblPlyrMaxPoints;
        public DarkUI.Controls.DarkLabel lblPlyrHpBase;
        public DarkUI.Controls.DarkLabel lblPlyrHpInc;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrMaxLvl;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrAtk;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrDef;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrMAtk;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrMDef;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrSpd;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrExpBase;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrExpFac;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrBaseDmg;
        public DarkUI.Controls.DarkComboBox cboPlyrScalStat;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrScalFac;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrCrit;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrPoints;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrMaxPoints;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrHpBase;
        public DarkUI.Controls.DarkNumericUpDown nudPlyrHpInc;
        public DarkUI.Controls.DarkGroupBox gbBuilds;
        public DarkUI.Controls.DarkRadioButton rdTanker;
        public DarkUI.Controls.DarkRadioButton rdStrong;
        public DarkUI.Controls.DarkRadioButton rdBalanced;
        public DarkUI.Controls.DarkGroupBox gbEnyStatus;
        public DarkUI.Controls.DarkLabel lblEnyAtk;
        public DarkUI.Controls.DarkLabel lblEnyDef;
        public DarkUI.Controls.DarkLabel lblEnyMAtk;
        public DarkUI.Controls.DarkLabel lblEnyMDef;
        public DarkUI.Controls.DarkLabel lblEnySpd;
        public DarkUI.Controls.DarkLabel lblEnyHp;
        public DarkUI.Controls.DarkLabel lblEnyBaseDmg;
        public DarkUI.Controls.DarkLabel lblEnyScalStat;
        public DarkUI.Controls.DarkLabel lblEnyScalFac;
        public DarkUI.Controls.DarkLabel lblEnyCrit;
        public DarkUI.Controls.DarkNumericUpDown nudEnyAtk;
        public DarkUI.Controls.DarkNumericUpDown nudEnyDef;
        public DarkUI.Controls.DarkNumericUpDown nudEnyMAtk;
        public DarkUI.Controls.DarkNumericUpDown nudEnyMDef;
        public DarkUI.Controls.DarkNumericUpDown nudEnySpd;
        public DarkUI.Controls.DarkNumericUpDown nudEnyHp;
        public DarkUI.Controls.DarkNumericUpDown nudEnyBaseDmg;
        public DarkUI.Controls.DarkComboBox cboEnyScalStat;
        public DarkUI.Controls.DarkNumericUpDown nudEnyScalFac;
        public DarkUI.Controls.DarkNumericUpDown nudEnyCrit;
        public DarkUI.Controls.DarkGroupBox gbFunctions;
        public DarkUI.Controls.DarkButton btnUpdate;
        public DarkUI.Controls.DarkButton btnSave;
        public DarkUI.Controls.DarkButton btnLoad;
        public DarkUI.Controls.DarkButton btnPlyrGrid;
        public DarkUI.Controls.DarkButton btnEnyGrid;
        public DarkUI.Controls.DarkButton btnSummaryGrid;
        public System.Windows.Forms.DataGridView dgvPlyr;
        public System.Windows.Forms.DataGridView dgvEny;
        public System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyHitPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyMagicAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyMagicDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnySpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrTrueDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrCritTrueDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrRealDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrCritRealDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrHitsTrue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrHitsReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyTrueDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyCritTrueDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyRealDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyCritRealDmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyHitsTrue;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnyHitsReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrHitPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrMagicAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrMagicDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlyrExp;
    }
}

