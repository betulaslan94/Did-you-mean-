using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Did_you_mean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int kelimebul(string kelime)
        {
            using (var streamReader = File.OpenText(@"C:\Users\betul\Desktop\words.txt"))
            {
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string metin = kelime.Trim().ToUpper().Soundex();
                System.Collections.ArrayList alist = new System.Collections.ArrayList();
                foreach (var line in lines)
                {
                    if (line.Trim().Soundex() == metin)
                    {
                        alist.Add(line);
                    }
                }
                if (alist.Count != 0)
                {
                    label1.Text = "Bunu mu demek istediniz ?";
                    for (int i = 0; i < alist.Count; i++)
                    {

                        listBox1.Items.Add(alist[i].ToString());
                    }
                    return 1;
                }
                else
                {
                    MessageBox.Show("Aradığınız kritere uygun bir sonuç bulunamadı.String bir değer girdiğinizden emin olun.");
                    return 0;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
                kelimebul(textBox1.Text);
        }
        }
    }

