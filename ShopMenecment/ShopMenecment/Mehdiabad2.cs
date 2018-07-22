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
    public partial class Mehdiabad2 : Form
    {
        public Mehdiabad2()
        {
            InitializeComponent();
        }

        private void BTNLOGOUT_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }
    }
}
