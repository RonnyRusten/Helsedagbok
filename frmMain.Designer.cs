﻿namespace Helsedagbok
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.DiaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEditFood = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteFood = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFood = new System.Windows.Forms.ToolStripButton();
            this.btnNutritionDetails = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpFoodDiary = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCarbohydrates = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecepies = new System.Windows.Forms.DataGridView();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.miCopyMeal = new System.Windows.Forms.ToolStripMenuItem();
            this.miMoveMeal = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.cmFood.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpFoodDiary.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(6, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvDiary
            // 
            this.dgvDiary.AllowUserToAddRows = false;
            this.dgvDiary.AllowUserToDeleteRows = false;
            this.dgvDiary.AllowUserToOrderColumns = true;
            this.dgvDiary.AllowUserToResizeColumns = false;
            this.dgvDiary.AllowUserToResizeRows = false;
            this.dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiary.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDiary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiaryId,
            this.MealId,
            this.FoodId,
            this.FoodName,
            this.Energy});
            this.dgvDiary.ContextMenuStrip = this.cmFood;
            this.dgvDiary.Location = new System.Drawing.Point(6, 54);
            this.dgvDiary.MultiSelect = false;
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiary.Size = new System.Drawing.Size(492, 522);
            this.dgvDiary.TabIndex = 13;
            this.dgvDiary.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDiary_CellMouseDown);
            // 
            // DiaryId
            // 
            this.DiaryId.HeaderText = "DiaryId";
            this.DiaryId.Name = "DiaryId";
            // 
            // MealId
            // 
            this.MealId.HeaderText = "MealId";
            this.MealId.Name = "MealId";
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "FoodId";
            this.FoodId.Name = "FoodId";
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FoodName.HeaderText = "Name";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Energy
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Energy.DefaultCellStyle = dataGridViewCellStyle2;
            this.Energy.HeaderText = "Energy";
            this.Energy.Name = "Energy";
            // 
            // cmFood
            // 
            this.cmFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditFood,
            this.miDeleteFood,
            this.miCopyMeal,
            this.miMoveMeal});
            this.cmFood.Name = "cmMeals";
            this.cmFood.Size = new System.Drawing.Size(153, 114);
            this.cmFood.Opening += new System.ComponentModel.CancelEventHandler(this.cmFood_Opening);
            // 
            // miEditFood
            // 
            this.miEditFood.Name = "miEditFood";
            this.miEditFood.Size = new System.Drawing.Size(152, 22);
            this.miEditFood.Text = "Rediger";
            this.miEditFood.Click += new System.EventHandler(this.miEditFood_Click);
            // 
            // miDeleteFood
            // 
            this.miDeleteFood.Name = "miDeleteFood";
            this.miDeleteFood.Size = new System.Drawing.Size(152, 22);
            this.miDeleteFood.Text = "Slett";
            this.miDeleteFood.Click += new System.EventHandler(this.miDeleteFood_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(6, 3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 18);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFood,
            this.btnNutritionDetails,
            this.btnSettings,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFood
            // 
            this.btnAddFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFood.Image = global::Helsedagbok.Properties.Resources.Plus;
            this.btnAddFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(23, 22);
            this.btnAddFood.Text = "toolStripButton1";
            this.btnAddFood.ToolTipText = "Registrer måltid";
            this.btnAddFood.Click += new System.EventHandler(this.bntAddFood_Click);
            // 
            // btnNutritionDetails
            // 
            this.btnNutritionDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNutritionDetails.Image = global::Helsedagbok.Properties.Resources.Stats;
            this.btnNutritionDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNutritionDetails.Name = "btnNutritionDetails";
            this.btnNutritionDetails.Size = new System.Drawing.Size(23, 22);
            this.btnNutritionDetails.Text = "toolStripButton1";
            this.btnNutritionDetails.ToolTipText = "Detaljer om dagens måltid";
            this.btnNutritionDetails.Click += new System.EventHandler(this.btnNutritionDetails_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::Helsedagbok.Properties.Resources.Tool;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "toolStripButton1";
            this.btnSettings.ToolTipText = "Innstillinger";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpFoodDiary);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(12, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(872, 608);
            this.tabMain.TabIndex = 18;
            // 
            // tpFoodDiary
            // 
            this.tpFoodDiary.Controls.Add(this.lblUserName);
            this.tpFoodDiary.Controls.Add(this.dtpDate);
            this.tpFoodDiary.Controls.Add(this.dgvDiary);
            this.tpFoodDiary.Location = new System.Drawing.Point(4, 22);
            this.tpFoodDiary.Name = "tpFoodDiary";
            this.tpFoodDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodDiary.Size = new System.Drawing.Size(864, 582);
            this.tpFoodDiary.TabIndex = 0;
            this.tpFoodDiary.Text = "Matdagbok";
            this.tpFoodDiary.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.gbProperties);
            this.tabPage2.Controls.Add(this.dgvRecepies);
            this.tabPage2.Controls.Add(this.dgvCategories);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oppskrifter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(464, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(394, 393);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Fremgangsmåte:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 183);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(230, 393);
            this.dataGridView1.TabIndex = 4;
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.lblFat);
            this.gbProperties.Controls.Add(this.lblCarbohydrates);
            this.gbProperties.Controls.Add(this.lblProtein);
            this.gbProperties.Controls.Add(this.lblCalories);
            this.gbProperties.Controls.Add(this.lblServings);
            this.gbProperties.Controls.Add(this.lblTime);
            this.gbProperties.Controls.Add(this.lblCategories);
            this.gbProperties.Controls.Add(this.lblDifficulty);
            this.gbProperties.Controls.Add(this.label8);
            this.gbProperties.Controls.Add(this.label7);
            this.gbProperties.Controls.Add(this.label6);
            this.gbProperties.Controls.Add(this.label5);
            this.gbProperties.Controls.Add(this.label4);
            this.gbProperties.Controls.Add(this.label3);
            this.gbProperties.Controls.Add(this.label2);
            this.gbProperties.Controls.Add(this.label1);
            this.gbProperties.Location = new System.Drawing.Point(228, 32);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(230, 145);
            this.gbProperties.TabIndex = 3;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Informasjon";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(109, 129);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(32, 13);
            this.lblFat.TabIndex = 34;
            this.lblFat.Text = "lblFat";
            // 
            // lblCarbohydrates
            // 
            this.lblCarbohydrates.AutoSize = true;
            this.lblCarbohydrates.Location = new System.Drawing.Point(109, 115);
            this.lblCarbohydrates.Name = "lblCarbohydrates";
            this.lblCarbohydrates.Size = new System.Drawing.Size(85, 13);
            this.lblCarbohydrates.TabIndex = 33;
            this.lblCarbohydrates.Text = "lblCarbohydrates";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(109, 102);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(50, 13);
            this.lblProtein.TabIndex = 32;
            this.lblProtein.Text = "lblProtein";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(109, 89);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(54, 13);
            this.lblCalories.TabIndex = 31;
            this.lblCalories.Text = "lblCalories";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(109, 55);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(58, 13);
            this.lblServings.TabIndex = 30;
            this.lblServings.Text = "lblServings";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(109, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 13);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "lblTime";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(109, 16);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(67, 13);
            this.lblCategories.TabIndex = 28;
            this.lblCategories.Text = "lblCategories";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(109, 42);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(57, 13);
            this.lblDifficulty.TabIndex = 27;
            this.lblDifficulty.Text = "lblDifficulty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fett:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Karbohydrat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Protein:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kalorier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Porsjoner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vanskelighetsgrad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tidsbruk:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori(er):";
            // 
            // dgvRecepies
            // 
            this.dgvRecepies.AllowUserToAddRows = false;
            this.dgvRecepies.AllowUserToDeleteRows = false;
            this.dgvRecepies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecepies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecepies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepies.Location = new System.Drawing.Point(6, 183);
            this.dgvRecepies.MultiSelect = false;
            this.dgvRecepies.Name = "dgvRecepies";
            this.dgvRecepies.ReadOnly = true;
            this.dgvRecepies.RowHeadersVisible = false;
            this.dgvRecepies.Size = new System.Drawing.Size(216, 393);
            this.dgvRecepies.TabIndex = 2;
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(6, 32);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.Size = new System.Drawing.Size(216, 145);
            this.dgvCategories.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            // 
            // miCopyMeal
            // 
            this.miCopyMeal.Name = "miCopyMeal";
            this.miCopyMeal.Size = new System.Drawing.Size(152, 22);
            this.miCopyMeal.Text = "Kopier måltid";
            this.miCopyMeal.Click += new System.EventHandler(this.miCopyMeal_Click);
            // 
            // miMoveMeal
            // 
            this.miMoveMeal.Name = "miMoveMeal";
            this.miMoveMeal.Size = new System.Drawing.Size(152, 22);
            this.miMoveMeal.Text = "Flytt måltid";
            this.miMoveMeal.Click += new System.EventHandler(this.miMoveMeal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 648);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Matdagbok";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.cmFood.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tpFoodDiary.ResumeLayout(false);
            this.tpFoodDiary.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFood;
        private System.Windows.Forms.ToolStripButton btnNutritionDetails;
        private System.Windows.Forms.ContextMenuStrip cmFood;
        private System.Windows.Forms.ToolStripMenuItem miEditFood;
        private System.Windows.Forms.ToolStripMenuItem miDeleteFood;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpFoodDiary;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvRecepies;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblCarbohydrates;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ToolStripMenuItem miCopyMeal;
        private System.Windows.Forms.ToolStripMenuItem miMoveMeal;
    }
}

