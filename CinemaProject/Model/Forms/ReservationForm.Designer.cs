namespace CinemaProject.Model.Forms
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfPeople = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seat1 = new System.Windows.Forms.Label();
            this.rowForPerson1 = new System.Windows.Forms.ComboBox();
            this.person2 = new System.Windows.Forms.ComboBox();
            this.seat2 = new System.Windows.Forms.Label();
            this.person3 = new System.Windows.Forms.ComboBox();
            this.seat3 = new System.Windows.Forms.Label();
            this.person4 = new System.Windows.Forms.ComboBox();
            this.seat4 = new System.Windows.Forms.Label();
            this.person5 = new System.Windows.Forms.ComboBox();
            this.seat5 = new System.Windows.Forms.Label();
            this.person55 = new System.Windows.Forms.ComboBox();
            this.person44 = new System.Windows.Forms.ComboBox();
            this.person33 = new System.Windows.Forms.ComboBox();
            this.person22 = new System.Windows.Forms.ComboBox();
            this.seatForPerson1 = new System.Windows.Forms.ComboBox();
            this.selectRow = new System.Windows.Forms.Label();
            this.SelectSeatNr = new System.Windows.Forms.Label();
            this.submitReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.FormattingEnabled = true;
            this.numberOfPeople.Location = new System.Drawing.Point(228, 91);
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(121, 21);
            this.numberOfPeople.TabIndex = 2;
            this.numberOfPeople.SelectedIndexChanged += new System.EventHandler(this.numberOfPeople_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of guests to make an reservation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // seat1
            // 
            this.seat1.AutoSize = true;
            this.seat1.Location = new System.Drawing.Point(12, 145);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(38, 13);
            this.seat1.TabIndex = 4;
            this.seat1.Text = "Seat 1";
            // 
            // rowForPerson1
            // 
            this.rowForPerson1.FormattingEnabled = true;
            this.rowForPerson1.Location = new System.Drawing.Point(228, 142);
            this.rowForPerson1.Name = "rowForPerson1";
            this.rowForPerson1.Size = new System.Drawing.Size(121, 21);
            this.rowForPerson1.TabIndex = 5;
            this.rowForPerson1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // person2
            // 
            this.person2.FormattingEnabled = true;
            this.person2.Location = new System.Drawing.Point(228, 178);
            this.person2.Name = "person2";
            this.person2.Size = new System.Drawing.Size(121, 21);
            this.person2.TabIndex = 8;
            this.person2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // seat2
            // 
            this.seat2.AutoSize = true;
            this.seat2.Location = new System.Drawing.Point(12, 181);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(38, 13);
            this.seat2.TabIndex = 7;
            this.seat2.Text = "Seat 2";
            // 
            // person3
            // 
            this.person3.FormattingEnabled = true;
            this.person3.Location = new System.Drawing.Point(228, 214);
            this.person3.Name = "person3";
            this.person3.Size = new System.Drawing.Size(121, 21);
            this.person3.TabIndex = 10;
            // 
            // seat3
            // 
            this.seat3.AutoSize = true;
            this.seat3.Location = new System.Drawing.Point(12, 217);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(38, 13);
            this.seat3.TabIndex = 9;
            this.seat3.Text = "Seat 3";
            // 
            // person4
            // 
            this.person4.FormattingEnabled = true;
            this.person4.Location = new System.Drawing.Point(228, 250);
            this.person4.Name = "person4";
            this.person4.Size = new System.Drawing.Size(121, 21);
            this.person4.TabIndex = 12;
            // 
            // seat4
            // 
            this.seat4.AutoSize = true;
            this.seat4.Location = new System.Drawing.Point(12, 253);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(38, 13);
            this.seat4.TabIndex = 11;
            this.seat4.Text = "Seat 4";
            // 
            // person5
            // 
            this.person5.FormattingEnabled = true;
            this.person5.Location = new System.Drawing.Point(228, 286);
            this.person5.Name = "person5";
            this.person5.Size = new System.Drawing.Size(121, 21);
            this.person5.TabIndex = 14;
            // 
            // seat5
            // 
            this.seat5.AutoSize = true;
            this.seat5.Location = new System.Drawing.Point(12, 289);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(38, 13);
            this.seat5.TabIndex = 13;
            this.seat5.Text = "Seat 5";
            // 
            // person55
            // 
            this.person55.FormattingEnabled = true;
            this.person55.Location = new System.Drawing.Point(355, 286);
            this.person55.Name = "person55";
            this.person55.Size = new System.Drawing.Size(121, 21);
            this.person55.TabIndex = 19;
            // 
            // person44
            // 
            this.person44.FormattingEnabled = true;
            this.person44.Location = new System.Drawing.Point(355, 250);
            this.person44.Name = "person44";
            this.person44.Size = new System.Drawing.Size(121, 21);
            this.person44.TabIndex = 18;
            // 
            // person33
            // 
            this.person33.FormattingEnabled = true;
            this.person33.Location = new System.Drawing.Point(355, 214);
            this.person33.Name = "person33";
            this.person33.Size = new System.Drawing.Size(121, 21);
            this.person33.TabIndex = 17;
            // 
            // person22
            // 
            this.person22.FormattingEnabled = true;
            this.person22.Location = new System.Drawing.Point(355, 178);
            this.person22.Name = "person22";
            this.person22.Size = new System.Drawing.Size(121, 21);
            this.person22.TabIndex = 16;
            // 
            // seatForPerson1
            // 
            this.seatForPerson1.FormattingEnabled = true;
            this.seatForPerson1.Location = new System.Drawing.Point(355, 142);
            this.seatForPerson1.Name = "seatForPerson1";
            this.seatForPerson1.Size = new System.Drawing.Size(121, 21);
            this.seatForPerson1.TabIndex = 15;
            // 
            // selectRow
            // 
            this.selectRow.AutoSize = true;
            this.selectRow.Location = new System.Drawing.Point(228, 123);
            this.selectRow.Name = "selectRow";
            this.selectRow.Size = new System.Drawing.Size(62, 13);
            this.selectRow.TabIndex = 20;
            this.selectRow.Text = "Select Row";
            this.selectRow.Click += new System.EventHandler(this.label4_Click);
            // 
            // SelectSeatNr
            // 
            this.SelectSeatNr.AutoSize = true;
            this.SelectSeatNr.Location = new System.Drawing.Point(352, 123);
            this.SelectSeatNr.Name = "SelectSeatNr";
            this.SelectSeatNr.Size = new System.Drawing.Size(98, 13);
            this.SelectSeatNr.TabIndex = 21;
            this.SelectSeatNr.Text = "Select seat number";
            // 
            // submitReservation
            // 
            this.submitReservation.Location = new System.Drawing.Point(228, 323);
            this.submitReservation.Name = "submitReservation";
            this.submitReservation.Size = new System.Drawing.Size(248, 40);
            this.submitReservation.TabIndex = 22;
            this.submitReservation.Text = "Make Reservation";
            this.submitReservation.UseVisualStyleBackColor = true;
            this.submitReservation.Click += new System.EventHandler(this.submitReservation_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitReservation);
            this.Controls.Add(this.SelectSeatNr);
            this.Controls.Add(this.selectRow);
            this.Controls.Add(this.person55);
            this.Controls.Add(this.person44);
            this.Controls.Add(this.person33);
            this.Controls.Add(this.person22);
            this.Controls.Add(this.seatForPerson1);
            this.Controls.Add(this.person5);
            this.Controls.Add(this.seat5);
            this.Controls.Add(this.person4);
            this.Controls.Add(this.seat4);
            this.Controls.Add(this.person3);
            this.Controls.Add(this.seat3);
            this.Controls.Add(this.person2);
            this.Controls.Add(this.seat2);
            this.Controls.Add(this.rowForPerson1);
            this.Controls.Add(this.seat1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberOfPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numberOfPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label seat1;
        private System.Windows.Forms.ComboBox rowForPerson1;
        private System.Windows.Forms.ComboBox person2;
        private System.Windows.Forms.Label seat2;
        private System.Windows.Forms.ComboBox person3;
        private System.Windows.Forms.Label seat3;
        private System.Windows.Forms.ComboBox person4;
        private System.Windows.Forms.Label seat4;
        private System.Windows.Forms.ComboBox person5;
        private System.Windows.Forms.Label seat5;
        private System.Windows.Forms.ComboBox person55;
        private System.Windows.Forms.ComboBox person44;
        private System.Windows.Forms.ComboBox person33;
        private System.Windows.Forms.ComboBox person22;
        private System.Windows.Forms.ComboBox seatForPerson1;
        private System.Windows.Forms.Label selectRow;
        private System.Windows.Forms.Label SelectSeatNr;
        private System.Windows.Forms.Button submitReservation;
    }
}