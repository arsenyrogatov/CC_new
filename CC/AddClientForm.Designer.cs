namespace CC
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label39 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addClient_button = new System.Windows.Forms.Button();
            this.ecBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ecPas2_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ecPas1_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ecPhone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ecFem_radioButton = new System.Windows.Forms.RadioButton();
            this.ecMale_radioButton = new System.Windows.Forms.RadioButton();
            this.ecMail_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ecFio_textBox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label39.Location = new System.Drawing.Point(86, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(250, 25);
            this.label39.TabIndex = 11;
            this.label39.Text = "ДОБАВИТЬ ЗАКАЗЧИКА";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addClient_button);
            this.panel3.Controls.Add(this.ecBirth_dateTimePicker);
            this.panel3.Controls.Add(this.ecPas2_maskedTextBox);
            this.panel3.Controls.Add(this.ecPas1_maskedTextBox);
            this.panel3.Controls.Add(this.ecPhone_maskedTextBox);
            this.panel3.Controls.Add(this.ecFem_radioButton);
            this.panel3.Controls.Add(this.ecMale_radioButton);
            this.panel3.Controls.Add(this.ecMail_textBox);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.ecFio_textBox);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Location = new System.Drawing.Point(12, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 297);
            this.panel3.TabIndex = 12;
            // 
            // addClient_button
            // 
            this.addClient_button.AutoSize = true;
            this.addClient_button.Location = new System.Drawing.Point(58, 248);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(303, 27);
            this.addClient_button.TabIndex = 31;
            this.addClient_button.Text = "Добавить заказчика";
            this.addClient_button.UseVisualStyleBackColor = true;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // ecBirth_dateTimePicker
            // 
            this.ecBirth_dateTimePicker.Location = new System.Drawing.Point(162, 103);
            this.ecBirth_dateTimePicker.Name = "ecBirth_dateTimePicker";
            this.ecBirth_dateTimePicker.Size = new System.Drawing.Size(238, 25);
            this.ecBirth_dateTimePicker.TabIndex = 28;
            // 
            // ecPas2_maskedTextBox
            // 
            this.ecPas2_maskedTextBox.Location = new System.Drawing.Point(162, 71);
            this.ecPas2_maskedTextBox.Mask = "000000";
            this.ecPas2_maskedTextBox.Name = "ecPas2_maskedTextBox";
            this.ecPas2_maskedTextBox.Size = new System.Drawing.Size(238, 25);
            this.ecPas2_maskedTextBox.TabIndex = 27;
            // 
            // ecPas1_maskedTextBox
            // 
            this.ecPas1_maskedTextBox.Location = new System.Drawing.Point(162, 40);
            this.ecPas1_maskedTextBox.Mask = "0000";
            this.ecPas1_maskedTextBox.Name = "ecPas1_maskedTextBox";
            this.ecPas1_maskedTextBox.Size = new System.Drawing.Size(238, 25);
            this.ecPas1_maskedTextBox.TabIndex = 26;
            // 
            // ecPhone_maskedTextBox
            // 
            this.ecPhone_maskedTextBox.Location = new System.Drawing.Point(162, 162);
            this.ecPhone_maskedTextBox.Mask = "+0 (999) 000-00-00";
            this.ecPhone_maskedTextBox.Name = "ecPhone_maskedTextBox";
            this.ecPhone_maskedTextBox.Size = new System.Drawing.Size(238, 25);
            this.ecPhone_maskedTextBox.TabIndex = 22;
            // 
            // ecFem_radioButton
            // 
            this.ecFem_radioButton.AutoSize = true;
            this.ecFem_radioButton.Location = new System.Drawing.Point(315, 135);
            this.ecFem_radioButton.Name = "ecFem_radioButton";
            this.ecFem_radioButton.Size = new System.Drawing.Size(77, 21);
            this.ecFem_radioButton.TabIndex = 21;
            this.ecFem_radioButton.Text = "Женский";
            this.ecFem_radioButton.UseVisualStyleBackColor = true;
            // 
            // ecMale_radioButton
            // 
            this.ecMale_radioButton.AutoSize = true;
            this.ecMale_radioButton.Checked = true;
            this.ecMale_radioButton.Location = new System.Drawing.Point(162, 135);
            this.ecMale_radioButton.Name = "ecMale_radioButton";
            this.ecMale_radioButton.Size = new System.Drawing.Size(80, 21);
            this.ecMale_radioButton.TabIndex = 20;
            this.ecMale_radioButton.TabStop = true;
            this.ecMale_radioButton.Text = "Мужской";
            this.ecMale_radioButton.UseVisualStyleBackColor = true;
            // 
            // ecMail_textBox
            // 
            this.ecMail_textBox.Location = new System.Drawing.Point(162, 194);
            this.ecMail_textBox.Name = "ecMail_textBox";
            this.ecMail_textBox.Size = new System.Drawing.Size(238, 25);
            this.ecMail_textBox.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(4, 200);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 18);
            this.label22.TabIndex = 18;
            this.label22.Text = "Почта";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(4, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 18);
            this.label23.TabIndex = 16;
            this.label23.Text = "Телефон";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(4, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 18);
            this.label26.TabIndex = 10;
            this.label26.Text = "Пол";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.Location = new System.Drawing.Point(4, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 18);
            this.label27.TabIndex = 8;
            this.label27.Text = "Дата рождения";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label28.Location = new System.Drawing.Point(4, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(140, 18);
            this.label28.TabIndex = 6;
            this.label28.Text = "Номер паспорта";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label29.Location = new System.Drawing.Point(4, 46);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(137, 18);
            this.label29.TabIndex = 4;
            this.label29.Text = "Серия паспорта";
            // 
            // ecFio_textBox
            // 
            this.ecFio_textBox.Location = new System.Drawing.Point(114, 9);
            this.ecFio_textBox.Name = "ecFio_textBox";
            this.ecFio_textBox.Size = new System.Drawing.Size(286, 25);
            this.ecFio_textBox.TabIndex = 3;
            this.ecFio_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ewFio_textBox_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label30.Location = new System.Drawing.Point(4, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 18);
            this.label30.TabIndex = 2;
            this.label30.Text = "ФИО";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label39);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказчика";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.DateTimePicker ecBirth_dateTimePicker;
        private System.Windows.Forms.MaskedTextBox ecPas2_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox ecPas1_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox ecPhone_maskedTextBox;
        private System.Windows.Forms.RadioButton ecFem_radioButton;
        private System.Windows.Forms.RadioButton ecMale_radioButton;
        private System.Windows.Forms.TextBox ecMail_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox ecFio_textBox;
        private System.Windows.Forms.Label label30;
    }
}