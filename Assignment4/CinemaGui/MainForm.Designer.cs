namespace CinemaGui
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.rdoCancel = new System.Windows.Forms.RadioButton();
            this.rdoReserve = new System.Windows.Forms.RadioButton();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblSeatsVacantNum = new System.Windows.Forms.Label();
            this.lblSeatsReservedNum = new System.Windows.Forms.Label();
            this.lblSeatsTotalNum = new System.Windows.Forms.Label();
            this.lblSeatsVacant = new System.Windows.Forms.Label();
            this.lblSeatsReserved = new System.Windows.Forms.Label();
            this.lblSeatsTotal = new System.Windows.Forms.Label();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lstReservations = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBooking.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.btnConfirm);
            this.grpBooking.Controls.Add(this.lblPrice);
            this.grpBooking.Controls.Add(this.txtPrice);
            this.grpBooking.Controls.Add(this.txtName);
            this.grpBooking.Controls.Add(this.lblName);
            this.grpBooking.Controls.Add(this.rdoCancel);
            this.grpBooking.Controls.Add(this.rdoReserve);
            this.grpBooking.Location = new System.Drawing.Point(12, 12);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(319, 118);
            this.grpBooking.TabIndex = 0;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking Input";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(209, 88);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(103, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirmClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(208, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(209, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // rdoCancel
            // 
            this.rdoCancel.AutoSize = true;
            this.rdoCancel.Location = new System.Drawing.Point(99, 20);
            this.rdoCancel.Name = "rdoCancel";
            this.rdoCancel.Size = new System.Drawing.Size(118, 17);
            this.rdoCancel.TabIndex = 1;
            this.rdoCancel.TabStop = true;
            this.rdoCancel.Text = "Cancel Reservation";
            this.rdoCancel.UseVisualStyleBackColor = true;
            this.rdoCancel.CheckedChanged += new System.EventHandler(this.RdoCancelCheckedChanged);
            // 
            // rdoReserve
            // 
            this.rdoReserve.AutoSize = true;
            this.rdoReserve.Location = new System.Drawing.Point(7, 20);
            this.rdoReserve.Name = "rdoReserve";
            this.rdoReserve.Size = new System.Drawing.Size(65, 17);
            this.rdoReserve.TabIndex = 0;
            this.rdoReserve.TabStop = true;
            this.rdoReserve.Text = "Reserve";
            this.rdoReserve.UseVisualStyleBackColor = true;
            this.rdoReserve.CheckedChanged += new System.EventHandler(this.RdoReserveCheckedChanged);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblSeatsVacantNum);
            this.grpOutput.Controls.Add(this.lblSeatsReservedNum);
            this.grpOutput.Controls.Add(this.lblSeatsTotalNum);
            this.grpOutput.Controls.Add(this.lblSeatsVacant);
            this.grpOutput.Controls.Add(this.lblSeatsReserved);
            this.grpOutput.Controls.Add(this.lblSeatsTotal);
            this.grpOutput.Location = new System.Drawing.Point(12, 137);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(319, 99);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output Data";
            // 
            // lblSeatsVacantNum
            // 
            this.lblSeatsVacantNum.AutoSize = true;
            this.lblSeatsVacantNum.Location = new System.Drawing.Point(278, 78);
            this.lblSeatsVacantNum.Name = "lblSeatsVacantNum";
            this.lblSeatsVacantNum.Size = new System.Drawing.Size(0, 13);
            this.lblSeatsVacantNum.TabIndex = 8;
            this.lblSeatsVacantNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSeatsReservedNum
            // 
            this.lblSeatsReservedNum.AutoSize = true;
            this.lblSeatsReservedNum.Location = new System.Drawing.Point(278, 49);
            this.lblSeatsReservedNum.Name = "lblSeatsReservedNum";
            this.lblSeatsReservedNum.Size = new System.Drawing.Size(0, 13);
            this.lblSeatsReservedNum.TabIndex = 7;
            this.lblSeatsReservedNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSeatsTotalNum
            // 
            this.lblSeatsTotalNum.AutoSize = true;
            this.lblSeatsTotalNum.Location = new System.Drawing.Point(278, 20);
            this.lblSeatsTotalNum.Name = "lblSeatsTotalNum";
            this.lblSeatsTotalNum.Size = new System.Drawing.Size(0, 13);
            this.lblSeatsTotalNum.TabIndex = 6;
            this.lblSeatsTotalNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSeatsVacant
            // 
            this.lblSeatsVacant.AutoSize = true;
            this.lblSeatsVacant.Location = new System.Drawing.Point(7, 78);
            this.lblSeatsVacant.Name = "lblSeatsVacant";
            this.lblSeatsVacant.Size = new System.Drawing.Size(120, 13);
            this.lblSeatsVacant.TabIndex = 5;
            this.lblSeatsVacant.Text = "Number of vacant seats";
            // 
            // lblSeatsReserved
            // 
            this.lblSeatsReserved.AutoSize = true;
            this.lblSeatsReserved.Location = new System.Drawing.Point(7, 49);
            this.lblSeatsReserved.Name = "lblSeatsReserved";
            this.lblSeatsReserved.Size = new System.Drawing.Size(128, 13);
            this.lblSeatsReserved.TabIndex = 2;
            this.lblSeatsReserved.Text = "Number of reserved seats";
            // 
            // lblSeatsTotal
            // 
            this.lblSeatsTotal.AutoSize = true;
            this.lblSeatsTotal.Location = new System.Drawing.Point(7, 20);
            this.lblSeatsTotal.Name = "lblSeatsTotal";
            this.lblSeatsTotal.Size = new System.Drawing.Size(109, 13);
            this.lblSeatsTotal.TabIndex = 0;
            this.lblSeatsTotal.Text = "Total number of seats";
            // 
            // grpReservations
            // 
            this.grpReservations.Controls.Add(this.btnRefresh);
            this.grpReservations.Controls.Add(this.cmbSort);
            this.grpReservations.Controls.Add(this.lstReservations);
            this.grpReservations.Location = new System.Drawing.Point(337, 12);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Size = new System.Drawing.Size(319, 223);
            this.grpReservations.TabIndex = 2;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(191, 20);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 21);
            this.cmbSort.TabIndex = 2;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortSelectedIndexChanged);
            // 
            // lstReservations
            // 
            this.lstReservations.FullRowSelect = true;
            this.lstReservations.HideSelection = false;
            this.lstReservations.Location = new System.Drawing.Point(6, 44);
            this.lstReservations.MultiSelect = false;
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(307, 173);
            this.lstReservations.TabIndex = 1;
            this.lstReservations.UseCompatibleStateImageBehavior = false;
            this.lstReservations.View = System.Windows.Forms.View.Details;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(142, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 22);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Upd";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 245);
            this.Controls.Add(this.grpReservations);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpBooking);
            this.Name = "MainForm";
            this.Text = "CBS Cinema Booking System - Markus Maga";
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpReservations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.RadioButton rdoCancel;
        private System.Windows.Forms.RadioButton rdoReserve;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblSeatsTotal;
        private System.Windows.Forms.GroupBox grpReservations;
        private System.Windows.Forms.Label lblSeatsReserved;
        private System.Windows.Forms.Label lblSeatsVacant;
        private System.Windows.Forms.Label lblSeatsVacantNum;
        private System.Windows.Forms.Label lblSeatsReservedNum;
        private System.Windows.Forms.Label lblSeatsTotalNum;
        private System.Windows.Forms.ListView lstReservations;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnRefresh;
    }
}

