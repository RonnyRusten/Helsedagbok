namespace Helsedagbok
{
    partial class frmEditDiary
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDiary));
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblFoodId = new System.Windows.Forms.Label();
            this.lb_mealTypes = new System.Windows.Forms.ListBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.lblAlcoholEnergy = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblFatSatEnergy = new System.Windows.Forms.Label();
            this.lblFatMonoEnergy = new System.Windows.Forms.Label();
            this.lblFatPolyEnergy = new System.Windows.Forms.Label();
            this.lblFatTransEnergy = new System.Windows.Forms.Label();
            this.lblFatEnergy = new System.Windows.Forms.Label();
            this.lblProtEnergy = new System.Windows.Forms.Label();
            this.lblCarbsEnergy = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFatTrans = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFatPolyUnsat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFatMonoUnsat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFatSat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotEnergy = new System.Windows.Forms.Label();
            this.pcNutrition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.lblFoodCount = new System.Windows.Forms.Label();
            this.txtFoodFilter = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotWeight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcNutrition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUnits
            // 
            this.cmbUnits.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.ItemHeight = 14;
            this.cmbUnits.Location = new System.Drawing.Point(428, 62);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(69, 22);
            this.cmbUnits.TabIndex = 10;
            this.cmbUnits.SelectedIndexChanged += new System.EventHandler(this.cmbUnits_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(335, 64);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblFoodId
            // 
            this.lblFoodId.AutoSize = true;
            this.lblFoodId.Location = new System.Drawing.Point(283, 67);
            this.lblFoodId.Name = "lblFoodId";
            this.lblFoodId.Size = new System.Drawing.Size(46, 13);
            this.lblFoodId.TabIndex = 8;
            this.lblFoodId.Text = "Mengde";
            // 
            // lb_mealTypes
            // 
            this.lb_mealTypes.FormattingEnabled = true;
            this.lb_mealTypes.Location = new System.Drawing.Point(286, 90);
            this.lb_mealTypes.Name = "lb_mealTypes";
            this.lb_mealTypes.Size = new System.Drawing.Size(139, 121);
            this.lb_mealTypes.TabIndex = 7;
            this.lb_mealTypes.Click += new System.EventHandler(this.lb_mealTypes_Click);
            this.lb_mealTypes.SelectedIndexChanged += new System.EventHandler(this.lb_mealTypes_SelectedIndexChanged);
            // 
            // lblFoodName
            // 
            this.lblFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodName.AutoEllipsis = true;
            this.lblFoodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(283, 9);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(359, 20);
            this.lblFoodName.TabIndex = 11;
            this.lblFoodName.Text = "lblFoodName";
            this.lblFoodName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEditFood);
            this.groupBox1.Controls.Add(this.lblAlcoholEnergy);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lblAlcohol);
            this.groupBox1.Controls.Add(this.lblFatSatEnergy);
            this.groupBox1.Controls.Add(this.lblFatMonoEnergy);
            this.groupBox1.Controls.Add(this.lblFatPolyEnergy);
            this.groupBox1.Controls.Add(this.lblFatTransEnergy);
            this.groupBox1.Controls.Add(this.lblFatEnergy);
            this.groupBox1.Controls.Add(this.lblProtEnergy);
            this.groupBox1.Controls.Add(this.lblCarbsEnergy);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblFatTrans);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblFatPolyUnsat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblFatMonoUnsat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblFatSat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCarbs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblProtein);
            this.groupBox1.Location = new System.Drawing.Point(286, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 159);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Makroer";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(6, 131);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(96, 23);
            this.btnEditFood.TabIndex = 25;
            this.btnEditFood.Text = "Rediger matvare";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // lblAlcoholEnergy
            // 
            this.lblAlcoholEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcoholEnergy.Location = new System.Drawing.Point(169, 114);
            this.lblAlcoholEnergy.Name = "lblAlcoholEnergy";
            this.lblAlcoholEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblAlcoholEnergy.TabIndex = 46;
            this.lblAlcoholEnergy.Text = "lblAlcoholEnergy";
            this.lblAlcoholEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(150, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "g";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 14);
            this.label19.TabIndex = 44;
            this.label19.Text = "Alkohol";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcohol.Location = new System.Drawing.Point(98, 114);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(51, 14);
            this.lblAlcohol.TabIndex = 43;
            this.lblAlcohol.Text = "lblAlcohol";
            this.lblAlcohol.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFatSatEnergy
            // 
            this.lblFatSatEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatSatEnergy.Location = new System.Drawing.Point(169, 58);
            this.lblFatSatEnergy.Name = "lblFatSatEnergy";
            this.lblFatSatEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblFatSatEnergy.TabIndex = 42;
            this.lblFatSatEnergy.Text = "lblFatSatEnergy";
            this.lblFatSatEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFatMonoEnergy
            // 
            this.lblFatMonoEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatMonoEnergy.Location = new System.Drawing.Point(169, 72);
            this.lblFatMonoEnergy.Name = "lblFatMonoEnergy";
            this.lblFatMonoEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblFatMonoEnergy.TabIndex = 41;
            this.lblFatMonoEnergy.Text = "lblFatMonoEnergy";
            this.lblFatMonoEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFatPolyEnergy
            // 
            this.lblFatPolyEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatPolyEnergy.Location = new System.Drawing.Point(169, 86);
            this.lblFatPolyEnergy.Name = "lblFatPolyEnergy";
            this.lblFatPolyEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblFatPolyEnergy.TabIndex = 40;
            this.lblFatPolyEnergy.Text = "lblFatPolyEnergy";
            this.lblFatPolyEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFatTransEnergy
            // 
            this.lblFatTransEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatTransEnergy.Location = new System.Drawing.Point(169, 100);
            this.lblFatTransEnergy.Name = "lblFatTransEnergy";
            this.lblFatTransEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblFatTransEnergy.TabIndex = 39;
            this.lblFatTransEnergy.Text = "lblFatTransEnergy";
            this.lblFatTransEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFatEnergy
            // 
            this.lblFatEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatEnergy.Location = new System.Drawing.Point(169, 44);
            this.lblFatEnergy.Name = "lblFatEnergy";
            this.lblFatEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblFatEnergy.TabIndex = 38;
            this.lblFatEnergy.Text = "lblFatEnergy";
            this.lblFatEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProtEnergy
            // 
            this.lblProtEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtEnergy.Location = new System.Drawing.Point(169, 30);
            this.lblProtEnergy.Name = "lblProtEnergy";
            this.lblProtEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblProtEnergy.TabIndex = 37;
            this.lblProtEnergy.Text = "lblProtEnergy";
            this.lblProtEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCarbsEnergy
            // 
            this.lblCarbsEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbsEnergy.Location = new System.Drawing.Point(169, 16);
            this.lblCarbsEnergy.Name = "lblCarbsEnergy";
            this.lblCarbsEnergy.Size = new System.Drawing.Size(97, 14);
            this.lblCarbsEnergy.TabIndex = 36;
            this.lblCarbsEnergy.Text = "lblCarbsEnergy";
            this.lblCarbsEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(150, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 14);
            this.label17.TabIndex = 35;
            this.label17.Text = "g";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 14);
            this.label18.TabIndex = 34;
            this.label18.Text = "Transfett";
            // 
            // lblFatTrans
            // 
            this.lblFatTrans.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatTrans.Location = new System.Drawing.Point(98, 100);
            this.lblFatTrans.Name = "lblFatTrans";
            this.lblFatTrans.Size = new System.Drawing.Size(51, 14);
            this.lblFatTrans.TabIndex = 33;
            this.lblFatTrans.Text = "lblFatTrans";
            this.lblFatTrans.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(150, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 14);
            this.label14.TabIndex = 32;
            this.label14.Text = "g";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 14);
            this.label15.TabIndex = 31;
            this.label15.Text = "Flerumettet fett";
            // 
            // lblFatPolyUnsat
            // 
            this.lblFatPolyUnsat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatPolyUnsat.Location = new System.Drawing.Point(98, 86);
            this.lblFatPolyUnsat.Name = "lblFatPolyUnsat";
            this.lblFatPolyUnsat.Size = new System.Drawing.Size(51, 14);
            this.lblFatPolyUnsat.TabIndex = 30;
            this.lblFatPolyUnsat.Text = "lblFatPolyUnsat";
            this.lblFatPolyUnsat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 14);
            this.label11.TabIndex = 29;
            this.label11.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Enumettet fett";
            // 
            // lblFatMonoUnsat
            // 
            this.lblFatMonoUnsat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatMonoUnsat.Location = new System.Drawing.Point(98, 72);
            this.lblFatMonoUnsat.Name = "lblFatMonoUnsat";
            this.lblFatMonoUnsat.Size = new System.Drawing.Size(51, 14);
            this.lblFatMonoUnsat.TabIndex = 27;
            this.lblFatMonoUnsat.Text = "lblFatMonoUnsat";
            this.lblFatMonoUnsat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "g";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mettet fett";
            // 
            // lblFatSat
            // 
            this.lblFatSat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatSat.Location = new System.Drawing.Point(98, 58);
            this.lblFatSat.Name = "lblFatSat";
            this.lblFatSat.Size = new System.Drawing.Size(51, 14);
            this.lblFatSat.TabIndex = 24;
            this.lblFatSat.Text = "lblFatSat";
            this.lblFatSat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Karbohydrat";
            // 
            // lblCarbs
            // 
            this.lblCarbs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.Location = new System.Drawing.Point(98, 16);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(51, 14);
            this.lblCarbs.TabIndex = 19;
            this.lblCarbs.Text = "lblCarbs";
            this.lblCarbs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fett";
            // 
            // lblFat
            // 
            this.lblFat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.Location = new System.Drawing.Point(98, 44);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(51, 14);
            this.lblFat.TabIndex = 17;
            this.lblFat.Text = "lblFat";
            this.lblFat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Protein";
            // 
            // lblProtein
            // 
            this.lblProtein.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.Location = new System.Drawing.Point(98, 30);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(51, 14);
            this.lblProtein.TabIndex = 15;
            this.lblProtein.Text = "lblProtein";
            this.lblProtein.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "=";
            // 
            // lblTotEnergy
            // 
            this.lblTotEnergy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotEnergy.Location = new System.Drawing.Point(598, 67);
            this.lblTotEnergy.Name = "lblTotEnergy";
            this.lblTotEnergy.Size = new System.Drawing.Size(44, 14);
            this.lblTotEnergy.TabIndex = 15;
            this.lblTotEnergy.Text = "lblTotEnergy";
            this.lblTotEnergy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pcNutrition
            // 
            this.pcNutrition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcNutrition.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "Default";
            this.pcNutrition.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pcNutrition.Legends.Add(legend1);
            this.pcNutrition.Location = new System.Drawing.Point(286, 382);
            this.pcNutrition.Name = "pcNutrition";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            this.pcNutrition.Series.Add(series1);
            this.pcNutrition.Size = new System.Drawing.Size(356, 151);
            this.pcNutrition.TabIndex = 17;
            this.pcNutrition.Text = "chart1";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(567, 539);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Legg til";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(286, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 20);
            this.dtpDate.TabIndex = 19;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFood.Location = new System.Drawing.Point(205, 539);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 23;
            this.btnAddFood.Text = "Ny matvare";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.ColumnHeadersVisible = false;
            this.dgvFood.Location = new System.Drawing.Point(15, 38);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(265, 495);
            this.dgvFood.TabIndex = 22;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            this.dgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFood_CellFormatting);
            this.dgvFood.MouseEnter += new System.EventHandler(this.dgvFood_MouseEnter);
            this.dgvFood.MouseLeave += new System.EventHandler(this.dgvFood_MouseLeave);
            // 
            // lblFoodCount
            // 
            this.lblFoodCount.AutoSize = true;
            this.lblFoodCount.Location = new System.Drawing.Point(189, 15);
            this.lblFoodCount.Name = "lblFoodCount";
            this.lblFoodCount.Size = new System.Drawing.Size(35, 13);
            this.lblFoodCount.TabIndex = 21;
            this.lblFoodCount.Text = "label1";
            // 
            // txtFoodFilter
            // 
            this.txtFoodFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFoodFilter.Name = "txtFoodFilter";
            this.txtFoodFilter.Size = new System.Drawing.Size(171, 20);
            this.txtFoodFilter.TabIndex = 20;
            this.txtFoodFilter.TextChanged += new System.EventHandler(this.txtFoodFilter_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(486, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Lukk";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotWeight
            // 
            this.lblTotWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotWeight.Location = new System.Drawing.Point(522, 67);
            this.lblTotWeight.Name = "lblTotWeight";
            this.lblTotWeight.Size = new System.Drawing.Size(70, 14);
            this.lblTotWeight.TabIndex = 25;
            this.lblTotWeight.Text = "(20000 g) =";
            this.lblTotWeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmEditDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 574);
            this.Controls.Add(this.lblTotWeight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.lblFoodCount);
            this.Controls.Add(this.txtFoodFilter);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pcNutrition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotEnergy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblFoodId);
            this.Controls.Add(this.lb_mealTypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 613);
            this.Name = "frmEditDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legg til matvare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditDiary_FormClosing);
            this.Load += new System.EventHandler(this.frmEditDiary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcNutrition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblFoodId;
        private System.Windows.Forms.ListBox lb_mealTypes;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFatTrans;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFatPolyUnsat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFatMonoUnsat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFatSat;
        private System.Windows.Forms.Label lblCarbsEnergy;
        private System.Windows.Forms.Label lblFatSatEnergy;
        private System.Windows.Forms.Label lblFatMonoEnergy;
        private System.Windows.Forms.Label lblFatPolyEnergy;
        private System.Windows.Forms.Label lblFatTransEnergy;
        private System.Windows.Forms.Label lblFatEnergy;
        private System.Windows.Forms.Label lblProtEnergy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotEnergy;
        private System.Windows.Forms.Label lblAlcoholEnergy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.DataVisualization.Charting.Chart pcNutrition;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label lblFoodCount;
        private System.Windows.Forms.TextBox txtFoodFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Label lblTotWeight;
    }
}