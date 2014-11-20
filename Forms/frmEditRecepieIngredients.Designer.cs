namespace Helsedagbok
{
    partial class frmEditRecepieIngredients
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
            this.dgvFood.Size = new System.Drawing.Size(270, 197);
            this.dgvFood.TabIndex = 23;
            this.dgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFood_CellFormatting);
            // 
            // lblFoodCount
            // 
            this.lblFoodCount.AutoSize = true;
            this.lblFoodCount.Location = new System.Drawing.Point(189, 15);
            this.lblFoodCount.Name = "lblFoodCount";
            this.lblFoodCount.Size = new System.Drawing.Size(35, 13);
            this.lblFoodCount.TabIndex = 25;
            this.lblFoodCount.Text = "label1";
            // 
            // txtFoodFilter
            // 
            this.txtFoodFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFoodFilter.Name = "txtFoodFilter";
            this.txtFoodFilter.Size = new System.Drawing.Size(171, 20);
            this.txtFoodFilter.TabIndex = 24;
            this.txtFoodFilter.TextChanged += new System.EventHandler(this.txtFoodFilter_TextChanged);
            // 
            // cmbUnits
            // 
            this.cmbUnits.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.ItemHeight = 14;
            this.cmbUnits.Location = new System.Drawing.Point(154, 242);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(128, 22);
            this.cmbUnits.TabIndex = 28;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(61, 244);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 20);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFoodId
            // 
            this.lblFoodId.AutoSize = true;
            this.lblFoodId.Location = new System.Drawing.Point(9, 247);
            this.lblFoodId.Name = "lblFoodId";
            this.lblFoodId.Size = new System.Drawing.Size(46, 13);
            this.lblFoodId.TabIndex = 26;
            this.lblFoodId.Text = "Mengde";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(105, 270);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(96, 23);
            this.btnEditFood.TabIndex = 29;
            this.btnEditFood.Text = "Rediger matvare";
            this.btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFood.Location = new System.Drawing.Point(207, 270);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 30;
            this.btnAddFood.Text = "Ny matvare";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // frmEditRecepieIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 399);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblFoodId);
            this.Controls.Add(this.lblFoodCount);
            this.Controls.Add(this.txtFoodFilter);
            this.Controls.Add(this.dgvFood);
            this.Name = "frmEditRecepieIngredients";
            this.Text = "Ingredienser";
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
    }
}