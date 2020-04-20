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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.numberOfPeople = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSeat1 = new System.Windows.Forms.Label();
            this.rowForPerson1 = new System.Windows.Forms.ComboBox();
            this.rowForPerson2 = new System.Windows.Forms.ComboBox();
            this.labelSeat2 = new System.Windows.Forms.Label();
            this.rowForPerson3 = new System.Windows.Forms.ComboBox();
            this.labelSeat3 = new System.Windows.Forms.Label();
            this.rowForPerson4 = new System.Windows.Forms.ComboBox();
            this.labelSeat4 = new System.Windows.Forms.Label();
            this.rowForPerson5 = new System.Windows.Forms.ComboBox();
            this.labelSeat5 = new System.Windows.Forms.Label();
            this.seatForPerson5 = new System.Windows.Forms.ComboBox();
            this.seatForPerson4 = new System.Windows.Forms.ComboBox();
            this.seatForPerson3 = new System.Windows.Forms.ComboBox();
            this.seatForPerson2 = new System.Windows.Forms.ComboBox();
            this.seatForPerson1 = new System.Windows.Forms.ComboBox();
            this.selectRow = new System.Windows.Forms.Label();
            this.SelectSeatNr = new System.Windows.Forms.Label();
            this.submitReservation = new System.Windows.Forms.Button();
            this.firstNameFill = new System.Windows.Forms.TextBox();
            this.lastNameFill = new System.Windows.Forms.TextBox();
            this.methodOfPaymentChoice = new System.Windows.Forms.Label();
            this.paymentMethod = new System.Windows.Forms.ComboBox();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(12, 42);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(55, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(12, 69);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(56, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last name";
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
            // 
            // labelSeat1
            // 
            this.labelSeat1.AutoSize = true;
            this.labelSeat1.Location = new System.Drawing.Point(175, 142);
            this.labelSeat1.Name = "labelSeat1";
            this.labelSeat1.Size = new System.Drawing.Size(38, 13);
            this.labelSeat1.TabIndex = 4;
            this.labelSeat1.Text = "Seat 1";
            // 
            // rowForPerson1
            // 
            this.rowForPerson1.FormattingEnabled = true;
            this.rowForPerson1.Location = new System.Drawing.Point(228, 142);
            this.rowForPerson1.Name = "rowForPerson1";
            this.rowForPerson1.Size = new System.Drawing.Size(62, 21);
            this.rowForPerson1.TabIndex = 5;
            // 
            // rowForPerson2
            // 
            this.rowForPerson2.FormattingEnabled = true;
            this.rowForPerson2.Location = new System.Drawing.Point(228, 178);
            this.rowForPerson2.Name = "rowForPerson2";
            this.rowForPerson2.Size = new System.Drawing.Size(62, 21);
            this.rowForPerson2.TabIndex = 8;
            // 
            // labelSeat2
            // 
            this.labelSeat2.AutoSize = true;
            this.labelSeat2.Location = new System.Drawing.Point(175, 178);
            this.labelSeat2.Name = "labelSeat2";
            this.labelSeat2.Size = new System.Drawing.Size(38, 13);
            this.labelSeat2.TabIndex = 7;
            this.labelSeat2.Text = "Seat 2";
            // 
            // rowForPerson3
            // 
            this.rowForPerson3.FormattingEnabled = true;
            this.rowForPerson3.Location = new System.Drawing.Point(228, 214);
            this.rowForPerson3.Name = "rowForPerson3";
            this.rowForPerson3.Size = new System.Drawing.Size(62, 21);
            this.rowForPerson3.TabIndex = 10;
            // 
            // labelSeat3
            // 
            this.labelSeat3.AutoSize = true;
            this.labelSeat3.Location = new System.Drawing.Point(175, 214);
            this.labelSeat3.Name = "labelSeat3";
            this.labelSeat3.Size = new System.Drawing.Size(38, 13);
            this.labelSeat3.TabIndex = 9;
            this.labelSeat3.Text = "Seat 3";
            // 
            // rowForPerson4
            // 
            this.rowForPerson4.FormattingEnabled = true;
            this.rowForPerson4.Location = new System.Drawing.Point(228, 250);
            this.rowForPerson4.Name = "rowForPerson4";
            this.rowForPerson4.Size = new System.Drawing.Size(62, 21);
            this.rowForPerson4.TabIndex = 12;
            // 
            // labelSeat4
            // 
            this.labelSeat4.AutoSize = true;
            this.labelSeat4.Location = new System.Drawing.Point(175, 250);
            this.labelSeat4.Name = "labelSeat4";
            this.labelSeat4.Size = new System.Drawing.Size(38, 13);
            this.labelSeat4.TabIndex = 11;
            this.labelSeat4.Text = "Seat 4";
            // 
            // rowForPerson5
            // 
            this.rowForPerson5.FormattingEnabled = true;
            this.rowForPerson5.Location = new System.Drawing.Point(228, 286);
            this.rowForPerson5.Name = "rowForPerson5";
            this.rowForPerson5.Size = new System.Drawing.Size(62, 21);
            this.rowForPerson5.TabIndex = 14;
            // 
            // labelSeat5
            // 
            this.labelSeat5.AutoSize = true;
            this.labelSeat5.Location = new System.Drawing.Point(175, 286);
            this.labelSeat5.Name = "labelSeat5";
            this.labelSeat5.Size = new System.Drawing.Size(38, 13);
            this.labelSeat5.TabIndex = 13;
            this.labelSeat5.Text = "Seat 5";
            // 
            // seatForPerson5
            // 
            this.seatForPerson5.FormattingEnabled = true;
            this.seatForPerson5.Location = new System.Drawing.Point(308, 286);
            this.seatForPerson5.Name = "seatForPerson5";
            this.seatForPerson5.Size = new System.Drawing.Size(62, 21);
            this.seatForPerson5.TabIndex = 19;
            // 
            // seatForPerson4
            // 
            this.seatForPerson4.FormattingEnabled = true;
            this.seatForPerson4.Location = new System.Drawing.Point(308, 250);
            this.seatForPerson4.Name = "seatForPerson4";
            this.seatForPerson4.Size = new System.Drawing.Size(62, 21);
            this.seatForPerson4.TabIndex = 18;
            // 
            // seatForPerson3
            // 
            this.seatForPerson3.FormattingEnabled = true;
            this.seatForPerson3.Location = new System.Drawing.Point(308, 214);
            this.seatForPerson3.Name = "seatForPerson3";
            this.seatForPerson3.Size = new System.Drawing.Size(62, 21);
            this.seatForPerson3.TabIndex = 17;
            // 
            // seatForPerson2
            // 
            this.seatForPerson2.FormattingEnabled = true;
            this.seatForPerson2.Location = new System.Drawing.Point(308, 178);
            this.seatForPerson2.Name = "seatForPerson2";
            this.seatForPerson2.Size = new System.Drawing.Size(62, 21);
            this.seatForPerson2.TabIndex = 16;
            // 
            // seatForPerson1
            // 
            this.seatForPerson1.FormattingEnabled = true;
            this.seatForPerson1.Location = new System.Drawing.Point(308, 142);
            this.seatForPerson1.Name = "seatForPerson1";
            this.seatForPerson1.Size = new System.Drawing.Size(62, 21);
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
            // 
            // SelectSeatNr
            // 
            this.SelectSeatNr.AutoSize = true;
            this.SelectSeatNr.Location = new System.Drawing.Point(305, 123);
            this.SelectSeatNr.Name = "SelectSeatNr";
            this.SelectSeatNr.Size = new System.Drawing.Size(98, 13);
            this.SelectSeatNr.TabIndex = 21;
            this.SelectSeatNr.Text = "Select seat number";
            // 
            // submitReservation
            // 
            this.submitReservation.Location = new System.Drawing.Point(228, 398);
            this.submitReservation.Name = "submitReservation";
            this.submitReservation.Size = new System.Drawing.Size(142, 40);
            this.submitReservation.TabIndex = 22;
            this.submitReservation.Text = "Make Reservation";
            this.submitReservation.UseVisualStyleBackColor = true;
            this.submitReservation.Click += new System.EventHandler(this.submitReservation_Click);
            // 
            // firstNameFill
            // 
            this.firstNameFill.Location = new System.Drawing.Point(228, 39);
            this.firstNameFill.Name = "firstNameFill";
            this.firstNameFill.Size = new System.Drawing.Size(121, 20);
            this.firstNameFill.TabIndex = 23;
            this.firstNameFill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameFill
            // 
            this.lastNameFill.Location = new System.Drawing.Point(228, 66);
            this.lastNameFill.Name = "lastNameFill";
            this.lastNameFill.Size = new System.Drawing.Size(121, 20);
            this.lastNameFill.TabIndex = 24;
            this.lastNameFill.TextChanged += new System.EventHandler(this.lastNameFill_TextChanged);
            // 
            // methodOfPaymentChoice
            // 
            this.methodOfPaymentChoice.AutoSize = true;
            this.methodOfPaymentChoice.Location = new System.Drawing.Point(228, 326);
            this.methodOfPaymentChoice.Name = "methodOfPaymentChoice";
            this.methodOfPaymentChoice.Size = new System.Drawing.Size(136, 13);
            this.methodOfPaymentChoice.TabIndex = 25;
            this.methodOfPaymentChoice.Text = "Choose method of payment";
            // 
            // paymentMethod
            // 
            this.paymentMethod.FormattingEnabled = true;
            this.paymentMethod.Location = new System.Drawing.Point(228, 342);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(121, 21);
            this.paymentMethod.TabIndex = 26;
            this.paymentMethod.SelectedIndexChanged += new System.EventHandler(this.paymentMethod_SelectedIndexChanged);
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(375, 343);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(183, 20);
            this.cardNumber.TabIndex = 27;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.methodOfPaymentChoice);
            this.Controls.Add(this.lastNameFill);
            this.Controls.Add(this.firstNameFill);
            this.Controls.Add(this.submitReservation);
            this.Controls.Add(this.SelectSeatNr);
            this.Controls.Add(this.selectRow);
            this.Controls.Add(this.seatForPerson5);
            this.Controls.Add(this.seatForPerson4);
            this.Controls.Add(this.seatForPerson3);
            this.Controls.Add(this.seatForPerson2);
            this.Controls.Add(this.seatForPerson1);
            this.Controls.Add(this.rowForPerson5);
            this.Controls.Add(this.labelSeat5);
            this.Controls.Add(this.rowForPerson4);
            this.Controls.Add(this.labelSeat4);
            this.Controls.Add(this.rowForPerson3);
            this.Controls.Add(this.labelSeat3);
            this.Controls.Add(this.rowForPerson2);
            this.Controls.Add(this.labelSeat2);
            this.Controls.Add(this.rowForPerson1);
            this.Controls.Add(this.labelSeat1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberOfPeople);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.ComboBox numberOfPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSeat1;
        private System.Windows.Forms.ComboBox rowForPerson1;
        private System.Windows.Forms.ComboBox rowForPerson2;
        private System.Windows.Forms.Label labelSeat2;
        private System.Windows.Forms.ComboBox rowForPerson3;
        private System.Windows.Forms.Label labelSeat3;
        private System.Windows.Forms.ComboBox rowForPerson4;
        private System.Windows.Forms.Label labelSeat4;
        private System.Windows.Forms.ComboBox rowForPerson5;
        private System.Windows.Forms.Label labelSeat5;
        private System.Windows.Forms.ComboBox seatForPerson5;
        private System.Windows.Forms.ComboBox seatForPerson4;
        private System.Windows.Forms.ComboBox seatForPerson3;
        private System.Windows.Forms.ComboBox seatForPerson2;
        private System.Windows.Forms.ComboBox seatForPerson1;
        private System.Windows.Forms.Label selectRow;
        private System.Windows.Forms.Label SelectSeatNr;
        private System.Windows.Forms.Button submitReservation;
        private System.Windows.Forms.TextBox firstNameFill;
        private System.Windows.Forms.TextBox lastNameFill;
        private System.Windows.Forms.Label methodOfPaymentChoice;
        private System.Windows.Forms.ComboBox paymentMethod;
        private System.Windows.Forms.TextBox cardNumber;
    }
}