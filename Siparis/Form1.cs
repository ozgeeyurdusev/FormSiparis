namespace Siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSiparisAl_Click(object sender, EventArgs e)
        {
            decimal ucret = 0;
            string extra = "";
           
            
            if (checkBoxSucuk.Checked == true)
            {
                extra += "Sucuk";
                ucret = numericUpDownPizza.Value * 15;
               
            }
            if (checkBoxSosis.Checked == true)
            {
                extra += "-" + "Sosis";
                ucret += numericUpDownPizza.Value * 10; 
            }
            if (checkBoxPeynir.Checked == true)
            {
                extra += "-" + "Peynir";
                ucret += numericUpDownPizza.Value * 10;
            }
            if (checkBoxMantar.Checked == true)
            {
                extra += "-" + "Mantar";
                ucret += numericUpDownPizza.Value * 10;
            }
            if (checkBoxTavuk.Checked == true)
            {
                extra += "-" + "Tavuk";
                ucret += numericUpDownPizza.Value * 25;
            }
            if (checkBoxSebze.Checked == true)
            {
                extra += "-" + "Sebze";
                ucret += numericUpDownPizza.Value * 10;
            }

            //comboBox 
            if (comboBoxPizzaBoy.Text == "Küçük")
            {
                ucret += numericUpDownPizza.Value * 10;
            }
            if (comboBoxPizzaBoy.Text == "Orta")
            {
                ucret += numericUpDownPizza.Value * 15;
            }
            if (comboBoxPizzaBoy.Text == "Büyük") 
            {
                ucret += numericUpDownPizza.Value * 20;
            }
            if (comboBoxIcecek.Text == "2,5 L Cola")
            {
                ucret += numericUpDownIcecek.Value * 20 ;
            }
            if (comboBoxIcecek.Text == "Ayran")
            {
                ucret += numericUpDownIcecek.Value * 5;
            }
            if (comboBoxIcecek.Text == "Ice Tea")
            {
                ucret += numericUpDownIcecek.Value * 15;
            }
            //write values to listbox
            listBoxAdSoyad.Items.Add(textBoxAdSoyad.Text);
            listBoxTelefon.Items.Add(textBoxTelefon.Text);
            listBoxAdres.Items.Add(richTextBoxAdres.Text);
            listBoxPizzaBoy.Items.Add(numericUpDownPizza.Value + "adet" + comboBoxPizzaBoy.Text);
            listBoxIcecek.Items.Add(numericUpDownIcecek.Value + "adet" + comboBoxIcecek.Text);
            listBoxExtra.Items.Add(extra);
            listBoxUcret.Items.Add(ucret + "TL"); 
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = "";
            textBoxTelefon.Text = "";
            richTextBoxAdres.Text = "";
            comboBoxIcecek.Text = "";
            comboBoxPizzaBoy.Text = "";
            numericUpDownPizza.Value = 0;
            numericUpDownIcecek.Value = 0;
            checkBoxSucuk.Checked = false;
            checkBoxSosis.Checked = false;
            checkBoxMantar.Checked = false;
            checkBoxTavuk.Checked = false;
            checkBoxPeynir.Checked = false;
            checkBoxSebze.Checked = false;
        }

        private void buttonSiparisTemizle_Click(object sender, EventArgs e)
        {
            listBoxAdSoyad.Items.Clear();
            listBoxTelefon.Items.Clear();
            richTextBoxAdres.Clear();
            listBoxPizzaBoy.Items.Clear();
            listBoxIcecek.Items.Clear();
            listBoxExtra.Items.Clear();
            listBoxUcret.Items.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}