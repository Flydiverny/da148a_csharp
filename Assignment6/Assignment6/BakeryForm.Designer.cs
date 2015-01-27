namespace Assignment6
{
    partial class BakeryForm
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
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblUnitDesc = new System.Windows.Forms.Label();
            this.txtUnitCount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(13, 13);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(242, 13);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(233, 21);
            this.cmbItemType.TabIndex = 1;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.CmbItemTypeSelectedIndexChanged);
            // 
            // lblUnitDesc
            // 
            this.lblUnitDesc.AutoSize = true;
            this.lblUnitDesc.Location = new System.Drawing.Point(12, 44);
            this.lblUnitDesc.Name = "lblUnitDesc";
            this.lblUnitDesc.Size = new System.Drawing.Size(90, 13);
            this.lblUnitDesc.TabIndex = 2;
            this.lblUnitDesc.Text = "Number of pieces";
            // 
            // txtUnitCount
            // 
            this.txtUnitCount.Location = new System.Drawing.Point(412, 41);
            this.txtUnitCount.Name = "txtUnitCount";
            this.txtUnitCount.Size = new System.Drawing.Size(63, 20);
            this.txtUnitCount.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(412, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(63, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 71);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Cost per piece";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 95);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(463, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 125);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(463, 118);
            this.txtOutput.TabIndex = 7;
            // 
            // BakeryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 255);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUnitCount);
            this.Controls.Add(this.lblUnitDesc);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.lblItem);
            this.Name = "BakeryForm";
            this.Text = "Apu\'s Sweets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblUnitDesc;
        private System.Windows.Forms.TextBox txtUnitCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

