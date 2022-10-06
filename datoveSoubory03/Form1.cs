using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datoveSoubory03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("celaCisla.dat", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            int max = br.ReadInt32();
            int min = br.ReadInt32();
            int pozice = 0;
            listBox1.Items.Clear();
            while(br.BaseStream.Position < br.BaseStream.Length)
            {
                int x = br.ReadInt32();
                listBox1.Items.Add(x);
                if(x > max)
                {
                    pozice = x;
                    max = x;
                }
            }
        }
    }
}
