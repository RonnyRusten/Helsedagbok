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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucExercise));
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mNewSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeleteExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDown = new System.Windows.Forms.Button();
            this.btnCollapseExpand = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExerciseName.ContextMenuStrip = this.contextMenuStrip1;
            this.lblExerciseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseName.Location = new System.Drawing.Point(0, 0);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(413, 20);
            this.lblExerciseName.TabIndex = 1;
            this.lblExerciseName.Text = "label1";
            this.lblExerciseName.UseMnemonic = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNewSet,
            this.mDeleteExercise});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // mNewSet
            // 
            this.mNewSet.Name = "mNewSet";
            this.mNewSet.Size = new System.Drawing.Size(133, 22);
            this.mNewSet.Text = "Nytt sett";
            this.mNewSet.Click += new System.EventHandler(this.mNewSet_Click);
            // 
            // mDeleteExercise
            // 
            this.mDeleteExercise.Name = "mDeleteExercise";
            this.mDeleteExercise.Size = new System.Drawing.Size(133, 22);
            this.mDeleteExercise.Text = "Slett øvelse";
            this.mDeleteExercise.Click += new System.EventHandler(this.mDeleteExercise_Click);
            // 
            // btnUp
            // 
            this.btnUp.ImageKey = "Arrow1 Up.ico";
            this.btnUp.ImageList = this.imageList1;
            this.btnUp.Location = new System.Drawing.Point(392, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 20);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Arrow1 Down.ico");
            this.imageList1.Images.SetKeyName(1, "Arrow1 Up.ico");
            this.imageList1.Images.SetKeyName(2, "Arrow3 Down.ico");
            this.imageList1.Images.SetKeyName(3, "Arrow3 Up.ico");
            // 
            // btnDown
            // 
            this.btnDown.ImageKey = "Arrow1 Down.ico";
            this.btnDown.ImageList = this.imageList1;
            this.btnDown.Location = new System.Drawing.Point(370, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(20, 20);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnCollapseExpand
            // 
            this.btnCollapseExpand.ImageKey = "Arrow3 Up.ico";
            this.btnCollapseExpand.ImageList = this.imageList1;
            this.btnCollapseExpand.Location = new System.Drawing.Point(348, -1);
            this.btnCollapseExpand.Name = "btnCollapseExpand";
            this.btnCollapseExpand.Size = new System.Drawing.Size(20, 20);
            this.btnCollapseExpand.TabIndex = 4;
            this.btnCollapseExpand.UseVisualStyleBackColor = true;
            this.btnCollapseExpand.Click += new System.EventHandler(this.btnCollapseExpand_Click);
            // 
            // ucExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCollapseExpand);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblExerciseName);
            this.Name = "ucExercise";
            this.Size = new System.Drawing.Size(413, 78);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mNewSet;
        private System.Windows.Forms.ToolStripMenuItem mDeleteExercise;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCollapseExpand;
    }
}
