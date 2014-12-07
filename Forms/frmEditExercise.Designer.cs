namespace Helsedagbok.Forms
{
    partial class FrmEditExercise
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
            this.cmbPrimaryMuscle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSecondaryMuscles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).BeginInit();
            this.cmsExercises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryMuscles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExercises
            // 
            this.dgvExercises.AllowUserToAddRows = false;
            this.dgvExercises.AllowUserToDeleteRows = false;
            this.dgvExercises.AllowUserToOrderColumns = true;
            this.dgvExercises.AllowUserToResizeRows = false;
            this.dgvExercises.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExercises.ContextMenuStrip = this.cmsExercises;
            this.dgvExercises.Location = new System.Drawing.Point(12, 38);
            this.dgvExercises.Name = "dgvExercises";
            this.dgvExercises.ReadOnly = true;
            this.dgvExercises.RowHeadersVisible = false;
            this.dgvExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExercises.Size = new System.Drawing.Size(240, 363);
            this.dgvExercises.TabIndex = 0;
            this.dgvExercises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExercises_CellDoubleClick);
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
            // cmbPrimaryMuscle
            // 
            this.cmbPrimaryMuscle.FormattingEnabled = true;
            this.cmbPrimaryMuscle.Location = new System.Drawing.Point(258, 38);
            this.cmbPrimaryMuscle.Name = "cmbPrimaryMuscle";
            this.cmbPrimaryMuscle.Size = new System.Drawing.Size(203, 21);
            this.cmbPrimaryMuscle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primærmuskel";
            // 
            // dgvSecondaryMuscles
            // 
            this.dgvSecondaryMuscles.AllowUserToAddRows = false;
            this.dgvSecondaryMuscles.AllowUserToDeleteRows = false;
            this.dgvSecondaryMuscles.AllowUserToOrderColumns = true;
            this.dgvSecondaryMuscles.AllowUserToResizeRows = false;
            this.dgvSecondaryMuscles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSecondaryMuscles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecondaryMuscles.ContextMenuStrip = this.cmsExercises;
            this.dgvSecondaryMuscles.Location = new System.Drawing.Point(258, 78);
            this.dgvSecondaryMuscles.Name = "dgvSecondaryMuscles";
            this.dgvSecondaryMuscles.ReadOnly = true;
            this.dgvSecondaryMuscles.RowHeadersVisible = false;
            this.dgvSecondaryMuscles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecondaryMuscles.Size = new System.Drawing.Size(203, 160);
            this.dgvSecondaryMuscles.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sekundærmuskler";
            // 
            // FrmEditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSecondaryMuscles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrimaryMuscle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvExercises);
            this.Name = "FrmEditExercise";
            this.Text = "Ny øvelse";
            this.Load += new System.EventHandler(this.frmEditExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).EndInit();
            this.cmsExercises.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryMuscles)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbPrimaryMuscle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSecondaryMuscles;
        private System.Windows.Forms.Label label2;
    }
}