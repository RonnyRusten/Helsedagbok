namespace Helsedagbok
{
    partial class ucWorkout
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
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblWorkoutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorkoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(0, 0);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(413, 24);
            this.lblWorkoutName.TabIndex = 0;
            this.lblWorkoutName.Text = "label1";
            // 
            // ucWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblWorkoutName);
            this.Name = "ucWorkout";
            this.Size = new System.Drawing.Size(413, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWorkoutName;
    }
}
