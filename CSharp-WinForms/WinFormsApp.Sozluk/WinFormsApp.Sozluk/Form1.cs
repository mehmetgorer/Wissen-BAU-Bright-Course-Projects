namespace WinFormsApp.Sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Turkceler = { "bilgisayar", "s�n�f", "nesne", "��renci", "pencere", "kap�", "fare", "saat", "kalem", "�ay", "ka��t", "okul" };

        string[] Ingilizceler = { "computer", "class", "object", "student", "window", "door", "mouse", "clock", "pencil", "tea", "paper", "school" };

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIngilizce.ReadOnly = true;
            lbKelimeler.Items.AddRange(Turkceler);
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtTurkce.Text.Trim() != "" || txtIngilizce.Text.Trim() != "")
            {
                if (rbTurkToIng.Checked)
                {
                    if (Turkceler.Contains(txtTurkce.Text.ToLower()))
                    {
                        for (int i = 0; i < Turkceler.Length; i++)
                        {
                            if (Turkceler[i] == txtTurkce.Text.ToLower())
                            {
                                txtIngilizce.Text = Ingilizceler[i];
                                txtTurkce.Focus();
                                break;  //d�ng�y� sonland�r�r ve uygulaman�n �al��mas�n� d�ng�n�n sonras�ndan devam ettirir.
                            }
                        }
                    }
                    else { 
                        MessageBox.Show("Arad���n�z kelime s�zl�kte yok!");
                        txtTurkce.Focus();
                    }
                }
                else if (rbIngToTurk.Checked)
                {
                    if (Ingilizceler.Contains(txtIngilizce.Text.ToLower()))
                    {
                        for (int i = 0; i < Ingilizceler.Length; i++)
                        {
                            if (Ingilizceler[i] == txtIngilizce.Text.ToLower())
                            {
                                txtTurkce.Text = Turkceler[i];
                                txtIngilizce.Focus();
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arad���n�z kelime s�zl�kte yok!");
                        txtIngilizce.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("�ncelikle kelime girmelisiniz!", "Eksik Bilgi");
                txtTurkce.Focus();
            }
        }
        private void rbIngToTurk_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            lbKelimeler.Items.AddRange(Ingilizceler);
            txtTurkce.ReadOnly = true;
            txtIngilizce.ReadOnly = false;
            txtTurkce.Clear();
            txtIngilizce.Clear();
            txtIngilizce.Focus();
        }
        private void rbTurkToIng_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            lbKelimeler.Items.AddRange(Turkceler);
            txtTurkce.ReadOnly = false;
            txtIngilizce.ReadOnly = true;
            txtTurkce.Clear();
            txtIngilizce.Clear();
            txtTurkce.Focus();
        }
        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == "") txtIngilizce.Clear();
        }
        private void txtIngilizce_TextChanged(object sender, EventArgs e)
        {
            if (txtIngilizce.Text == "") txtTurkce.Clear();
        }

        private void lbKelimeler_DoubleClick(object sender, EventArgs e)
        {
            if (rbTurkToIng.Checked)
            {
                txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
                btnBul_Click(sender, new EventArgs());
            }
            else
            {
                txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
                btnBul_Click(sender, new EventArgs());
            }
        }

        private void lbKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    //MessageBox.Show("Listeden se�im yap�ld�, indeksi " + lbKelimeler.SelectedIndex);
        //    MessageBox.Show("Listeden se�im yap�ld�, se�ilen eleman " + lbKelimeler.SelectedItem);
        }
    }
}