namespace Assignment5
{
    partial class ContactForm
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
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.lblContactDesc = new System.Windows.Forms.Label();
            this.txtEmailWork = new System.Windows.Forms.TextBox();
            this.lblEmailWork = new System.Windows.Forms.Label();
            this.txtEmailPrivate = new System.Windows.Forms.TextBox();
            this.lblEmailPrivate = new System.Windows.Forms.Label();
            this.txtPhoneWork = new System.Windows.Forms.TextBox();
            this.lblPhoneWork = new System.Windows.Forms.Label();
            this.txtPhonePrivate = new System.Windows.Forms.TextBox();
            this.lblPhonePrivate = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpName.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtLName);
            this.grpName.Controls.Add(this.lblLName);
            this.grpName.Controls.Add(this.txtFName);
            this.grpName.Controls.Add(this.lblFName);
            this.grpName.Location = new System.Drawing.Point(13, 13);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(418, 73);
            this.grpName.TabIndex = 0;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(163, 44);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(249, 20);
            this.txtLName.TabIndex = 3;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(7, 47);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(163, 12);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(249, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(7, 20);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.lblContactDesc);
            this.grpContact.Controls.Add(this.txtEmailWork);
            this.grpContact.Controls.Add(this.lblEmailWork);
            this.grpContact.Controls.Add(this.txtEmailPrivate);
            this.grpContact.Controls.Add(this.lblEmailPrivate);
            this.grpContact.Controls.Add(this.txtPhoneWork);
            this.grpContact.Controls.Add(this.lblPhoneWork);
            this.grpContact.Controls.Add(this.txtPhonePrivate);
            this.grpContact.Controls.Add(this.lblPhonePrivate);
            this.grpContact.Location = new System.Drawing.Point(13, 93);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(416, 138);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact Information";
            // 
            // lblContactDesc
            // 
            this.lblContactDesc.AutoSize = true;
            this.lblContactDesc.Location = new System.Drawing.Point(7, 118);
            this.lblContactDesc.Name = "lblContactDesc";
            this.lblContactDesc.Size = new System.Drawing.Size(412, 13);
            this.lblContactDesc.TabIndex = 8;
            this.lblContactDesc.Text = "Contact information can be separated by semi-colon to add multiple numbers or ema" +
    "ils.";
            // 
            // txtEmailWork
            // 
            this.txtEmailWork.Location = new System.Drawing.Point(163, 95);
            this.txtEmailWork.Name = "txtEmailWork";
            this.txtEmailWork.Size = new System.Drawing.Size(249, 20);
            this.txtEmailWork.TabIndex = 7;
            this.txtEmailWork.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblEmailWork
            // 
            this.lblEmailWork.AutoSize = true;
            this.lblEmailWork.Location = new System.Drawing.Point(7, 98);
            this.lblEmailWork.Name = "lblEmailWork";
            this.lblEmailWork.Size = new System.Drawing.Size(64, 13);
            this.lblEmailWork.TabIndex = 6;
            this.lblEmailWork.Text = "Email, Work";
            // 
            // txtEmailPrivate
            // 
            this.txtEmailPrivate.Location = new System.Drawing.Point(163, 67);
            this.txtEmailPrivate.Name = "txtEmailPrivate";
            this.txtEmailPrivate.Size = new System.Drawing.Size(249, 20);
            this.txtEmailPrivate.TabIndex = 5;
            this.txtEmailPrivate.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblEmailPrivate
            // 
            this.lblEmailPrivate.AutoSize = true;
            this.lblEmailPrivate.Location = new System.Drawing.Point(7, 74);
            this.lblEmailPrivate.Name = "lblEmailPrivate";
            this.lblEmailPrivate.Size = new System.Drawing.Size(71, 13);
            this.lblEmailPrivate.TabIndex = 4;
            this.lblEmailPrivate.Text = "Email, Private";
            // 
            // txtPhoneWork
            // 
            this.txtPhoneWork.Location = new System.Drawing.Point(163, 41);
            this.txtPhoneWork.Name = "txtPhoneWork";
            this.txtPhoneWork.Size = new System.Drawing.Size(249, 20);
            this.txtPhoneWork.TabIndex = 3;
            this.txtPhoneWork.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblPhoneWork
            // 
            this.lblPhoneWork.AutoSize = true;
            this.lblPhoneWork.Location = new System.Drawing.Point(7, 44);
            this.lblPhoneWork.Name = "lblPhoneWork";
            this.lblPhoneWork.Size = new System.Drawing.Size(70, 13);
            this.lblPhoneWork.TabIndex = 2;
            this.lblPhoneWork.Text = "Phone, Work";
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(163, 13);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(249, 20);
            this.txtPhonePrivate.TabIndex = 1;
            this.txtPhonePrivate.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblPhonePrivate
            // 
            this.lblPhonePrivate.AutoSize = true;
            this.lblPhonePrivate.Location = new System.Drawing.Point(7, 20);
            this.lblPhonePrivate.Name = "lblPhonePrivate";
            this.lblPhonePrivate.Size = new System.Drawing.Size(77, 13);
            this.lblPhonePrivate.TabIndex = 0;
            this.lblPhonePrivate.Text = "Phone, Private";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.cmbCountry);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.lblZip);
            this.grpAddress.Controls.Add(this.txtZip);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Location = new System.Drawing.Point(13, 238);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(416, 127);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(163, 99);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(249, 21);
            this.cmbCountry.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(7, 99);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(7, 73);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(50, 13);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(163, 66);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(249, 20);
            this.txtZip.TabIndex = 4;
            this.txtZip.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 46);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(163, 39);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(249, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(163, 12);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(249, 20);
            this.txtStreet.TabIndex = 1;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(7, 20);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(280, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(13, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // ContactForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 403);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpName);
            this.Name = "ContactForm";
            this.Text = "Register contact data";
            this.TopMost = true;
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtPhoneWork;
        private System.Windows.Forms.Label lblPhoneWork;
        private System.Windows.Forms.TextBox txtPhonePrivate;
        private System.Windows.Forms.Label lblPhonePrivate;
        private System.Windows.Forms.Label lblContactDesc;
        private System.Windows.Forms.TextBox txtEmailWork;
        private System.Windows.Forms.Label lblEmailWork;
        private System.Windows.Forms.TextBox txtEmailPrivate;
        private System.Windows.Forms.Label lblEmailPrivate;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}