using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spin_The_Wheel;
namespace Spin_The_Wheel
{
    public partial class form_intro : Form
    {
        public form_intro()
        {
            InitializeComponent();
        }

        private void form_intro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmain mainform = new frmmain();
            mainform.Show();
        }
    }
}
