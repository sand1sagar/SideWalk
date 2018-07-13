namespace SidewalkWindowsApp.Inspection
{
    partial class FormInspection
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoDoNotPour = new System.Windows.Forms.RadioButton();
            this.rdoPour = new System.Windows.Forms.RadioButton();
            this.doNotPourSection = new System.Windows.Forms.GroupBox();
            this.txtDoNotPourNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.pourSection = new System.Windows.Forms.GroupBox();
            this.txtPourNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAffidavit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormGranted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPermitted = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatusDate = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.doNotPourSection.SuspendLayout();
            this.pourSection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.rdoDoNotPour);
            this.groupBox2.Controls.Add(this.rdoPour);
            this.groupBox2.Controls.Add(this.doNotPourSection);
            this.groupBox2.Controls.Add(this.pourSection);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(1300, 631);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(34, 493);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1188, 48);
            this.textBox4.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Additional Notes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(551, 547);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 27);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rdoDoNotPour
            // 
            this.rdoDoNotPour.AutoSize = true;
            this.rdoDoNotPour.Location = new System.Drawing.Point(610, 59);
            this.rdoDoNotPour.Name = "rdoDoNotPour";
            this.rdoDoNotPour.Size = new System.Drawing.Size(167, 23);
            this.rdoDoNotPour.TabIndex = 1;
            this.rdoDoNotPour.TabStop = true;
            this.rdoDoNotPour.Text = "Do Not Pour Concrete";
            this.rdoDoNotPour.UseVisualStyleBackColor = true;
            this.rdoDoNotPour.CheckedChanged += new System.EventHandler(this.rdoDoNotPour_CheckedChanged);
            // 
            // rdoPour
            // 
            this.rdoPour.AutoSize = true;
            this.rdoPour.Location = new System.Drawing.Point(29, 59);
            this.rdoPour.Name = "rdoPour";
            this.rdoPour.Size = new System.Drawing.Size(204, 23);
            this.rdoPour.TabIndex = 0;
            this.rdoPour.TabStop = true;
            this.rdoPour.Text = "Permission Granted to Pour";
            this.rdoPour.UseVisualStyleBackColor = true;
            this.rdoPour.CheckedChanged += new System.EventHandler(this.rdoPour_CheckedChanged);
            // 
            // doNotPourSection
            // 
            this.doNotPourSection.Controls.Add(this.txtDoNotPourNotes);
            this.doNotPourSection.Controls.Add(this.label9);
            this.doNotPourSection.Controls.Add(this.checkedListBox2);
            this.doNotPourSection.Location = new System.Drawing.Point(608, 88);
            this.doNotPourSection.Name = "doNotPourSection";
            this.doNotPourSection.Size = new System.Drawing.Size(619, 377);
            this.doNotPourSection.TabIndex = 26;
            this.doNotPourSection.TabStop = false;
            this.doNotPourSection.Text = "Do not Pour";
            // 
            // txtDoNotPourNotes
            // 
            this.txtDoNotPourNotes.Location = new System.Drawing.Point(15, 212);
            this.txtDoNotPourNotes.Multiline = true;
            this.txtDoNotPourNotes.Name = "txtDoNotPourNotes";
            this.txtDoNotPourNotes.Size = new System.Drawing.Size(598, 159);
            this.txtDoNotPourNotes.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Other";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Not ready/Not started",
            "Place sufficient amount of barricades as required by city Right-Of-Way permit for" +
                " safety",
            "Remove construction debris from city Right-Of-Way",
            "Excavated areas are not deep enough throughout per city code",
            "Curb to be 16\" from top of curb",
            "Saw spalled/chipped edges vertically to full depth as marked",
            "No permit/permit expired"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 26);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(601, 158);
            this.checkedListBox2.TabIndex = 26;
            // 
            // pourSection
            // 
            this.pourSection.Controls.Add(this.txtPourNotes);
            this.pourSection.Controls.Add(this.label8);
            this.pourSection.Controls.Add(this.checkedListBox1);
            this.pourSection.Location = new System.Drawing.Point(27, 88);
            this.pourSection.Name = "pourSection";
            this.pourSection.Size = new System.Drawing.Size(566, 377);
            this.pourSection.TabIndex = 25;
            this.pourSection.TabStop = false;
            this.pourSection.Text = "Permission Granted to Pour";
            // 
            // txtPourNotes
            // 
            this.txtPourNotes.Location = new System.Drawing.Point(10, 212);
            this.txtPourNotes.Multiline = true;
            this.txtPourNotes.Name = "txtPourNotes";
            this.txtPourNotes.Size = new System.Drawing.Size(550, 159);
            this.txtPourNotes.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Other";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sidewalk",
            "Driveway",
            "Curb",
            "Partial",
            "Match existing joint pettern of abutting sidewalk",
            "Place construction deep/joints as indicated/marked/discussed",
            "Took deep joints w/max 3/8\" radius edger, with back to back shine"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(553, 158);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "04/12/2016";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inspection Date : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAffidavit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFormGranted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPermitted);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStatusDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(974, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 27);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(974, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 27);
            this.textBox2.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(968, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Previous Final Inspections";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(974, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 27);
            this.textBox6.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 27);
            this.textBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inspection Date";
            // 
            // txtAffidavit
            // 
            this.txtAffidavit.Location = new System.Drawing.Point(673, 39);
            this.txtAffidavit.Name = "txtAffidavit";
            this.txtAffidavit.Size = new System.Drawing.Size(143, 27);
            this.txtAffidavit.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Inspector";
            // 
            // txtFormGranted
            // 
            this.txtFormGranted.Location = new System.Drawing.Point(474, 40);
            this.txtFormGranted.Name = "txtFormGranted";
            this.txtFormGranted.Size = new System.Drawing.Size(193, 27);
            this.txtFormGranted.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // txtPermitted
            // 
            this.txtPermitted.Location = new System.Drawing.Point(125, 40);
            this.txtPermitted.Name = "txtPermitted";
            this.txtPermitted.Size = new System.Drawing.Size(343, 27);
            this.txtPermitted.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Property Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Affidavit";
            // 
            // txtStatusDate
            // 
            this.txtStatusDate.Location = new System.Drawing.Point(12, 39);
            this.txtStatusDate.Name = "txtStatusDate";
            this.txtStatusDate.Size = new System.Drawing.Size(107, 27);
            this.txtStatusDate.TabIndex = 12;
            // 
            // FormInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormInspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInspection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInspection_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.doNotPourSection.ResumeLayout(false);
            this.doNotPourSection.PerformLayout();
            this.pourSection.ResumeLayout(false);
            this.pourSection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox doNotPourSection;
        private System.Windows.Forms.RadioButton rdoDoNotPour;
        private System.Windows.Forms.GroupBox pourSection;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rdoPour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TextBox txtPourNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoNotPourNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAffidavit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormGranted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPermitted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatusDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
    }
}