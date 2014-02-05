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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.DiaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAddFood = new System.Windows.Forms.Button();
            this.btnNutritionDetails = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 51);
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
            this.FoodName,
            this.Energy});
            this.dgvDiary.Location = new System.Drawing.Point(12, 81);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.Size = new System.Drawing.Size(491, 555);
            this.dgvDiary.TabIndex = 13;
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
            // bntAddFood
            // 
            this.bntAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAddFood.Location = new System.Drawing.Point(428, 52);
            this.bntAddFood.Name = "bntAddFood";
            this.bntAddFood.Size = new System.Drawing.Size(75, 23);
            this.bntAddFood.TabIndex = 14;
            this.bntAddFood.Text = "Legg til";
            this.bntAddFood.UseVisualStyleBackColor = true;
            this.bntAddFood.Click += new System.EventHandler(this.bntAddFood_Click);
            // 
            // btnNutritionDetails
            // 
            this.btnNutritionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNutritionDetails.Location = new System.Drawing.Point(347, 52);
            this.btnNutritionDetails.Name = "btnNutritionDetails";
            this.btnNutritionDetails.Size = new System.Drawing.Size(75, 23);
            this.btnNutritionDetails.TabIndex = 15;
            this.btnNutritionDetails.Text = "Detaljer";
            this.btnNutritionDetails.UseVisualStyleBackColor = true;
            this.btnNutritionDetails.Click += new System.EventHandler(this.btnNutritionDetails_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 18);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(876, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 648);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnNutritionDetails);
            this.Controls.Add(this.bntAddFood);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.dtpDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Matdagbok";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.Button bntAddFood;
        private System.Windows.Forms.Button btnNutritionDetails;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

