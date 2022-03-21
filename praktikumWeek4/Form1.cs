namespace praktikumWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lBoxData.Items.Contains(tBoxInput.Text))
            {
                MessageBox.Show("This word already exists!");
            }
            else
            {
                lBoxData.Items.Add(tBoxInput.Text);
                tBoxInput.Text = "";
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labelOutput2.Text = "";
            lBoxData.Items.Clear();
        }

        private void rButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                    labelOutput2.ForeColor = Color.Red;
                else if (rButtonBiru.Checked == true)
                    labelOutput2.ForeColor = Color.Blue;

            }
           else 
            {
                labelOutput2.ForeColor = Color.Black;
            }
        }

        private void rButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                    labelOutput2.ForeColor = Color.Red;
                else if (rButtonBiru.Checked == true)
                    labelOutput2.ForeColor = Color.Blue;

            }
            else
            {
                labelOutput2.ForeColor = Color.Black;
            }
        }

        private void lBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxData.SelectedItems !=null)
            {
                labelOutput2.Text = lBoxData.SelectedItem.ToString();
            }
            else
            {
                labelOutput2.Text = "";
            }
        }

        private void cBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                    labelOutput2.ForeColor = Color.Red;
                else if (rButtonBiru.Checked == true)
                    labelOutput2.ForeColor = Color.Blue;

            }
            else
            {
                labelOutput2.ForeColor = Color.Black;
            }
        }
    }
}