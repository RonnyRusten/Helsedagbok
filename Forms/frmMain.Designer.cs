namespace Helsedagbok
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
            this.miCopyMeal = new System.Windows.Forms.ToolStripMenuItem();
            this.miMoveMeal = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpFoodDiary = new System.Windows.Forms.TabPage();
            this.btnNutritionDetails = new System.Windows.Forms.Button();
            this.ilBig = new System.Windows.Forms.ImageList(this.components);
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tpRecepies = new System.Windows.Forms.TabPage();
            this.pnlRecepieIngredients = new System.Windows.Forms.Panel();
            this.btnAddRecepie = new System.Windows.Forms.Button();
            this.lblRecepieName = new System.Windows.Forms.Label();
            this.btnRecepieSearch = new System.Windows.Forms.Button();
            this.btnAddRecepieIngredient = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.lblReceiptFat = new System.Windows.Forms.Label();
            this.lblReceiptCarbohydrates = new System.Windows.Forms.Label();
            this.lblReceiptProtein = new System.Windows.Forms.Label();
            this.lblReceiptCalories = new System.Windows.Forms.Label();
            this.lblRecepieServings = new System.Windows.Forms.Label();
            this.lblRecepieTime = new System.Windows.Forms.Label();
            this.lblRecepieCategories = new System.Windows.Forms.Label();
            this.lblRecepieDifficulty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpWorkout = new System.Windows.Forms.TabPage();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.il16 = new System.Windows.Forms.ImageList(this.components);
            this.pnlWorkouts = new System.Windows.Forms.Panel();
            this.dtpWorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.cmFood.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpFoodDiary.SuspendLayout();
            this.tpRecepies.SuspendLayout();
            this.gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpWorkout.SuspendLayout();
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
            this.dgvDiary.Size = new System.Drawing.Size(492, 538);
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
            this.cmFood.Size = new System.Drawing.Size(146, 92);
            this.cmFood.Opening += new System.ComponentModel.CancelEventHandler(this.cmFood_Opening);
            // 
            // miEditFood
            // 
            this.miEditFood.Name = "miEditFood";
            this.miEditFood.Size = new System.Drawing.Size(145, 22);
            this.miEditFood.Text = "Rediger";
            this.miEditFood.Click += new System.EventHandler(this.miEditFood_Click);
            // 
            // miDeleteFood
            // 
            this.miDeleteFood.Name = "miDeleteFood";
            this.miDeleteFood.Size = new System.Drawing.Size(145, 22);
            this.miDeleteFood.Text = "Slett";
            this.miDeleteFood.Click += new System.EventHandler(this.miDeleteFood_Click);
            // 
            // miCopyMeal
            // 
            this.miCopyMeal.Name = "miCopyMeal";
            this.miCopyMeal.Size = new System.Drawing.Size(145, 22);
            this.miCopyMeal.Text = "Kopier måltid";
            this.miCopyMeal.Click += new System.EventHandler(this.miCopyMeal_Click);
            // 
            // miMoveMeal
            // 
            this.miMoveMeal.Name = "miMoveMeal";
            this.miMoveMeal.Size = new System.Drawing.Size(145, 22);
            this.miMoveMeal.Text = "Flytt måltid";
            this.miMoveMeal.Click += new System.EventHandler(this.miMoveMeal_Click);
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
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpFoodDiary);
            this.tabMain.Controls.Add(this.tpRecepies);
            this.tabMain.Controls.Add(this.tpWorkout);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(872, 624);
            this.tabMain.TabIndex = 18;
            // 
            // tpFoodDiary
            // 
            this.tpFoodDiary.BackColor = System.Drawing.SystemColors.Control;
            this.tpFoodDiary.Controls.Add(this.btnNutritionDetails);
            this.tpFoodDiary.Controls.Add(this.btnAddFood);
            this.tpFoodDiary.Controls.Add(this.btnSettings);
            this.tpFoodDiary.Controls.Add(this.lblUserName);
            this.tpFoodDiary.Controls.Add(this.dtpDate);
            this.tpFoodDiary.Controls.Add(this.dgvDiary);
            this.tpFoodDiary.Location = new System.Drawing.Point(4, 22);
            this.tpFoodDiary.Name = "tpFoodDiary";
            this.tpFoodDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodDiary.Size = new System.Drawing.Size(864, 598);
            this.tpFoodDiary.TabIndex = 0;
            this.tpFoodDiary.Text = "Matdagbok";
            // 
            // btnNutritionDetails
            // 
            this.btnNutritionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNutritionDetails.ImageKey = "Stats.ico";
            this.btnNutritionDetails.ImageList = this.ilBig;
            this.btnNutritionDetails.Location = new System.Drawing.Point(773, 6);
            this.btnNutritionDetails.Name = "btnNutritionDetails";
            this.btnNutritionDetails.Size = new System.Drawing.Size(38, 38);
            this.btnNutritionDetails.TabIndex = 19;
            this.btnNutritionDetails.UseVisualStyleBackColor = true;
            this.btnNutritionDetails.Click += new System.EventHandler(this.btnNutritionDetails_Click);
            // 
            // ilBig
            // 
            this.ilBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBig.ImageStream")));
            this.ilBig.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBig.Images.SetKeyName(0, "Plus.ico");
            this.ilBig.Images.SetKeyName(1, "Search.ico");
            this.ilBig.Images.SetKeyName(2, "Stats.ico");
            this.ilBig.Images.SetKeyName(3, "Tool.ico");
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.ImageKey = "Plus.ico";
            this.btnAddFood.ImageList = this.ilBig;
            this.btnAddFood.Location = new System.Drawing.Point(729, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(38, 38);
            this.btnAddFood.TabIndex = 18;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.ImageKey = "Tool.ico";
            this.btnSettings.ImageList = this.ilBig;
            this.btnSettings.Location = new System.Drawing.Point(817, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(38, 38);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tpRecepies
            // 
            this.tpRecepies.Controls.Add(this.pnlRecepieIngredients);
            this.tpRecepies.Controls.Add(this.btnAddRecepie);
            this.tpRecepies.Controls.Add(this.lblRecepieName);
            this.tpRecepies.Controls.Add(this.btnRecepieSearch);
            this.tpRecepies.Controls.Add(this.btnAddRecepieIngredient);
            this.tpRecepies.Controls.Add(this.richTextBox1);
            this.tpRecepies.Controls.Add(this.gbProperties);
            this.tpRecepies.Controls.Add(this.pictureBox1);
            this.tpRecepies.Location = new System.Drawing.Point(4, 22);
            this.tpRecepies.Name = "tpRecepies";
            this.tpRecepies.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecepies.Size = new System.Drawing.Size(864, 598);
            this.tpRecepies.TabIndex = 1;
            this.tpRecepies.Text = "Oppskrifter";
            this.tpRecepies.UseVisualStyleBackColor = true;
            // 
            // pnlRecepieIngredients
            // 
            this.pnlRecepieIngredients.Location = new System.Drawing.Point(6, 201);
            this.pnlRecepieIngredients.Name = "pnlRecepieIngredients";
            this.pnlRecepieIngredients.Size = new System.Drawing.Size(333, 362);
            this.pnlRecepieIngredients.TabIndex = 22;
            // 
            // btnAddRecepie
            // 
            this.btnAddRecepie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRecepie.ImageKey = "Plus.ico";
            this.btnAddRecepie.ImageList = this.ilBig;
            this.btnAddRecepie.Location = new System.Drawing.Point(376, 6);
            this.btnAddRecepie.Name = "btnAddRecepie";
            this.btnAddRecepie.Size = new System.Drawing.Size(38, 38);
            this.btnAddRecepie.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnAddRecepie, "Legg til oppskrift");
            this.btnAddRecepie.UseVisualStyleBackColor = true;
            this.btnAddRecepie.Click += new System.EventHandler(this.btnAddRecepie_Click);
            // 
            // lblRecepieName
            // 
            this.lblRecepieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecepieName.Location = new System.Drawing.Point(6, 6);
            this.lblRecepieName.Name = "lblRecepieName";
            this.lblRecepieName.Size = new System.Drawing.Size(364, 29);
            this.lblRecepieName.TabIndex = 20;
            this.lblRecepieName.Text = "lblRecepieName";
            // 
            // btnRecepieSearch
            // 
            this.btnRecepieSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecepieSearch.ImageKey = "Search.ico";
            this.btnRecepieSearch.ImageList = this.ilBig;
            this.btnRecepieSearch.Location = new System.Drawing.Point(420, 6);
            this.btnRecepieSearch.Name = "btnRecepieSearch";
            this.btnRecepieSearch.Size = new System.Drawing.Size(38, 38);
            this.btnRecepieSearch.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnRecepieSearch, "Søk etter oppskrifter");
            this.btnRecepieSearch.UseVisualStyleBackColor = true;
            this.btnRecepieSearch.Click += new System.EventHandler(this.btnRecepieSearch_Click);
            // 
            // btnAddRecepieIngredient
            // 
            this.btnAddRecepieIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRecepieIngredient.Location = new System.Drawing.Point(235, 569);
            this.btnAddRecepieIngredient.Name = "btnAddRecepieIngredient";
            this.btnAddRecepieIngredient.Size = new System.Drawing.Size(104, 23);
            this.btnAddRecepieIngredient.TabIndex = 7;
            this.btnAddRecepieIngredient.Text = "Legg til ingrediens";
            this.btnAddRecepieIngredient.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(345, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 391);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Fremgangsmåte:";
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.lblReceiptFat);
            this.gbProperties.Controls.Add(this.lblReceiptCarbohydrates);
            this.gbProperties.Controls.Add(this.lblReceiptProtein);
            this.gbProperties.Controls.Add(this.lblReceiptCalories);
            this.gbProperties.Controls.Add(this.lblRecepieServings);
            this.gbProperties.Controls.Add(this.lblRecepieTime);
            this.gbProperties.Controls.Add(this.lblRecepieCategories);
            this.gbProperties.Controls.Add(this.lblRecepieDifficulty);
            this.gbProperties.Controls.Add(this.label8);
            this.gbProperties.Controls.Add(this.label7);
            this.gbProperties.Controls.Add(this.label6);
            this.gbProperties.Controls.Add(this.label5);
            this.gbProperties.Controls.Add(this.label4);
            this.gbProperties.Controls.Add(this.label3);
            this.gbProperties.Controls.Add(this.label2);
            this.gbProperties.Controls.Add(this.label1);
            this.gbProperties.Location = new System.Drawing.Point(6, 38);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(452, 157);
            this.gbProperties.TabIndex = 3;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Informasjon";
            // 
            // lblReceiptFat
            // 
            this.lblReceiptFat.AutoSize = true;
            this.lblReceiptFat.Location = new System.Drawing.Point(109, 129);
            this.lblReceiptFat.Name = "lblReceiptFat";
            this.lblReceiptFat.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptFat.TabIndex = 34;
            // 
            // lblReceiptCarbohydrates
            // 
            this.lblReceiptCarbohydrates.AutoSize = true;
            this.lblReceiptCarbohydrates.Location = new System.Drawing.Point(109, 115);
            this.lblReceiptCarbohydrates.Name = "lblReceiptCarbohydrates";
            this.lblReceiptCarbohydrates.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptCarbohydrates.TabIndex = 33;
            // 
            // lblReceiptProtein
            // 
            this.lblReceiptProtein.AutoSize = true;
            this.lblReceiptProtein.Location = new System.Drawing.Point(109, 102);
            this.lblReceiptProtein.Name = "lblReceiptProtein";
            this.lblReceiptProtein.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptProtein.TabIndex = 32;
            // 
            // lblReceiptCalories
            // 
            this.lblReceiptCalories.AutoSize = true;
            this.lblReceiptCalories.Location = new System.Drawing.Point(109, 89);
            this.lblReceiptCalories.Name = "lblReceiptCalories";
            this.lblReceiptCalories.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptCalories.TabIndex = 31;
            // 
            // lblRecepieServings
            // 
            this.lblRecepieServings.AutoSize = true;
            this.lblRecepieServings.Location = new System.Drawing.Point(109, 55);
            this.lblRecepieServings.Name = "lblRecepieServings";
            this.lblRecepieServings.Size = new System.Drawing.Size(0, 13);
            this.lblRecepieServings.TabIndex = 30;
            // 
            // lblRecepieTime
            // 
            this.lblRecepieTime.AutoSize = true;
            this.lblRecepieTime.Location = new System.Drawing.Point(109, 29);
            this.lblRecepieTime.Name = "lblRecepieTime";
            this.lblRecepieTime.Size = new System.Drawing.Size(0, 13);
            this.lblRecepieTime.TabIndex = 29;
            // 
            // lblRecepieCategories
            // 
            this.lblRecepieCategories.AutoSize = true;
            this.lblRecepieCategories.Location = new System.Drawing.Point(109, 16);
            this.lblRecepieCategories.Name = "lblRecepieCategories";
            this.lblRecepieCategories.Size = new System.Drawing.Size(0, 13);
            this.lblRecepieCategories.TabIndex = 28;
            // 
            // lblRecepieDifficulty
            // 
            this.lblRecepieDifficulty.AutoSize = true;
            this.lblRecepieDifficulty.Location = new System.Drawing.Point(109, 42);
            this.lblRecepieDifficulty.Name = "lblRecepieDifficulty";
            this.lblRecepieDifficulty.Size = new System.Drawing.Size(0, 13);
            this.lblRecepieDifficulty.TabIndex = 27;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(464, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpWorkout
            // 
            this.tpWorkout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpWorkout.Controls.Add(this.btnAddWorkout);
            this.tpWorkout.Controls.Add(this.pnlWorkouts);
            this.tpWorkout.Controls.Add(this.dtpWorkoutDate);
            this.tpWorkout.Location = new System.Drawing.Point(4, 22);
            this.tpWorkout.Name = "tpWorkout";
            this.tpWorkout.Size = new System.Drawing.Size(864, 598);
            this.tpWorkout.TabIndex = 2;
            this.tpWorkout.Text = "Trening";
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorkout.ImageKey = "Plus.ico";
            this.btnAddWorkout.ImageList = this.il16;
            this.btnAddWorkout.Location = new System.Drawing.Point(209, 7);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(24, 24);
            this.btnAddWorkout.TabIndex = 22;
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // il16
            // 
            this.il16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il16.ImageStream")));
            this.il16.TransparentColor = System.Drawing.Color.Transparent;
            this.il16.Images.SetKeyName(0, "Plus.ico");
            // 
            // pnlWorkouts
            // 
            this.pnlWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlWorkouts.AutoScroll = true;
            this.pnlWorkouts.Location = new System.Drawing.Point(3, 36);
            this.pnlWorkouts.Name = "pnlWorkouts";
            this.pnlWorkouts.Size = new System.Drawing.Size(436, 559);
            this.pnlWorkouts.TabIndex = 21;
            // 
            // dtpWorkoutDate
            // 
            this.dtpWorkoutDate.Location = new System.Drawing.Point(3, 10);
            this.dtpWorkoutDate.Name = "dtpWorkoutDate";
            this.dtpWorkoutDate.Size = new System.Drawing.Size(200, 20);
            this.dtpWorkoutDate.TabIndex = 9;
            this.dtpWorkoutDate.ValueChanged += new System.EventHandler(this.dtpWorkoutDate_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 648);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(912, 687);
            this.Name = "frmMain";
            this.Text = "Matdagbok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.cmFood.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tpFoodDiary.ResumeLayout(false);
            this.tpFoodDiary.PerformLayout();
            this.tpRecepies.ResumeLayout(false);
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpWorkout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ContextMenuStrip cmFood;
        private System.Windows.Forms.ToolStripMenuItem miEditFood;
        private System.Windows.Forms.ToolStripMenuItem miDeleteFood;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpFoodDiary;
        private System.Windows.Forms.TabPage tpRecepies;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReceiptFat;
        private System.Windows.Forms.Label lblReceiptCarbohydrates;
        private System.Windows.Forms.Label lblReceiptProtein;
        private System.Windows.Forms.Label lblReceiptCalories;
        private System.Windows.Forms.Label lblRecepieServings;
        private System.Windows.Forms.Label lblRecepieTime;
        private System.Windows.Forms.Label lblRecepieCategories;
        private System.Windows.Forms.Label lblRecepieDifficulty;
        private System.Windows.Forms.ToolStripMenuItem miCopyMeal;
        private System.Windows.Forms.ToolStripMenuItem miMoveMeal;
        private System.Windows.Forms.Button btnAddRecepieIngredient;
        private System.Windows.Forms.Button btnNutritionDetails;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TabPage tpWorkout;
        private System.Windows.Forms.DateTimePicker dtpWorkoutDate;
        private System.Windows.Forms.Panel pnlWorkouts;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.ImageList il16;
        private System.Windows.Forms.Button btnRecepieSearch;
        private System.Windows.Forms.ImageList ilBig;
        private System.Windows.Forms.Label lblRecepieName;
        private System.Windows.Forms.Button btnAddRecepie;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlRecepieIngredients;
    }
}

