using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMenecment
{
    public partial class Xutor1 : Form
    {
        public Xutor1()
        {
            InitializeComponent();
        }

        private void Xutor1_Load(object sender, EventArgs e)
        {

        }

      

        private void BTNLOGOUT_Click_1(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }
    }
}
