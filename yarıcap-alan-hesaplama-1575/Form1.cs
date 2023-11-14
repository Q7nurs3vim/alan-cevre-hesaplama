namespace yarıcap_alan_hesaplama_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.14;
            double r, alan, cevre;
            r = Convert.ToDouble(txtYaricap.Text);
            alan = pi * r * r;
            cevre = 2 * pi * r;
            lblAlan.Text = "Alan: " + alan.ToString();
            lblCevre.Text = "Çevre: " + cevre.ToString();
        }
    }
}