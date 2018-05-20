using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace MakePC
{
    public partial class NewOrder : Form
    {
        List<MB> mb = new MB().selectMB();
        List<CPU> cpu = new CPU().selectCPU();
        List<RAM> ram = new RAM().selectRAM();
        List<GPU> gpu = new GPU().selectGPU();
        List<CS> cs = new CS().selectCS();
        List<PB> pb = new PB().selectPB();
        List<CC> cc = new CC().selectCC();
        List<HDD> hdd = new HDD().selectHDD();
        List<Client> client = new Client().selectClient();
        List<PC> pc = new PC().selectPC();
        List<Service> service = new Service().selectService();
        int total = 0;
        
        public NewOrder()
        {
            InitializeComponent();
            bunifuTileButton1.Enabled = false;
            for (int i = 0; i < pc.Count; i++)
                comboBox1.Items.Add(pc[i].name);
            for (int i = 0; i < mb.Count; i++)
                comboBox2.Items.Add(mb[i].p1);
            for (int i = 0; i < cpu.Count; i++)
                comboBox3.Items.Add(cpu[i].p1);
            for (int i = 0; i < ram.Count; i++)
                comboBox4.Items.Add(ram[i].p1);
            for (int i = 0; i < cs.Count; i++)
                comboBox5.Items.Add(cs[i].p1);
            for (int i = 0; i < hdd.Count; i++)
                comboBox6.Items.Add(hdd[i].p1);
            for (int i = 0; i < gpu.Count; i++)
                comboBox7.Items.Add(gpu[i].p1);
            for (int i = 0; i < pb.Count; i++)
                comboBox8.Items.Add(pb[i].p1);
            for (int i = 0; i < cc.Count; i++)
                comboBox9.Items.Add(cc[i].p1);
            for (int i = 0; i < service.Count; i++)
                comboBox10.Items.Add(service[i].name);
            for (int i = 0; i < client.Count; i++)
                comboBox11.Items.Add(client[i].Fio);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i=0; i<bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox1.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < pc.Count; i++)
                {
                    if (pc[i].name.Equals(comboBox1.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count)+1, pc[i].name, 1, pc[i].cost, pc[i].cost);
                        total = total + Convert.ToInt32(pc[i].cost);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox2.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < mb.Count; i++)
                {
                    if (mb[i].p1.Equals(comboBox2.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, mb[i].p1, 1, mb[i].p9, mb[i].p9);
                        total = total + Convert.ToInt32(mb[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox3.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < cpu.Count; i++)
                {
                    if (cpu[i].p1.Equals(comboBox3.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, cpu[i].p1, 1, cpu[i].p9, cpu[i].p9);
                        total = total + Convert.ToInt32(cpu[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox4.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < ram.Count; i++)
                {
                    if (ram[i].p1.Equals(comboBox4.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, ram[i].p1, 1, ram[i].p9, ram[i].p9);
                        total = total + Convert.ToInt32(ram[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox5.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < cs.Count; i++)
                {
                    if (cs[i].p1.Equals(comboBox5.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, cs[i].p1, 1, cs[i].p9, cs[i].p9);
                        total = total + Convert.ToInt32(cs[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox6.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < hdd.Count; i++)
                {
                    if (hdd[i].p1.Equals(comboBox6.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, hdd[i].p1, 1, hdd[i].p9, hdd[i].p9);
                        total = total + Convert.ToInt32(hdd[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox7.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < gpu.Count; i++)
                {
                    if (gpu[i].p1.Equals(comboBox7.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, gpu[i].p1, 1, gpu[i].p9, gpu[i].p9);
                        total = total + Convert.ToInt32(gpu[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox8.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < pb.Count; i++)
                {
                    if (pb[i].p1.Equals(comboBox8.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, pb[i].p1, 1, pb[i].p9, pb[i].p9);
                        total = total + Convert.ToInt32(pb[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox9.Text))
                {
                    bunifuCustomDataGrid1.Rows[i].Cells[4].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value) + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    bunifuCustomDataGrid1.Rows[i].Cells[2].Value = Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[2].Value) + 1;
                    index++;
                    total = total + Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
                    label14.Text = Convert.ToString(total) + " руб.";
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < cc.Count; i++)
                {
                    if (cc[i].p1.Equals(comboBox9.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, cc[i].p1, 1, cc[i].p9, cc[i].p9);
                        total = total + Convert.ToInt32(cc[i].p9);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.Equals(comboBox10.Text))
                {
                    index++;
                }
            }
            if (index == 0)
            {
                for (int i = 0; i < service.Count; i++)
                {
                    if (service[i].name.Equals(comboBox10.Text))
                    {
                        bunifuCustomDataGrid1.Rows.Add(Convert.ToInt32(bunifuCustomDataGrid1.Rows.Count) + 1, service[i].name, 1, service[i].cost, service[i].cost);
                        total = total + Convert.ToInt32(service[i].cost);
                        label14.Text = Convert.ToString(total) + " руб.";
                    }
                }
            }
            else
            {
            }
        }

        private void bunifuCustomDataGrid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bunifuTileButton1.Enabled = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            int orderCount = new Order().selectOrderCount();
            orderCount++;
            new Order().insertOrder(comboBox11.Text, DateTime.Now.Date.ToShortDateString(), "order_№_" + orderCount + ".pdf", label14.Text);
            string[] res = label14.Text.Split(' ');
            int number = Convert.ToInt32(res[0]);
            int[] array_int = new int[4];
            string[,] array_string = new string[4, 3] {{" миллиард", " миллиарда", " миллиардов"},
                {" миллион", " миллиона", " миллионов"},
                {" тысяча", " тысячи", " тысяч"},
                {"", "", ""}};
            array_int[0] = (number - (number % 1000000000)) / 1000000000;
            array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
            array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
            array_int[3] = number % 1000;
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                if (array_int[i] != 0)
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))
                        {
                            case 1: result += " сто"; break;
                            case 2: result += " двести"; break;
                            case 3: result += " триста"; break;
                            case 4: result += " четыреста"; break;
                            case 5: result += " пятьсот"; break;
                            case 6: result += " шестьсот"; break;
                            case 7: result += " семьсот"; break;
                            case 8: result += " восемьсот"; break;
                            case 9: result += " девятьсот"; break;
                        }
                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                        {
                            case 2: result += " двадцать"; break;
                            case 3: result += " тридцать"; break;
                            case 4: result += " сорок"; break;
                            case 5: result += " пятьдесят"; break;
                            case 6: result += " шестьдесят"; break;
                            case 7: result += " семьдесят"; break;
                            case 8: result += " восемьдесят"; break;
                            case 9: result += " девяносто"; break;
                        }
                    }
                    switch (array_int[i] % 10)
                    {
                        case 1: if (i == 2) result += " одна"; else result += " один"; break;
                        case 2: if (i == 2) result += " две"; else result += " два"; break;
                        case 3: result += " три"; break;
                        case 4: result += " четыре"; break;
                        case 5: result += " пять"; break;
                        case 6: result += " шесть"; break;
                        case 7: result += " семь"; break;
                        case 8: result += " восемь"; break;
                        case 9: result += " девять"; break;
                    }
                }
                else switch (array_int[i] % 100)
                    {
                        case 10: result += " десять"; break;
                        case 11: result += " одиннадцать"; break;
                        case 12: result += " двенадцать"; break;
                        case 13: result += " тринадцать"; break;
                        case 14: result += " четырнадцать"; break;
                        case 15: result += " пятнадцать"; break;
                        case 16: result += " шестнадцать"; break;
                        case 17: result += " семнадцать"; break;
                        case 18: result += " восемннадцать"; break;
                        case 19: result += " девятнадцать"; break;
                    }
                if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result += " " + array_string[i, 2] + " ";
                else switch (array_int[i] % 10)
                    {
                        case 1: result += " " + array_string[i, 0] + " "; break;
                        case 2:
                        case 3:
                        case 4: result += " " + array_string[i, 1] + " "; break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: result += " " + array_string[i, 2] + " "; break;
                    }
            }
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Width = 1754;
            page.Height = 1240;
           XGraphics gfx = XGraphics.FromPdfPage(page);
            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
            XFont font = new XFont("Courier New", 60, XFontStyle.Bold, options);
            XFont font1 = new XFont("Courier New", 46, XFontStyle.Bold, options);
            XFont font2 = new XFont("Courier New", 40, XFontStyle.Bold, options);
            XFont font3 = new XFont("Courier New", 20, XFontStyle.Bold, options);
            XFont font4 = new XFont("Courier New", 26, XFontStyle.Italic, options);
            gfx.DrawString("ООО \"MakePC\"", font2, XBrushes.Black, new XRect(0, -570, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("г. Новосибирск, ул. Мира, 100", font2, XBrushes.Black, new XRect(0, -510, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("Накладная № " + orderCount, font, XBrushes.Black, new XRect(0, -450, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("от " + DateTime.Now.Date.ToShortDateString(), font1, XBrushes.Black, new XRect(0, -390, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("№", font3, XBrushes.Black, new XRect(50, 300, 0, 0), XStringFormats.Default);
            gfx.DrawString("Наименование", font3, XBrushes.Black, new XRect(150, 300, 0, 0), XStringFormats.Default);
            gfx.DrawString("Кол.", font3, XBrushes.Black, new XRect(1000, 300, 0, 0), XStringFormats.Default);
            gfx.DrawString("Стоимость за ед.", font3, XBrushes.Black, new XRect(1150, 300, 0, 0), XStringFormats.Default);
            gfx.DrawString("Общая стоимость", font3, XBrushes.Black, new XRect(1500, 300, 0, 0), XStringFormats.Default);
            int row = 340;
            for (int i=0; i<bunifuCustomDataGrid1.Rows.Count; i++)
            {
                gfx.DrawString(Convert.ToString(bunifuCustomDataGrid1.Rows[i].Cells[0].Value), font3, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
                gfx.DrawString(Convert.ToString(bunifuCustomDataGrid1.Rows[i].Cells[1].Value), font3, XBrushes.Black, new XRect(150, row, 0, 0), XStringFormats.Default);
                gfx.DrawString(Convert.ToString(bunifuCustomDataGrid1.Rows[i].Cells[2].Value), font3, XBrushes.Black, new XRect(1000, row, 0, 0), XStringFormats.Default);
                gfx.DrawString(Convert.ToString(bunifuCustomDataGrid1.Rows[i].Cells[3].Value), font3, XBrushes.Black, new XRect(1150, row, 0, 0), XStringFormats.Default);
                gfx.DrawString(Convert.ToString(bunifuCustomDataGrid1.Rows[i].Cells[4].Value), font3, XBrushes.Black, new XRect(1500, row, 0, 0), XStringFormats.Default);
                row = row + 40;
            }
            row = row + 30;
            gfx.DrawString("Всего на сумму " + label14.Text, font2, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 50;
            gfx.DrawString(result.Remove(0, 1) + " руб.", font2, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 50;
            string s1 = "Подписью на данной накладной Покупатель подтверждает, что надлежащим образом и в полном объеме проверил";
            string s2 = "комплектацию, качество, внешний вид, маркировку, эксплуатационную документацию полученного товара и";
            string s3 = "подтверждает, что не имеет никаких претензий к полученному товару, в том числе касательно его комплектации,";
            string s4 = "надлежащего качества, внешнего вида, маркировки, эксплуатационной документации.";
            gfx.DrawString(s1, font4, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 30;
            gfx.DrawString(s2, font4, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 30;
            gfx.DrawString(s3, font4, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 30;
            gfx.DrawString(s4, font4, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            row = row + 80;
            gfx.DrawString("Товар выдал ___________________", font2, XBrushes.Black, new XRect(50, row, 0, 0), XStringFormats.Default);
            gfx.DrawString("Товар принял ___________________", font2, XBrushes.Black, new XRect(900, row, 0, 0), XStringFormats.Default);
            row = row + 40;
            gfx.DrawString(comboBox11.Text, font3, XBrushes.Black, new XRect(1300, row, 0, 0), XStringFormats.Default);
            string filename = "Orders/order_№_" + orderCount + ".pdf";
            document.Save(filename);
            Process.Start(".\\Orders\\order_№_" + orderCount + ".pdf");
            this.Close();
        }
    }
}
