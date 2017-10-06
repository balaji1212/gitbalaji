namespace LeaveWinform
{
    partial class LeaveManagementSystem
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEndDate = new System.Windows.Forms.DateTimePicker();
            this.textStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textReason = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "StartDate";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(213, 48);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 20);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndDate";
            // 
            // textEndDate
            // 
            this.textEndDate.Location = new System.Drawing.Point(213, 142);
            this.textEndDate.Name = "textEndDate";
            this.textEndDate.Size = new System.Drawing.Size(200, 20);
            this.textEndDate.TabIndex = 5;
            // 
            // textStartDate
            // 
            this.textStartDate.Location = new System.Drawing.Point(213, 96);
            this.textStartDate.Name = "textStartDate";
            this.textStartDate.Size = new System.Drawing.Size(200, 20);
            this.textStartDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reason";
            // 
            // textReason
            // 
            this.textReason.Location = new System.Drawing.Point(213, 187);
            this.textReason.Multiline = true;
            this.textReason.Name = "textReason";
            this.textReason.Size = new System.Drawing.Size(200, 79);
            this.textReason.TabIndex = 8;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(213, 285);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(200, 23);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // LeaveManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 367);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.textReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textStartDate);
            this.Controls.Add(this.textEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LeaveManagementSystem";
            this.Text = "LeaveManagementSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker textEndDate;
        private System.Windows.Forms.DateTimePicker textStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.Button ApplyButton;
    }
}