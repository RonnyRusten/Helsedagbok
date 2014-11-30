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
            this.components = new System.ComponentModel.Container();
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mAddExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.mRenameWorkout = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeleteWorkout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAction = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblWorkoutName.ContextMenuStrip = this.contextMenuStrip1;
            this.lblWorkoutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorkoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(0, 0);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(413, 26);
            this.lblWorkoutName.TabIndex = 0;
            this.lblWorkoutName.Text = "label1";
            this.lblWorkoutName.UseMnemonic = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddExercise,
            this.mRenameWorkout,
            this.mDeleteWorkout});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 92);
            // 
            // mAddExercise
            // 
            this.mAddExercise.Name = "mAddExercise";
            this.mAddExercise.Size = new System.Drawing.Size(196, 22);
            this.mAddExercise.Text = "Legg til øvelse";
            this.mAddExercise.Click += new System.EventHandler(this.mAddExercise_Click);
            // 
            // mRenameWorkout
            // 
            this.mRenameWorkout.Name = "mRenameWorkout";
            this.mRenameWorkout.Size = new System.Drawing.Size(196, 22);
            this.mRenameWorkout.Text = "Nytt navn på treningen";
            this.mRenameWorkout.Click += new System.EventHandler(this.mRenameWorkout_Click);
            // 
            // mDeleteWorkout
            // 
            this.mDeleteWorkout.Name = "mDeleteWorkout";
            this.mDeleteWorkout.Size = new System.Drawing.Size(196, 22);
            this.mDeleteWorkout.Text = "Slett treningen";
            this.mDeleteWorkout.Click += new System.EventHandler(this.mDeleteWorkout_Click);
            // 
            // btnAction
            // 
            this.btnAction.Image = global::Helsedagbok.Properties.Resources.Tool;
            this.btnAction.Location = new System.Drawing.Point(386, 1);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(23, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // ucWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblWorkoutName);
            this.Name = "ucWorkout";
            this.Size = new System.Drawing.Size(413, 52);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWorkoutName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAddExercise;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ToolStripMenuItem mRenameWorkout;
        private System.Windows.Forms.ToolStripMenuItem mDeleteWorkout;
    }
}
