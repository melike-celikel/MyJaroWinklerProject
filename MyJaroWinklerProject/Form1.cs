using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJaroWinklerProject
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
        private void txtekle1_Click(object sender, EventArgs e)
        {
            if (txtList1.Text.Trim() != "" && !listBox1.Items.Contains(txtList1.Text))
            {
                listBox1.Items.Add(txtList1.Text);
            }
        }

        private void txtekle2_Click(object sender, EventArgs e)
        {
            if (txtList2.Text.Trim() != "" && !listBox2.Items.Contains(txtList2.Text))
            {
                listBox2.Items.Add(txtList2.Text);
            }
        }

        private void txtsil1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void txtsil2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            double jarowinklerpuan;
            double jaropuan;
            double jarowinklermesafesi;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                myJaroWinkler1.Metin1 = listBox1.Items[i].ToString();
                for (int j = 0; j < listBox2.Items.Count; j++)
                {

                    myJaroWinkler1.Metin2 = listBox2.Items[j].ToString();
                    jarowinklerpuan = myJaroWinkler1.JaroWinklerPuan;
                    jaropuan = myJaroWinkler1.JaroPuan;
                    jarowinklermesafesi = myJaroWinkler1.JarowinklerMesafesi;
                    listBox3.Items.Add(String.Format("{0,-15} {1,-15} Jaro:{2,6:F2}  JaroWinkler:{3,6:F2}  JaroWinklerMesafesi:{4,6:F2}", listBox1.Items[i], listBox2.Items[j], jaropuan, jarowinklerpuan, jarowinklermesafesi));
                    
                }

            }
        }

       
    }
}
