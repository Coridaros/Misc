namespace Currency_Converter
{
    partial class formConverter
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
            comboBoxCurrency = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new Point(28, 41);
            numericUpDownAmount.Margin = new Padding(4, 4, 4, 4);
            numericUpDownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(154, 29);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Items.AddRange(new object[] { "EUR", "USD", "GBP" });
            comboBoxCurrency.Location = new Point(403, 41);
            comboBoxCurrency.Margin = new Padding(4, 4, 4, 4);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(154, 29);
            comboBoxCurrency.TabIndex = 1;
            comboBoxCurrency.SelectedIndexChanged += comboBoxCurrency_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 2;
            label1.Text = "BGN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 3;
            label2.Text = "=>";
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.PaleGreen;
            labelResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelResult.Location = new Point(28, 119);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(529, 37);
            labelResult.TabIndex = 4;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formConverter
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 197);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCurrency);
            Controls.Add(numericUpDownAmount);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formConverter";
            Text = "Currency Converter";
            Load += formConverter_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private ComboBox comboBoxCurrency;
        private Label label1;
        private Label label2;
        private Label labelResult;
    }
}
