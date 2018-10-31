using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowQNH
{
    public partial class Form1 : Form
    {
        Form2 impostazioni = new Form2();

        public string icaoDaCercare { get; set; }

        public Form1(string search)
        {
            InitializeComponent();
            textBox1.Text = search;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOrario.Text = DateTime.Now.ToUniversalTime().ToString("HH:mm:ss");
        }

        private void lblFixedQNH_Click(object sender, EventArgs e)
        {
            this.Hide();
            impostazioni.Show();
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            String downloadedString = client.DownloadString("http://wx.ivao.aero/metar.php");

            List<string> metars = new List<string>();
            metars = downloadedString.Split('\n').ToList();
           
            this.icaoDaCercare = textBox1.Text;

            for (int i = 0; i < metars.Count() - 1; i++)
            {
                if (metars[i].Substring(0, 4) == icaoDaCercare)
                {
                    string metarTrovato = metars[i];
                    List<string> metarScelto = new List<string>();
                    metarScelto = metarTrovato.Split(' ').ToList();
                    string qnh = "1000";
                    for (int k = 0; k < metarScelto.Count(); k++)
                    {
                        if (metarScelto[k].Contains('Q'))
                        {
                            qnh = metarScelto[k];
                            qnh = qnh.Substring(1);
                            break;
                        }
                        else qnh = "N/F";
                    }
                    lblQNH.Text = qnh;
                    break;
                }
                else
                {
                    lblQNH.Text = "N/F";
                }
            }
            int qnh_locale = Int32.Parse(lblQNH.Text);
            string transition_altitude = "6000";
            if (transition_altitude == "5000")
            {
                if (qnh_locale < 977) lblTransition.Text = "75";
                if (qnh_locale >= 977 && qnh_locale < 995) lblTransition.Text = "70";
                if (qnh_locale >= 995 && qnh_locale < 1013) lblTransition.Text = "65";
                if (qnh_locale >= 1013) lblTransition.Text = "60";
            }
            else
            {
                if (qnh_locale < 977) lblTransition.Text = "85";
                if (qnh_locale >= 977 && qnh_locale < 995) lblTransition.Text = "80";
                if (qnh_locale >= 995 && qnh_locale < 1013) lblTransition.Text = "75";
                if (qnh_locale >= 1013) lblTransition.Text = "70";
            }
            
        }

        private void refreshQNH_Tick(object sender, EventArgs e)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            String downloadedString = client.DownloadString("http://wx.ivao.aero/metar.php");

            List<string> metars = new List<string>();
            metars = downloadedString.Split('\n').ToList();

            this.icaoDaCercare = textBox1.Text;

            for (int i = 0; i < metars.Count() - 1; i++)
            {
                if (metars[i].Substring(0, 4) == icaoDaCercare)
                {
                    string metarTrovato = metars[i];
                    List<string> metarScelto = new List<string>();
                    metarScelto = metarTrovato.Split(' ').ToList();
                    string qnh = "1000";
                    for (int k = 0; k < metarScelto.Count(); k++)
                    {
                        if (metarScelto[k].Contains('Q'))
                        {
                            qnh = metarScelto[k];
                            qnh = qnh.Substring(1);
                            break;
                        }
                        else qnh = "N/F";
                    }
                    lblQNH.Text = qnh;
                    break;
                }
                else
                {
                    lblQNH.Text = "N/F";
                }
            }
        }

    }
}
