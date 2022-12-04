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
    public partial class AddWorkerForm : Form
    {
        public AddWorkerForm()
        {
            InitializeComponent();
            ewBirth_dateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void ewFio_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ewFio_textBox.Text.Length > 0 && ewPas1_maskedTextBox.MaskCompleted
               && ewPas2_maskedTextBox.MaskCompleted
               && ewPhone_maskedTextBox.MaskCompleted && ewMail_textBox.Text.Length > 0)
            {
                var worker = new Worker(-1, ewFio_textBox.Text, int.Parse(ewPas1_maskedTextBox.Text),
                    int.Parse(ewPas2_maskedTextBox.Text), ewBirth_dateTimePicker.Value,
                    ewFem_radioButton.Checked ? 'ж' : 'м', ewJob_textBox.Text, ((int)ewStage_numericUpDown.Value), ewPhone_maskedTextBox.Text,
                    ewMail_textBox.Text);

                if (worker.Add())
                {
                    MessageBox.Show("Сотрудник добавлен!");
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
    }
}
