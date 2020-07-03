using System;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class LoginVig : Form
    {
        public LoginVig()
        {
            InitializeComponent();
        }

        public void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password";
            comboBox1.DisplayMember = "username";
            comboBox1.DataSource = UserData.getLista();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           Usser use = (Usser)comboBox1.SelectedItem;
                       
                       try
                       {
                           if (comboBox1.SelectedValue.Equals(textBox1.Text))
                           {
                               if (use.UserType is false)
                               {
                                   User user = new User();
                                   user.Show();
                                   Hide();
                               }
                               
                           }
                           else
                           {
                               MessageBox.Show("Contraseña incorrecta");
                           }
           
                       }catch(Exception ex)
                       {
                           MessageBox.Show("Ha ocurrido un error");
                       }
        }
        private void Form1_Load(object sender, EventArgs e)
                {
                    poblarControles();
                }


        
    }
}