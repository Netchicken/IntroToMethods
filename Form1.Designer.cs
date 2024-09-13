namespace IntroToMethods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnCalculate = new Button();
            cbxOperation = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(55, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(58, 35);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            txtNum1.Text = "3";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(164, 35);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            txtNum2.Text = "2";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(59, 116);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(205, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cbxOperation
            // 
            cbxOperation.FormattingEnabled = true;
            cbxOperation.Items.AddRange(new object[] { "Add", "Subtract", "Divide", "Multiply" });
            cbxOperation.Location = new Point(59, 74);
            cbxOperation.Name = "cbxOperation";
            cbxOperation.Size = new Size(98, 23);
            cbxOperation.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(285, 173);
            Controls.Add(cbxOperation);
            Controls.Add(btnCalculate);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnCalculate;
        private ComboBox cbxOperation;
    }
}
