using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex != -1 && pwd_maskedTextBox.Text.Length > 0)
            {
                int pwd;
                if (!int.TryParse(pwd_maskedTextBox.Text, out pwd))
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
                else if (!CurrentWorker.Login(comboBox.Text, pwd))
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
                else
                {
                    WorkerForm workerForm = new WorkerForm();
                    workerForm.FormClosed += (object se, FormClosedEventArgs ee) => { Visible = true; };
                    Visible = false;
                    pwd_maskedTextBox.Clear();
                    workerForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
