using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePC
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((new User().checkUser(bunifuTextbox1.text, bunifuTextbox2.text)) != -1)
            {
                WorkForm form = new WorkForm(new User().checkUser(bunifuTextbox1.text, bunifuTextbox2.text));
                form.Show();
                this.Visible = false;
            }
            else
            {
                bunifuTextbox2.text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
            bunifuTextbox2.text = "";
        }
    }
}
