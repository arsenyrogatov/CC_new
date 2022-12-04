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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
            ecBirth_dateTimePicker.MaxDate= DateTime.Now.AddYears(-18);
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            if (ecFio_textBox.Text.Length > 0 && ecPas1_maskedTextBox.MaskCompleted
               && ecPas2_maskedTextBox.MaskCompleted
               && ecPhone_maskedTextBox.MaskCompleted && ecMail_textBox.Text.Length > 0)
            {
                var client = new Client( -1 , ecFio_textBox.Text, int.Parse(ecPas1_maskedTextBox.Text),
                    int.Parse(ecPas2_maskedTextBox.Text), ecBirth_dateTimePicker.Value,
                    ecFem_radioButton.Checked ? 'ж' : 'м', ecPhone_maskedTextBox.Text,
                    ecMail_textBox.Text);
               
                if (client.Add())
                {
                    MessageBox.Show("Заказчик добавлен!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Такие данные уже существуют!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void ewFio_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
