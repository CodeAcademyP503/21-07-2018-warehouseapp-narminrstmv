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
    public partial class LoginForm : Form
    {

        public static Form disform;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string usr = txbusername.Text;
            string psw = txbpassword.Text;
            {
                if (txbusername.Text == "Admin" && txbpassword.Text == "123")
                {
                    this.Hide();
                    disform = this;
                    new AdminForm().Show();
                }
                else
                {
                    if (txbusername.Text == "Manager" && txbpassword.Text == "123")
                    {
                        this.Hide();
                        disform = this;
                        new MenecerForm().Show();
                    }
                    else
                    {
                        if (txbusername.Text == "Xutor1" && txbpassword.Text == "123")
                        {
                            this.Hide();
                            disform = this;
                            new Xutor1().Show();
                        }
                        else
                        {
                            if (txbusername.Text == "Mehdiabad2" && txbpassword.Text == "123")
                            {
                                this.Hide();
                                disform = this;
                                new Mehdiabad2().Show();
                            }


                            else
                            {
                                MessageBox.Show("Wrong Id or Password!!");
                            }





                        }
                    }

                }
            }

        }
    }
    }

