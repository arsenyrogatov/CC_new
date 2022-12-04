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
    public partial class AddMaterialForm : Form
    {
        public AddMaterialForm()
        {
            InitializeComponent();
        }

        private void matPrice_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void matAdd_button_Click(object sender, EventArgs e)
        {
            if (matName_textBox.Text.Length > 0 && matEd_comboBox.SelectedIndex != -1)
            {
                var mat = new Material(-1, matName_textBox.Text, matEd_comboBox.Text, decimal.Parse(matPrice_textBox.Text.ToString()), 1);

                mat.Add();
                
                    MessageBox.Show("Материал добавлен!");
                    Close();
               
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }
    }
}
