namespace Helsedagbok.User_Controls
{
    partial class UcRecepieIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRecepieIngredient));
            this.lblAntall = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblAntall
            // 
            this.lblAntall.Location = new System.Drawing.Point(0, 0);
            this.lblAntall.Margin = new System.Windows.Forms.Padding(0);
            this.lblAntall.Name = "lblAntall";
            this.lblAntall.Size = new System.Drawing.Size(25, 23);
            this.lblAntall.TabIndex = 0;
            this.lblAntall.Text = "999";
            this.lblAntall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(25, 0);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(25, 23);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "stk.";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIngredient
            // 
            this.lblIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngredient.Location = new System.Drawing.Point(50, 0);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(236, 23);
            this.lblIngredient.TabIndex = 2;
            this.lblIngredient.Text = "stk.";
            this.lblIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.ico");
            this.imageList1.Images.SetKeyName(1, "Trash.ico");
            this.imageList1.Images.SetKeyName(2, "Write.ico");
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ImageKey = "Write.ico";
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(287, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 23);
            this.btnEdit.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEdit, "Rediger ingrediens");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageKey = "Cancel.ico";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(310, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 23);
            this.btnDelete.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnDelete, "Slett ingrediens");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UcRecepieIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblAntall);
            this.Name = "UcRecepieIngredient";
            this.Size = new System.Drawing.Size(333, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAntall;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
