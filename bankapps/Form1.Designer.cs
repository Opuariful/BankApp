namespace bankapps
{
    partial class Form1
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
            this.TimeInYeartextBox = new System.Windows.Forms.TextBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.interstDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeInYeartextBox
            // 
            this.TimeInYeartextBox.Location = new System.Drawing.Point(115, 90);
            this.TimeInYeartextBox.Name = "TimeInYeartextBox";
            this.TimeInYeartextBox.Size = new System.Drawing.Size(133, 20);
            this.TimeInYeartextBox.TabIndex = 0;
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(115, 126);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(133, 20);
            this.BalancetextBox.TabIndex = 1;
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(115, 45);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(133, 21);
            this.bankNameComboBox.TabIndex = 2;
            this.bankNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bankNameComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time (in year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interest=";
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.Location = new System.Drawing.Point(115, 166);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(121, 23);
            this.calculateInterestButton.TabIndex = 7;
            this.calculateInterestButton.Text = "Calculate interest";
            this.calculateInterestButton.UseVisualStyleBackColor = true;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click);
            // 
            // interstDisplayLabel
            // 
            this.interstDisplayLabel.AutoSize = true;
            this.interstDisplayLabel.Location = new System.Drawing.Point(66, 227);
            this.interstDisplayLabel.Name = "interstDisplayLabel";
            this.interstDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.interstDisplayLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.interstDisplayLabel);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.TimeInYeartextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeInYeartextBox;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.Label interstDisplayLabel;
    }
}

