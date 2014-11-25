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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmsExercises = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miNewExercise = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvExercises.Size = new System.Drawing.Size(240, 363);
            this.dgvExercises.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmsExercises
            // 
            this.cmsExercises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewExercise});
            this.cmsExercises.Name = "cmsExercises";
            this.cmsExercises.Size = new System.Drawing.Size(153, 48);
            // 
            // miNewExercise
            // 
            this.miNewExercise.Name = "miNewExercise";
            this.miNewExercise.Size = new System.Drawing.Size(152, 22);
            this.miNewExercise.Text = "Ny øvelse";
            this.miNewExercise.Click += new System.EventHandler(this.miNewExercise_Click);
            // 
            // frmEditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 413);
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
    }
}