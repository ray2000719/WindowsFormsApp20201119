using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace jasondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_GO_Click(object sender, EventArgs e)
        {
            try
            {
                NPC npc = new NPC();

                int a = int.Parse(rtbInput1.Text);
                int b = int.Parse(rtbInput2.Text);
                int c = int.Parse(rtbInput3.Text);
                npc.HP = a;
                npc.MP = b;
                npc.EXP = c;

                string output;

                output = JsonConvert.SerializeObject(npc);

                rtbOutput.Text = output;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                string output = rtbOutput.Text;

                NPC npc = JsonConvert.DeserializeObject<NPC>(output);

                rtbInput1.Text = npc.HP.ToString();
                rtbInput2.Text = npc.MP.ToString();
                rtbInput3.Text = npc.EXP.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
