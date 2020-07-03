using System;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class createUser : UserControl
    {
        public createUser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    if (radioButton1.Checked)
                    {
                        ConnectionBD.ExecuteNonQuery($"INSERT INTO APPUSER (fullname, username, password, userType) " +
                                                     $"VALUES ('{textBox1.Text}', " +
                                                     $"'{textBox2.Text}', '{textBox3.Text}' ,'{true}')");

                        MessageBox.Show("Se registro un administrador exitosamente");

                    }
                    else
                    {
                        ConnectionBD.ExecuteNonQuery($"INSERT INTO APPUSER (fullname, username, password, userType) " +
                                                     $"VALUES ('{textBox1.Text}', " +
                                                     $"'{textBox2.Text}', '{textBox3.Text}' ,'{false}')");

                        MessageBox.Show("Se registro un usuario exitosamente");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
    }
}