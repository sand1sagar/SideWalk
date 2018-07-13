namespace SidewalkWindowsApp.Permit
{
    partial class NewActionRate
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtMaxCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(81, 160);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 27);
            this.btnCreate.TabIndex = 72;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtMaxCurrent
            // 
            this.txtMaxCurrent.Location = new System.Drawing.Point(170, 65);
            this.txtMaxCurrent.Name = "txtMaxCurrent";
            this.txtMaxCurrent.Size = new System.Drawing.Size(98, 27);
            this.txtMaxCurrent.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "New";
            // 
            // txtMinNew
            // 
            this.txtMinNew.Location = new System.Drawing.Point(170, 111);
            this.txtMinNew.Name = "txtMinNew";
            this.txtMinNew.Size = new System.Drawing.Size(98, 27);
            this.txtMinNew.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Current";
            // 
            // txtMinCurrent
            // 
            this.txtMinCurrent.Location = new System.Drawing.Point(170, 18);
            this.txtMinCurrent.Name = "txtMinCurrent";
            this.txtMinCurrent.Size = new System.Drawing.Size(98, 27);
            this.txtMinCurrent.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewActionRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 233);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMaxCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMinCurrent);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewActionRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Action Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtMaxCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;

    }
}