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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            // Mağaza əməkdaşları 
            this.DGWAdmin.Rows.Add("Xəyal", "Qasımov", "Satıcı-kassir", "300", "Kombinat 1", "2300", "500 AZN 3-də 1i");
            //this.DGWAdmin.Rows.Add("Musa", "İsgəndərov", "Baş satıcı", "250", "Mehdiabad 2", "1200", "5% adminden basqa herkese");
            //this.DGWAdmin.Rows.Add("Adil", "Vəliyev", "Adminstrator", "500", "Lənkəran 8", "700", "1%");
        }

        private void BTNLOGOUT_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();

        }

        private void magazaaadi_Click(object sender, EventArgs e)
        {

        }

        private void btnhesabla_Click(object sender, EventArgs e)
        {

        }
    }
}
