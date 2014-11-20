namespace Helsedagbok
{
    partial class ucExerciseTotals
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(126, 1);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 23);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Totalt:";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(307, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 23);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReps
            // 
            this.lblReps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReps.Location = new System.Drawing.Point(193, 1);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(37, 23);
            this.lblReps.TabIndex = 15;
            this.lblReps.Text = "999";
            this.lblReps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucExerciseTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl);
            this.Name = "ucExerciseTotals";
            this.Size = new System.Drawing.Size(415, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblReps;
    }
}
