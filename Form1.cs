namespace LoginPin
{
    public partial class Form1 : Form
    {
        private string pin = "7197";
        private int brojGresaka = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                if (maskedTextBox1.Text == pin)
                {
                    label2.Text = "Uspesno ste se ulogovali.";
                }
                else
                {
                    label2.Text = "Pogresan pin kod";
                    brojGresaka++;
                    if (brojGresaka == 2)
                    {
                        MessageBox.Show("Uneli ste 2 pokusaja, ostao Vam je jos 1.");
                    }
                    if (brojGresaka == 3)
                    {
                        maskedTextBox1.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Greska,morate uneti 4 cifre.");
            }
        }
    }
}