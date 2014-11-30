namespace Helsedagbok
{
    partial class ucSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSet));
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.Location = new System.Drawing.Point(231, 2);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 23);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "x";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(327, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReps
            // 
            this.txtReps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReps.Location = new System.Drawing.Point(201, 4);
            this.txtReps.Margin = new System.Windows.Forms.Padding(0);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(27, 20);
            this.txtReps.TabIndex = 6;
            this.txtReps.Text = "999";
            this.txtReps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReps.TextChanged += new System.EventHandler(this.txtReps_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeight.Location = new System.Drawing.Point(252, 4);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(0);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(44, 20);
            this.txtWeight.TabIndex = 7;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(348, 4);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(61, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageKey = "Trash.ico";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(1, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Trash.ico");
            this.imageList1.Images.SetKeyName(1, "Clipboard Copy.ico");
            this.imageList1.Images.SetKeyName(2, "Plus.ico");
            this.imageList1.Images.SetKeyName(3, "Write.ico");
            // 
            // btnCopy
            // 
            this.btnCopy.ImageKey = "Clipboard Copy.ico";
            this.btnCopy.ImageList = this.imageList1;
            this.btnCopy.Location = new System.Drawing.Point(26, 2);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(1);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageKey = "Plus.ico";
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(51, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNote
            // 
            this.btnNote.ImageKey = "Write.ico";
            this.btnNote.ImageList = this.imageList1;
            this.btnNote.Location = new System.Drawing.Point(76, 2);
            this.btnNote.Margin = new System.Windows.Forms.Padding(1);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(23, 23);
            this.btnNote.TabIndex = 12;
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // pnlNote
            // 
            this.pnlNote.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNote.Location = new System.Drawing.Point(103, 4);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(10, 20);
            this.pnlNote.TabIndex = 13;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(299, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "kg";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX);
            this.Name = "ucSet";
            this.Size = new System.Drawing.Size(410, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}
