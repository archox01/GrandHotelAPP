namespace GrandHotelAPP
{
    partial class FrontOfficeMainForm
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
            this.CheckInButton = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.MRTButton = new System.Windows.Forms.Button();
            this.RAIButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.MIButton = new System.Windows.Forms.Button();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkInUC1 = new GrandHotelAPP.Forms.CheckInUC();
            this.reservationForm1 = new GrandHotelAPP.ReservationForm();
            this.masterItemUC1 = new GrandHotelAPP.MasterItemUC();
            this.masterRoomUC1 = new GrandHotelAPP.DataSource.MasterRoomUC();
            this.mrTypeUC1 = new GrandHotelAPP.MRTypeUC();
            this.checkOutUC1 = new GrandHotelAPP.CheckOutUC();
            this.requestAditionalItemUC1 = new GrandHotelAPP.RequestAditionalItemUC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(86, 214);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(126, 54);
            this.CheckInButton.TabIndex = 2;
            this.CheckInButton.Text = "Check In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // MRButton
            // 
            this.MRButton.Location = new System.Drawing.Point(86, 454);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(126, 54);
            this.MRButton.TabIndex = 5;
            this.MRButton.Text = "Master Room";
            this.MRButton.UseVisualStyleBackColor = true;
            this.MRButton.Click += new System.EventHandler(this.MRButton_Click);
            // 
            // MRTButton
            // 
            this.MRTButton.Location = new System.Drawing.Point(86, 394);
            this.MRTButton.Name = "MRTButton";
            this.MRTButton.Size = new System.Drawing.Size(126, 54);
            this.MRTButton.TabIndex = 6;
            this.MRTButton.Text = "Master Room Type";
            this.MRTButton.UseVisualStyleBackColor = true;
            this.MRTButton.Click += new System.EventHandler(this.MRTButton_Click);
            // 
            // RAIButton
            // 
            this.RAIButton.Location = new System.Drawing.Point(86, 274);
            this.RAIButton.Name = "RAIButton";
            this.RAIButton.Size = new System.Drawing.Size(126, 54);
            this.RAIButton.TabIndex = 3;
            this.RAIButton.Text = "Request Additional Item";
            this.RAIButton.UseVisualStyleBackColor = true;
            this.RAIButton.Click += new System.EventHandler(this.RAIButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(86, 334);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(126, 54);
            this.CheckOutButton.TabIndex = 4;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // MIButton
            // 
            this.MIButton.Location = new System.Drawing.Point(86, 514);
            this.MIButton.Name = "MIButton";
            this.MIButton.Size = new System.Drawing.Size(126, 54);
            this.MIButton.TabIndex = 7;
            this.MIButton.Text = "Master Item";
            this.MIButton.UseVisualStyleBackColor = true;
            this.MIButton.Click += new System.EventHandler(this.MIButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Location = new System.Drawing.Point(86, 154);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(126, 54);
            this.ReservationButton.TabIndex = 1;
            this.ReservationButton.Text = "Reservation";
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Front Office";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ReservationButton);
            this.panel2.Controls.Add(this.MIButton);
            this.panel2.Controls.Add(this.RAIButton);
            this.panel2.Controls.Add(this.CheckOutButton);
            this.panel2.Controls.Add(this.MRButton);
            this.panel2.Controls.Add(this.CheckInButton);
            this.panel2.Controls.Add(this.MRTButton);
            this.panel2.Controls.Add(this.checkInUC1);
            this.panel2.Controls.Add(this.reservationForm1);
            this.panel2.Controls.Add(this.masterItemUC1);
            this.panel2.Controls.Add(this.masterRoomUC1);
            this.panel2.Controls.Add(this.mrTypeUC1);
            this.panel2.Controls.Add(this.checkOutUC1);
            this.panel2.Controls.Add(this.requestAditionalItemUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 794);
            this.panel2.TabIndex = 8;
            // 
            // checkInUC1
            // 
            this.checkInUC1.Location = new System.Drawing.Point(241, -13);
            this.checkInUC1.Name = "checkInUC1";
            this.checkInUC1.Size = new System.Drawing.Size(1086, 807);
            this.checkInUC1.TabIndex = 9;
            this.checkInUC1.Load += new System.EventHandler(this.checkInUC1_Load);
            // 
            // reservationForm1
            // 
            this.reservationForm1.Location = new System.Drawing.Point(241, 3);
            this.reservationForm1.Name = "reservationForm1";
            this.reservationForm1.Size = new System.Drawing.Size(1086, 850);
            this.reservationForm1.TabIndex = 8;
            // 
            // masterItemUC1
            // 
            this.masterItemUC1.Location = new System.Drawing.Point(241, 0);
            this.masterItemUC1.Name = "masterItemUC1";
            this.masterItemUC1.Size = new System.Drawing.Size(1086, 850);
            this.masterItemUC1.TabIndex = 14;
            // 
            // masterRoomUC1
            // 
            this.masterRoomUC1.Location = new System.Drawing.Point(241, 0);
            this.masterRoomUC1.Name = "masterRoomUC1";
            this.masterRoomUC1.Size = new System.Drawing.Size(1086, 850);
            this.masterRoomUC1.TabIndex = 13;
            // 
            // mrTypeUC1
            // 
            this.mrTypeUC1.Location = new System.Drawing.Point(241, 0);
            this.mrTypeUC1.Name = "mrTypeUC1";
            this.mrTypeUC1.Size = new System.Drawing.Size(1086, 850);
            this.mrTypeUC1.TabIndex = 12;
            // 
            // checkOutUC1
            // 
            this.checkOutUC1.Location = new System.Drawing.Point(241, 0);
            this.checkOutUC1.Name = "checkOutUC1";
            this.checkOutUC1.Size = new System.Drawing.Size(1086, 850);
            this.checkOutUC1.TabIndex = 11;
            // 
            // requestAditionalItemUC1
            // 
            this.requestAditionalItemUC1.Location = new System.Drawing.Point(241, 0);
            this.requestAditionalItemUC1.Name = "requestAditionalItemUC1";
            this.requestAditionalItemUC1.Size = new System.Drawing.Size(1086, 850);
            this.requestAditionalItemUC1.TabIndex = 10;
            // 
            // FrontOfficeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1323, 794);
            this.Controls.Add(this.panel2);

            this.MaximumSize = new System.Drawing.Size(1345, 850);
            this.MinimumSize = new System.Drawing.Size(1345, 850);
            this.Name = "FrontOfficeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontOfficeMainForm";
            this.Load += new System.EventHandler(this.FrontOfficeMainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button MRTButton;
        private System.Windows.Forms.Button RAIButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button MIButton;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RequestAditionalItemUC requestAditionalItemUC1;
        private Forms.CheckInUC checkInUC1;
        private ReservationForm reservationForm1;
        private CheckOutUC checkOutUC1;
        private MasterItemUC masterItemUC1;
        private DataSource.MasterRoomUC masterRoomUC1;
        private MRTypeUC mrTypeUC1;
    }
}