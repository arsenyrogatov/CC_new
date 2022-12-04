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
    public partial class AddSupForm : Form
    {
        public AddSupForm()
        {
            InitializeComponent();
        }

        private void supAdd_button_Click(object sender, EventArgs e)
        {
            if (supName_textBox.Text.Length > 0 && supComp_textBox.Text.Length > 0 &&
                supAddr_textBox.Text.Length > 0 && supPhone_maskedTextBox.MaskCompleted &&
                supMail_textBox.Text.Length > 0)
            {
                var supplier = new Supplier(-1, supName_textBox.Text,
                    supComp_textBox.Text, supAddr_textBox.Text,
                    supPhone_maskedTextBox.Text, supMail_textBox.Text);

                supplier.Add();
                MessageBox.Show("Данные добавлены!");
                Close();
            }
        }
    }
}
