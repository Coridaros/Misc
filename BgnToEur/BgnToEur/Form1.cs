namespace BgnToEur
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            CurrencyConvert();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            CurrencyConvert();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            CurrencyConvert();
        }

        private void CurrencyConvert()
        {
            var amountBgn = this.numericUpDownAmount.Value;
            var amountEur = amountBgn / 1.95583m;

            this.labelResult.Text = amountBgn + " BGN = " + Math.Round(amountEur, 2) + " EUR";
        }
    }
}
