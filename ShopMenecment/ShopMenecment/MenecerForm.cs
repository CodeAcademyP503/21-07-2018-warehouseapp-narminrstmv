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
    public partial class MenecerForm : Form
    {
        public MenecerForm()
        {
            InitializeComponent();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            LoginForm.disform.Show();
        }

        private void MenecerForm_Load(object sender, EventArgs e) 
        {
            // Magazalarda  günluk satış məbləgı üçün Format müdirlərinin razılaşdırdığı plan məbləği
            this.DTWMANAGER.Rows.Add("OBA Xutor 1", "2500");
            this.DTWMANAGER.Rows.Add("OBA Kombinat 1", "2300");
            this.DTWMANAGER.Rows.Add("OBA Mehdiabad 2", "1200");
            this.DTWMANAGER.Rows.Add("OBA Lənkəran 8", "700");
            this.DTWMANAGER.Rows.Add("OBA Gəncə 3", "1000");
            this.DTWMANAGER.Rows.Add("OBA Salyan 4", "500");
            this.DTWMANAGER.Rows.Add("OBA Gənclik 2", "600");
            this.DTWMANAGER.Rows.Add("OBA Xətai 3", "2000");
            this.DTWMANAGER.Rows.Add("OBA Neftcilər 11", "3000");
        }

        private void BTNlogout_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }
    }
}
