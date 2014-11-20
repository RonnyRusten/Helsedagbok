namespace Helsedagbok
{
    partial class ucExercise
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExerciseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseName.Location = new System.Drawing.Point(0, 0);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(413, 20);
            this.lblExerciseName.TabIndex = 1;
            this.lblExerciseName.Text = "label1";
            // 
            // ucExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblExerciseName);
            this.Name = "ucExercise";
            this.Size = new System.Drawing.Size(413, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExerciseName;
    }
}
