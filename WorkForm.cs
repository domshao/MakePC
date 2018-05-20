using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MakePC
{
    public partial class WorkForm : Form
    {
        int id;
        int[,] p = new int[8,9];
        List<MB> mb = new List<MB>();
        List<CPU> cpu = new List<CPU>();
        List<RAM> ram = new List<RAM>();
        List<GPU> gpu = new List<GPU>();
        List<CS> cs = new List<CS>();
        List<PB> pb = new List<PB>();
        List<CC> cc = new List<CC>();
        List<HDD> hdd = new List<HDD>();
        List<Client> client = new List<Client>();
        List<Order> order = new List<Order>();
        MB oneMB = new MB();
        int c1, c2, c3, c4, c5, c6, c7, c8;
        int id1, id2, id3, id4, id5, id6, id7, id8;

        public WorkForm(int id)
        {
            this.id = id;
            InitializeComponent();
            bunifuCircleProgressbar1.LabelVisible = true;
            bunifuCircleProgressbar2.LabelVisible = true;
            bunifuCircleProgressbar3.LabelVisible = true;
            bunifuCircleProgressbar4.LabelVisible = true;
            bunifuCircleProgressbar5.LabelVisible = true;
            bunifuCircleProgressbar6.LabelVisible = true;
            bunifuCircleProgressbar7.LabelVisible = true;
            bunifuCircleProgressbar8.LabelVisible = true;
            client = new Client().selectClient();
        }

        private void видеокартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void процессорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void материнскаяПлатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void оперативнаяПамятьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void системаОхлажденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void блокПитанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void жесткийДискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void корпусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void собратьПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = 0;
            mb = new MB().selectMB();
            for (int i = 0; i < mb.Count; i++)
                comboBox1.Items.Add(mb[i].p1);
            cpu = new CPU().selectCPU();
            ram = new RAM().selectRAM();
            gpu = new GPU().selectGPU();
            for (int i = 0; i < gpu.Count; i++)
                comboBox7.Items.Add(gpu[i].p1);
            cs = new CS().selectCS();
            cc = new CC().selectCC();
            hdd = new HDD().selectHDD();
            for (int i = 0; i < hdd.Count; i++)
                comboBox6.Items.Add(hdd[i].p1);
            pb = new PB().selectPB();
            for (int i = 0; i < pb.Count; i++)
                comboBox5.Items.Add(pb[i].p1);
            label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
        }

        private void добавитьУслугуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
            bunifuCustomDataGrid1.Rows.Clear();
            for (int i = 0; i < client.Count; i++)
            {
                bunifuCustomDataGrid1.Rows.Add(client[i].Fio, client[i].Telephone, client[i].Email, client[i].Adres);
            }    
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 0] == 0)
            {
                p[0, 0] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 1] == 0)
            {
                p[0, 1] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 2] == 0)
            {
                p[0, 2] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 3] == 0)
            {
                p[0, 3] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 4] == 0)
            {
                p[0, 4] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 5] == 0)
            {
                p[0, 5] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 6] == 0)
            {
                p[0, 6] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 7] == 0)
            {
                p[0, 7] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (p[0, 8] == 0)
            {
                p[0, 8] = 1;
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 11;
            }
        }

        private void bunifuCircleProgressbar1_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value == 99)
            {
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 1;
                bunifuTileButton1.Enabled = true;
            }
        }

        private void оформитьНовыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrder form = new NewOrder();
            form.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            new GPU().insertGPU(textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text,
                textBox13.Text, textBox14.Text, textBox15.Text, Convert.ToInt32(textBox16.Text));
            textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text =
                textBox13.Text = textBox14.Text = textBox15.Text = textBox16.Text = "";
            for (int i = 0; i < 9; i++)
                p[0, i] = 0;
            bunifuCircleProgressbar1.Value = 0;
            bunifuTileButton1.Enabled = false;
        }


        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 0] == 0)
            {
                p[1, 0] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 1] == 0)
            {
                p[1, 1] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 2] == 0)
            {
                p[1, 2] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 3] == 0)
            {
                p[1, 3] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 4] == 0)
            {
                p[1, 4] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 5] == 0)
            {
                p[1, 5] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 6] == 0)
            {
                p[1, 6] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 7] == 0)
            {
                p[1, 7] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (p[1, 8] == 0)
            {
                p[1, 8] = 1;
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 11;
            }
        }

        private void bunifuCircleProgressbar2_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar2.Value == 99)
            {
                bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 1;
                bunifuTileButton2.Enabled = true;
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            new CPU().insertCPU(textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text, textBox21.Text,
                textBox22.Text, textBox23.Text, textBox24.Text, Convert.ToInt32(textBox25.Text));
            textBox17.Text = textBox18.Text = textBox19.Text = textBox20.Text = textBox21.Text =
                textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = "";
            for (int i = 0; i < 9; i++)
                p[1, i] = 0;
            bunifuCircleProgressbar2.Value = 0;
            bunifuTileButton2.Enabled = false;
        }


        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 0] == 0)
            {
                p[2, 0] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 1] == 0)
            {
                p[2, 1] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 2] == 0)
            {
                p[2, 2] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 3] == 0)
            {
                p[2, 3] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 4] == 0)
            {
                p[2, 4] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 5] == 0)
            {
                p[2, 5] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 6] == 0)
            {
                p[2, 6] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 7] == 0)
            {
                p[2, 7] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (p[2, 8] == 0)
            {
                p[2, 8] = 1;
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 11;
            }
        }

        private void bunifuCircleProgressbar3_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar3.Value == 99)
            {
                bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 1;
                bunifuTileButton3.Enabled = true;
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            new MB().insertMB(textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text, textBox30.Text,
                textBox31.Text, textBox32.Text, textBox33.Text, Convert.ToInt32(textBox34.Text));
            textBox26.Text = textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text =
                textBox31.Text = textBox32.Text = textBox33.Text = textBox34.Text = "";
            for (int i = 0; i < 9; i++)
                p[2, i] = 0;
            bunifuCircleProgressbar3.Value = 0;
            bunifuTileButton3.Enabled = false;
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 0] == 0)
            {
                p[3, 0] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 1] == 0)
            {
                p[3, 1] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 2] == 0)
            {
                p[3, 2] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 3] == 0)
            {
                p[3, 3] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 4] == 0)
            {
                p[3, 4] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 5] == 0)
            {
                p[3, 5] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 6] == 0)
            {
                p[3, 6] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 7] == 0)
            {
                p[3, 7] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (p[3, 8] == 0)
            {
                p[3, 8] = 1;
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 11;
            }
        }

        private void bunifuCircleProgressbar4_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar4.Value == 99)
            {
                bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 1;
                bunifuTileButton4.Enabled = true;
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            new RAM().insertRAM(textBox35.Text, textBox36.Text, textBox37.Text, textBox38.Text, textBox39.Text,
                textBox40.Text, textBox41.Text, textBox42.Text, Convert.ToInt32(textBox43.Text));
            textBox35.Text = textBox36.Text = textBox37.Text = textBox38.Text = textBox39.Text =
                textBox40.Text = textBox41.Text = textBox42.Text = textBox43.Text = "";
            for (int i = 0; i < 9; i++)
                p[3, i] = 0;
            bunifuCircleProgressbar4.Value = 0;
            bunifuTileButton4.Enabled = false;
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 0] == 0)
            {
                p[4, 0] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 1] == 0)
            {
                p[4, 1] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 2] == 0)
            {
                p[4, 2] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 3] == 0)
            {
                p[4, 3] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 4] == 0)
            {
                p[4, 4] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 5] == 0)
            {
                p[4, 5] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 6] == 0)
            {
                p[4, 6] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 7] == 0)
            {
                p[4, 7] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            if (p[4, 8] == 0)
            {
                p[4, 8] = 1;
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 11;
            }
        }

        private void bunifuCircleProgressbar5_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar5.Value == 99)
            {
                bunifuCircleProgressbar5.Value = bunifuCircleProgressbar5.Value + 1;
                bunifuTileButton5.Enabled = true;
            }
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            new CS().insertCS(textBox44.Text, textBox45.Text, textBox46.Text, textBox47.Text, textBox48.Text,
                textBox49.Text, textBox50.Text, textBox51.Text, Convert.ToInt32(textBox52.Text));
            textBox44.Text = textBox45.Text = textBox46.Text = textBox47.Text = textBox48.Text =
                textBox49.Text = textBox50.Text = textBox51.Text = textBox52.Text = "";
            for (int i = 0; i < 9; i++)
                p[4, i] = 0;
            bunifuCircleProgressbar5.Value = 0;
            bunifuTileButton5.Enabled = false;
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 0] == 0)
            {
                p[5, 0] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 1] == 0)
            {
                p[5, 1] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 2] == 0)
            {
                p[5, 2] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 3] == 0)
            {
                p[5, 3] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 4] == 0)
            {
                p[5, 4] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 5] == 0)
            {
                p[5, 5] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 6] == 0)
            {
                p[5, 6] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 7] == 0)
            {
                p[5, 7] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            if (p[5, 8] == 0)
            {
                p[5, 8] = 1;
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 11;
            }
        }

        private void bunifuCircleProgressbar6_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar6.Value == 99)
            {
                bunifuCircleProgressbar6.Value = bunifuCircleProgressbar6.Value + 1;
                bunifuTileButton6.Enabled = true;
            }
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            new PB().insertPB(textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text, textBox57.Text,
                textBox58.Text, textBox59.Text, textBox60.Text, Convert.ToInt32(textBox61.Text));
            textBox53.Text = textBox54.Text = textBox55.Text = textBox56.Text = textBox57.Text =
                textBox58.Text = textBox59.Text = textBox60.Text = textBox61.Text = "";
            for (int i = 0; i < 9; i++)
                p[5, i] = 0;
            bunifuCircleProgressbar6.Value = 0;
            bunifuTileButton6.Enabled = false;
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 0] == 0)
            {
                p[6, 0] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 1] == 0)
            {
                p[6, 1] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 2] == 0)
            {
                p[6, 2] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 3] == 0)
            {
                p[6, 3] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 4] == 0)
            {
                p[6, 4] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 5] == 0)
            {
                p[6, 5] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 6] == 0)
            {
                p[6, 6] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 7] == 0)
            {
                p[6, 7] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            if (p[6, 8] == 0)
            {
                p[6, 8] = 1;
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 11;
            }
        }

        private void bunifuCircleProgressbar7_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar7.Value == 99)
            {
                bunifuCircleProgressbar7.Value = bunifuCircleProgressbar7.Value + 1;
                bunifuTileButton7.Enabled = true;
            }
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            new HDD().insertHDD(textBox62.Text, textBox63.Text, textBox64.Text, textBox65.Text, textBox66.Text,
                textBox67.Text, textBox68.Text, textBox69.Text, Convert.ToInt32(textBox70.Text));
            textBox62.Text = textBox63.Text = textBox64.Text = textBox65.Text = textBox66.Text =
                textBox67.Text = textBox68.Text = textBox69.Text = textBox70.Text = "";
            for (int i = 0; i < 9; i++)
                p[6, i] = 0;
            bunifuCircleProgressbar7.Value = 0;
            bunifuTileButton7.Enabled = false;
        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 0] == 0)
            {
                p[7, 0] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 1] == 0)
            {
                p[7, 1] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 2] == 0)
            {
                p[7, 2] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 3] == 0)
            {
                p[7, 3] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 4] == 0)
            {
                p[7, 4] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 5] == 0)
            {
                p[7, 5] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 6] == 0)
            {
                p[7, 6] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }


        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 7] == 0)
            {
                p[7, 7] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            if (p[7, 8] == 0)
            {
                p[7, 8] = 1;
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 11;
            }
        }

        private void bunifuCircleProgressbar8_ProgressChanged(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar8.Value == 99)
            {
                bunifuCircleProgressbar8.Value = bunifuCircleProgressbar8.Value + 1;
                bunifuTileButton8.Enabled = true;
            }
        }


        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            new CC().insertCC(textBox71.Text, textBox72.Text, textBox73.Text, textBox74.Text, textBox75.Text,
                textBox76.Text, textBox77.Text, textBox78.Text, Convert.ToInt32(textBox79.Text));
            textBox71.Text = textBox72.Text = textBox73.Text = textBox74.Text = textBox75.Text =
                textBox76.Text = textBox77.Text = textBox78.Text = textBox79.Text = "";
            for (int i = 0; i < 9; i++)
                p[7, i] = 0;
            bunifuCircleProgressbar8.Value = 0;
            bunifuTileButton8.Enabled = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            this.Visible = false;
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oneMB = new MB().selectOneMB(comboBox1.SelectedItem.ToString());
            id1 = oneMB.id;
            c1 = oneMB.p9;
            c2 = 0;
            c3 = 0;
            c4 = 0;
            c8 = 0;
            label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            for (int i = 0; i < cpu.Count; i++)
            {
                if (cpu[i].p2.Equals(oneMB.p2))
                {
                    comboBox2.Items.Add(cpu[i].p1);
                }
            }
            if (comboBox2.Items.Count==0)
                comboBox2.Enabled = false;
            else
                comboBox2.Enabled = true;
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            for (int i = 0; i < ram.Count; i++)
            {
                if (ram[i].p2.Equals(oneMB.p5))
                {
                    comboBox3.Items.Add(ram[i].p1);
                }
            }
            if (comboBox3.Items.Count == 0)
                comboBox3.Enabled = false;
            else
                comboBox3.Enabled = true;
            comboBox4.Items.Clear();
            comboBox4.Text = "";
            for (int i = 0; i < cs.Count; i++)
            {
                if (cs[i].p4.Contains(oneMB.p2))
                {
                    comboBox4.Items.Add(cs[i].p1);
                }
            }
            if (comboBox4.Items.Count == 0)
                comboBox4.Enabled = false;
            else
                comboBox4.Enabled = true;
            comboBox8.Items.Clear();
            comboBox8.Text = "";
            for (int i = 0; i < cc.Count; i++)
            {
                if (oneMB.p7.Contains(cc[i].p2))
                {
                    comboBox8.Items.Add(cc[i].p1);
                }
            }
            if (comboBox8.Items.Count == 0)
                comboBox8.Enabled = false;
            else
                comboBox8.Enabled = true;

            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cpu.Count; i++)
                if (cpu[i].p1.Equals(comboBox2.SelectedItem.ToString()))
                {
                    c2 = cpu[i].p9;
                    id2 = cpu[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }
            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ram.Count; i++)
                if (ram[i].p1.Equals(comboBox3.SelectedItem.ToString()))
                {
                    c3 = ram[i].p9;
                    id3 = ram[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }
            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].p1.Equals(comboBox4.SelectedItem.ToString()))
                {
                    c4 = cs[i].p9;
                    id4 = cs[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }

            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void найтиЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
            order = new Order().selectOrder();
            for (int i = 0; i < order.Count; i++)
            {
                bunifuCustomDataGrid2.Rows.Add(order[i].id, order[i].clientFio, order[i].orderDate, order[i].cost);
            }
        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(".\\Orders\\order_№_" + bunifuCustomDataGrid2.CurrentRow.Cells[0].Value + ".pdf");          
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < pb.Count; i++)
                if (pb[i].p1.Equals(comboBox5.SelectedItem.ToString()))
                {
                    c5 = pb[i].p9;
                    id5 = pb[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }

            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < hdd.Count; i++)
                if (hdd[i].p1.Equals(comboBox6.SelectedItem.ToString()))
                {
                    c6 = hdd[i].p9;
                    id6 = hdd[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }

            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gpu.Count; i++)
                if (gpu[i].p1.Equals(comboBox7.SelectedItem.ToString()))
                {
                    c7 = gpu[i].p9;
                    id7 = gpu[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }

            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cc.Count; i++)
                if (cc[i].p1.Equals(comboBox8.SelectedItem.ToString()))
                {
                    c8 = cc[i].p9;
                    id8 = cc[i].id;
                    label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
                }
            if (!comboBox1.Text.Equals("") & !comboBox2.Text.Equals("") & !comboBox3.Text.Equals("") & !comboBox4.Text.Equals("") & !comboBox5.Text.Equals("") & !comboBox6.Text.Equals("") & !comboBox7.Text.Equals("")
                 & !comboBox8.Text.Equals("") & !textBox1.Text.Equals(""))
                bunifuTileButton9.Enabled = true;
            else
                bunifuTileButton9.Enabled = false;
        }


        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            new PC().insertPC(textBox1.Text,Convert.ToInt32(label2.Text),id1,id2,id3,id4,id5,id6,id7,id8);
            tabControl1.SelectTab(8);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = 0;
            mb = new MB().selectMB();
            for (int i = 0; i < mb.Count; i++)
                comboBox1.Items.Add(mb[i].p1);
            cpu = new CPU().selectCPU();
            ram = new RAM().selectRAM();
            gpu = new GPU().selectGPU();
            for (int i = 0; i < gpu.Count; i++)
                comboBox7.Items.Add(gpu[i].p1);
            cs = new CS().selectCS();
            cc = new CC().selectCC();
            hdd = new HDD().selectHDD();
            for (int i = 0; i < hdd.Count; i++)
                comboBox6.Items.Add(hdd[i].p1);
            pb = new PB().selectPB();
            for (int i = 0; i < pb.Count; i++)
                comboBox5.Items.Add(pb[i].p1);
            label2.Text = Convert.ToString(c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("") & !richTextBox1.Text.Equals("") & !textBox3.Text.Equals(""))
                bunifuTileButton10.Enabled = true;
            else
                bunifuTileButton10.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("") & !richTextBox1.Text.Equals("") & !textBox3.Text.Equals(""))
                bunifuTileButton10.Enabled = true;
            else
                bunifuTileButton10.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("") & !richTextBox1.Text.Equals("") & !textBox3.Text.Equals(""))
                bunifuTileButton10.Enabled = true;
            else
                bunifuTileButton10.Enabled = false;
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            new Service().insertService(textBox2.Text, Convert.ToInt32(textBox3.Text), richTextBox1.Text);
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox3.Text = "";
            bunifuTileButton10.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals("") & !textBox5.Text.Equals("") & !textBox6.Text.Equals("") & !textBox7.Text.Equals(""))
                bunifuTileButton11.Enabled = true;
            else
                bunifuTileButton11.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        if (!textBox4.Text.Equals("") & !textBox5.Text.Equals("") & !textBox6.Text.Equals("") & !textBox7.Text.Equals(""))
            bunifuTileButton11.Enabled = true;
        else
            bunifuTileButton11.Enabled = false;
    }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals("") & !textBox5.Text.Equals("") & !textBox6.Text.Equals("") & !textBox7.Text.Equals(""))
                bunifuTileButton11.Enabled = true;
            else
                bunifuTileButton11.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals("") & !textBox5.Text.Equals("") & !textBox6.Text.Equals("") & !textBox7.Text.Equals(""))
                bunifuTileButton11.Enabled = true;
            else
                bunifuTileButton11.Enabled = false;
        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            new Client().insertClient(textBox4.Text, textBox5.Text, textBox7.Text, textBox6.Text);
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            bunifuTileButton11.Enabled = false;
            client = new Client().selectClient();
            bunifuCustomDataGrid1.Rows.Clear();
            for (int i = 0; i < client.Count; i++)
            {
                bunifuCustomDataGrid1.Rows.Add(client[i].Fio, client[i].Telephone, client[i].Email, client[i].Adres);
            }
        }


    }
}
