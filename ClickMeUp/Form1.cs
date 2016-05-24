using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMeUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                srcTimer.Interval = Convert.ToInt16(srcTick.Value.ToString());
                srcTimer.Start();
                srcUrl.Enabled = false;
                startBtn.Enabled = false;
                pauseBtn.Enabled = true;
                stopBtn.Enabled = true;
                srcStatus.Text = "Scansione avviata";
        }

        private void scanUrl(string Url)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
                if(srcBox.Text == "")
                {
                    srcBox.Text = result;
                }
                srcCode.Text = result;
            }catch
            {
                srcTimer.Stop();
                MessageBox.Show("L'indirizzo URL inserito non è valido oppure si è verificato un problema con la tua connessione.\nRicontrolla i dati immessi e riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                pauseBtn.Enabled = false;
                srcUrl.Enabled = true;
                srcStatus.Text = "Scansione non avviata";
            }
            
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            srcTimer.Stop();
            srcUrl.Enabled = true;
            startBtn.Enabled = true;
            stopBtn.Enabled = true;
            pauseBtn.Enabled = false;
            srcStatus.Text = "Scansione in pausa";
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            srcTimer.Stop();
            srcUrl.Enabled = true;
            srcBox.Text = "";
            srcCode.Text = "";
            stopBtn.Enabled = false;
            pauseBtn.Enabled = false;
            startBtn.Enabled = true;
            srcStatus.Text = "Scansione bloccata";
        }

        private void srcTimer_Tick(object sender, EventArgs e)
        {
            scanUrl(srcUrl.Text);
            srcBox.Text.Trim();
            srcCode.Text.Trim();
            if (srcDiff.Checked == true)
            {
                if(srcBox.Text != srcCode.Text)
                {
                    srcTimer.Stop();
                    System.Diagnostics.Process.Start(srcUrl.Text);
                    if (srcBeep.Checked == true)
                    {
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }else
            {
                if (srcBox.Text != srcCode.Text)
                {
                    if (srcBeep.Checked == true)
                    {
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ClickMeUp è un software sviluppato da Daniel Sedmak e rilasciato con licenza MIT.\n\nCopyright (c) 2016 Daniel Sedmak\n\nVuoi visualizzare il sorgente del programma su GitHub?", "Info su ClickMeUp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/dansita/ClickMeUp");
            }
            
        }
    }
}
