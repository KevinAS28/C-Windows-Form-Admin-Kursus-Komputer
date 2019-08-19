using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursus_komputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.jenis = new Dictionary<string, kursus>() { {"U001", new kursus("UMUM", 50000, 70000)}, { "P001", new kursus("Private", 100000, 120000) } };
            this.waktu_rb = new Dictionary<string, RadioButton>() { {"PAGI",  this.pagi }, {"MALAM", this.malam } };
            this.fasilitas_cb = new List<CheckBox>() { this.internet, this.konsumsi};
            for (int i = 1; i < 8; i++)
            {
                this.beberapa_hari.Items.Add(String.Format("{0} Hari", i));
            }
            foreach (KeyValuePair<string, kursus> sk in this.jenis)
            {
                this.jenis_kursus.Items.Add(sk.Key);
            }
        }

        public struct kursus
        {
            public string nama;
            public Dictionary<string, double> waktu;
            public kursus(string n, double p, double m)
            {
                this.nama = n;
                this.waktu = new Dictionary<string, double>() { { "PAGI", p }, { "MALAM", m } };
            }
            
        };

        private Dictionary<string, double> fasilitas_harga = new Dictionary<string, double>() { { "internet", 20000 }, { "konsumsi", 50000 } };
        private Dictionary<string, RadioButton> waktu_rb;
        private List<CheckBox> fasilitas_cb;
        private Dictionary<string, kursus> jenis;

        private void update()
        {
            string jk, waktu="";
            int hari;
            double hk = 0, hf= 0;
            try
            {
                jk = this.jenis_kursus.SelectedItem.ToString();
                
                hari = Convert.ToInt32((this.beberapa_hari.SelectedItem.ToString()).Split(' ')[0]);

                foreach (KeyValuePair<string, RadioButton> x in this.waktu_rb)
                {
                    if (x.Value.Checked)
                    {
                        waktu = x.Key;
                        break;
                    }
                }
                if (waktu == "") { return; }
                hk = this.jenis[jk].waktu[waktu]*hari;
                this.nama_kursus.Text = this.jenis[jk].nama;
                foreach (CheckBox cb in this.fasilitas_cb)
                {
                    if (cb.Checked)
                    {
                        hf += this.fasilitas_harga[cb.Name];
                    }
                }
                this.biaya_kursus.Text = Convert.ToString(hk);
                this.biaya_fasilitas.Text = Convert.ToString(hf);
                this.total_pembayaran.Text = Convert.ToString(hf+hk);
            }
            catch (NullReferenceException e)
            {}
            
        }

        private void Proses_Click(object sender, EventArgs e)
        {
            this.update();
            
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            List<TextBox> tb = new List<TextBox>() { this.no_pendaftaran, this.nama_kursus, this.biaya_kursus, this.biaya_fasilitas, this.total_pembayaran };
            List<ComboBox> cb = new List<ComboBox>() { this.jenis_kursus, this.beberapa_hari };
            foreach (TextBox x in tb)
            {
                x.Text = "";
            }
            foreach (ComboBox x in cb)
            {
                x.ResetText();
            }
            foreach (CheckBox x in fasilitas_cb)
            {
                x.Checked = false;
            }
            foreach (KeyValuePair<string, RadioButton> x in this.waktu_rb)
            {
                (x.Value).Checked = false;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Jenis_kursus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string jk = this.jenis_kursus.SelectedItem.ToString();
                this.nama_kursus.Text = this.jenis[jk].nama;
            }
            catch { }
            

        }
    }
}
