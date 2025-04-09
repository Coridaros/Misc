namespace BgnToEur
{
    partial class FormConverter
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
            numericUpDownAmount = new NumericUpDown();
            label = new Label();
            label2 = new Label();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new Point(111, 41);
            numericUpDownAmount.Margin = new Padding(4);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(154, 29);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            numericUpDownAmount.KeyUp += numericUpDownAmount_KeyUp;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(292, 43);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(93, 21);
            label.TabIndex = 1;
            label.Text = "BGN to EUR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "Convert";
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.PaleGreen;
            labelResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelResult.Location = new Point(15, 100);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(378, 46);
            labelResult.TabIndex = 3;
            labelResult.Text = "label3";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConverter
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 188);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(numericUpDownAmount);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConverter";
            Text = "BGN to EUR - Converter";
            Load += FormConverter_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label label;
        private Label label2;
        private Label labelResult;
    }
}
