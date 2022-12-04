namespace CC
{
    partial class AddMaterialForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.matPrice_textBox = new System.Windows.Forms.TextBox();
            this.matEd_comboBox = new System.Windows.Forms.ComboBox();
            this.matAdd_button = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.matName_textBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label39.Location = new System.Drawing.Point(74, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(239, 25);
            this.label39.TabIndex = 12;
            this.label39.Text = "ДОБАВИТЬ МАТЕРИАЛ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.matPrice_textBox);
            this.panel4.Controls.Add(this.matEd_comboBox);
            this.panel4.Controls.Add(this.matAdd_button);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.matName_textBox);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(12, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 169);
            this.panel4.TabIndex = 13;
            // 
            // matPrice_textBox
            // 
            this.matPrice_textBox.Location = new System.Drawing.Point(175, 72);
            this.matPrice_textBox.Name = "matPrice_textBox";
            this.matPrice_textBox.Size = new System.Drawing.Size(169, 25);
            this.matPrice_textBox.TabIndex = 36;
            this.matPrice_textBox.Text = "0";
            this.matPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matPrice_textBox_KeyPress);
            // 
            // matEd_comboBox
            // 
            this.matEd_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matEd_comboBox.FormattingEnabled = true;
            this.matEd_comboBox.Items.AddRange(new object[] {
            "кг",
            "шт",
            "рул",
            "куб.м",
            "ку.м"});
            this.matEd_comboBox.Location = new System.Drawing.Point(175, 39);
            this.matEd_comboBox.Name = "matEd_comboBox";
            this.matEd_comboBox.Size = new System.Drawing.Size(207, 25);
            this.matEd_comboBox.TabIndex = 35;
            // 
            // matAdd_button
            // 
            this.matAdd_button.AutoSize = true;
            this.matAdd_button.Location = new System.Drawing.Point(54, 113);
            this.matAdd_button.Name = "matAdd_button";
            this.matAdd_button.Size = new System.Drawing.Size(303, 27);
            this.matAdd_button.TabIndex = 34;
            this.matAdd_button.Text = "Добавить материал";
            this.matAdd_button.UseVisualStyleBackColor = true;
            this.matAdd_button.Click += new System.EventHandler(this.matAdd_button_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(6, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 18);
            this.label33.TabIndex = 27;
            this.label33.Text = "Стоимость";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(350, 78);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(30, 17);
            this.label32.TabIndex = 26;
            this.label32.Text = "руб";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(6, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(163, 18);
            this.label25.TabIndex = 6;
            this.label25.Text = "Единицы измерения";
            // 
            // matName_textBox
            // 
            this.matName_textBox.Location = new System.Drawing.Point(175, 10);
            this.matName_textBox.Name = "matName_textBox";
            this.matName_textBox.Size = new System.Drawing.Size(207, 25);
            this.matName_textBox.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(6, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 18);
            this.label24.TabIndex = 4;
            this.label24.Text = "Название";
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(426, 240);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label39);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "AddMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMaterialForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox matPrice_textBox;
        private System.Windows.Forms.Button matAdd_button;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox matName_textBox;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox matEd_comboBox;
    }
}