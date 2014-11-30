namespace Helsedagbok.Forms
{
    partial class frmEditExercise
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
            this.dgvExercises = new System.Windows.Forms.DataGridView();
            this.cmsExercises = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miNewExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).BeginInit();
            this.cmsExercises.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExercises
            // 
            this.dgvExercises.AllowUserToAddRows = false;
            this.dgvExercises.AllowUserToDeleteRows = false;
            this.dgvExercises.AllowUserToOrderColumns = true;
            this.dgvExercises.AllowUserToResizeRows = false;
            this.dgvExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExercises.ContextMenuStrip = this.cmsExercises;
            this.dgvExercises.Location = new System.Drawing.Point(12, 38);
            this.dgvExercises.Name = "dgvExercises";
            this.dgvExercises.RowHeadersVisible = false;
            this.dgvExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExercises.Size = new System.Drawing.Size(240, 363);
            this.dgvExercises.TabIndex = 0;
            this.dgvExercises.SelectionChanged += new System.EventHandler(this.dgvExercises_SelectionChanged);
            // 
            // cmsExercises
            // 
            this.cmsExercises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewExercise});
            this.cmsExercises.Name = "cmsExercises";
            this.cmsExercises.Size = new System.Drawing.Size(126, 26);
            // 
            // miNewExercise
            // 
            this.miNewExercise.Name = "miNewExercise";
            this.miNewExercise.Size = new System.Drawing.Size(125, 22);
            this.miNewExercise.Text = "Ny øvelse";
            this.miNewExercise.Click += new System.EventHandler(this.miNewExercise_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(305, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmEditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvExercises);
            this.Name = "frmEditExercise";
            this.Text = "Ny øvelse";
            this.Load += new System.EventHandler(this.frmEditExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).EndInit();
            this.cmsExercises.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExercises;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsExercises;
        private System.Windows.Forms.ToolStripMenuItem miNewExercise;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}