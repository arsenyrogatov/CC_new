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
    public partial class AddPrForm : Form
    {
        public AddPrForm()
        {
            InitializeComponent();
        }

        private void prAdd_button_Click(object sender, EventArgs e)
        {
            if (prDescr_textBox.Text.Length > 0 && prAddr_textBox.Text.Length > 0 &&
                prBegin_dateTimePicker.Value < prEnd_dateTimePicker.Value && prType_comboBox.SelectedIndex != -1 &&
                prDoc_textBox.Text.Length > 0 && prWorker_comboBox.SelectedIndex != -1 && prClient_comboBox.SelectedIndex != -1)
            {
                decimal matPr;
                if (decimal.TryParse(prPrice_textBox.Text, out matPr))
                {
                    var project = new Project(-1, int.Parse(prClient_comboBox.Text.Substring(1).Split(new char[] { ')' })[0]),
                   int.Parse(prWorker_comboBox.Text.Substring(1).Split(new char[] { ')' })[0]),
                    prDescr_textBox.Text, prAddr_textBox.Text, matPr,
                    prBegin_dateTimePicker.Value, prEnd_dateTimePicker.Value, prStatus_comboBox.Text,
                    prType_comboBox.Text, prDoc_textBox.Text
                    );
                    
                    if (project.Add())
                    {
                        MessageBox.Show("Данные обновлены!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Такой договор уже есть в базе!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка в стоимости!");
                }
            }
        }
    }
}
