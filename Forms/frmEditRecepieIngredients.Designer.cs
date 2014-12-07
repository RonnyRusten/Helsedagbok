namespace Helsedagbok
{
    partial class FrmEditRecepieIngredients
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.lblFoodCount = new System.Windows.Forms.Label();
            this.txtFoodFilter = new System.Windows.Forms.TextBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblFoodId = new System.Windows.Forms.Label();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.ColumnHeadersVisible = false;
            this.dgvFood.Location = new System.Drawing.Point(12, 38);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(270, 128);
            this.dgvFood.TabIndex = 23;
            this.dgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFood_CellFormatting);
            // 
            // lblFoodCount
            // 
            this.lblFoodCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodCount.AutoSize = true;
            this.lblFoodCount.Location = new System.Drawing.Point(189, 15);
            this.lblFoodCount.Name = "lblFoodCount";
            this.lblFoodCount.Size = new System.Drawing.Size(35, 13);
            this.lblFoodCount.TabIndex = 25;
            this.lblFoodCount.Text = "label1";
            // 
            // txtFoodFilter
            // 
            this.txtFoodFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFoodFilter.Name = "txtFoodFilter";
            this.txtFoodFilter.Size = new System.Drawing.Size(171, 20);
            this.txtFoodFilter.TabIndex = 24;
            this.txtFoodFilter.TextChanged += new System.EventHandler(this.txtFoodFilter_TextChanged);
            // 
            // cmbUnits
            // 
            this.cmbUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnits.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.ItemHeight = 14;
            this.cmbUnits.Location = new System.Drawing.Point(154, 172);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(128, 22);
            this.cmbUnits.TabIndex = 28;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(61, 174);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 20);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFoodId
            // 
            this.lblFoodId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodId.AutoSize = true;
            this.lblFoodId.Location = new System.Drawing.Point(9, 177);
            this.lblFoodId.Name = "lblFoodId";
            this.lblFoodId.Size = new System.Drawing.Size(46, 13);
            this.lblFoodId.TabIndex = 26;
            this.lblFoodId.Text = "Mengde";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFood.Location = new System.Drawing.Point(105, 200);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(96, 23);
            this.btnEditFood.TabIndex = 29;
            this.btnEditFood.Text = "Rediger matvare";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Location = new System.Drawing.Point(207, 200);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 30;
            this.btnAddFood.Text = "Ny matvare";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(207, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Lukk";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIngredient.Location = new System.Drawing.Point(126, 229);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 31;
            this.btnAddIngredient.Text = "Legg til";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // FrmEditRecepieIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 264);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblFoodId);
            this.Controls.Add(this.lblFoodCount);
            this.Controls.Add(this.txtFoodFilter);
            this.Controls.Add(this.dgvFood);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "FrmEditRecepieIngredients";
            this.Text = "Ingredienser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditRecepieIngredients_FormClosing);
            this.Load += new System.EventHandler(this.frmEditRecepieIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label lblFoodCount;
        private System.Windows.Forms.TextBox txtFoodFilter;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblFoodId;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddIngredient;
    }
}