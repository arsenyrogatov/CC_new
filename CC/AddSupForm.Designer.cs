namespace CC
{
    partial class AddSupForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.supComp_textBox = new System.Windows.Forms.TextBox();
            this.supAddr_textBox = new System.Windows.Forms.TextBox();
            this.supAdd_button = new System.Windows.Forms.Button();
            this.supPhone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.supMail_textBox = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.supName_textBox = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label39.Location = new System.Drawing.Point(59, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(277, 25);
            this.label39.TabIndex = 13;
            this.label39.Text = "ДОБАВИТЬ ПОСТАВЩИКА";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.supComp_textBox);
            this.panel6.Controls.Add(this.supAddr_textBox);
            this.panel6.Controls.Add(this.supAdd_button);
            this.panel6.Controls.Add(this.supPhone_maskedTextBox);
            this.panel6.Controls.Add(this.supMail_textBox);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.label46);
            this.panel6.Controls.Add(this.label50);
            this.panel6.Controls.Add(this.label51);
            this.panel6.Controls.Add(this.supName_textBox);
            this.panel6.Controls.Add(this.label52);
            this.panel6.Location = new System.Drawing.Point(12, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(352, 222);
            this.panel6.TabIndex = 14;
            // 
            // supComp_textBox
            // 
            this.supComp_textBox.Location = new System.Drawing.Point(101, 49);
            this.supComp_textBox.Name = "supComp_textBox";
            this.supComp_textBox.Size = new System.Drawing.Size(234, 25);
            this.supComp_textBox.TabIndex = 33;
            // 
            // supAddr_textBox
            // 
            this.supAddr_textBox.Location = new System.Drawing.Point(101, 78);
            this.supAddr_textBox.Name = "supAddr_textBox";
            this.supAddr_textBox.Size = new System.Drawing.Size(234, 25);
            this.supAddr_textBox.TabIndex = 32;
            // 
            // supAdd_button
            // 
            this.supAdd_button.AutoSize = true;
            this.supAdd_button.Location = new System.Drawing.Point(20, 172);
            this.supAdd_button.Name = "supAdd_button";
            this.supAdd_button.Size = new System.Drawing.Size(303, 27);
            this.supAdd_button.TabIndex = 31;
            this.supAdd_button.Text = "Добавить поставщика";
            this.supAdd_button.UseVisualStyleBackColor = true;
            this.supAdd_button.Click += new System.EventHandler(this.supAdd_button_Click);
            // 
            // supPhone_maskedTextBox
            // 
            this.supPhone_maskedTextBox.Location = new System.Drawing.Point(101, 110);
            this.supPhone_maskedTextBox.Mask = "+0 (999) 000-00-00";
            this.supPhone_maskedTextBox.Name = "supPhone_maskedTextBox";
            this.supPhone_maskedTextBox.Size = new System.Drawing.Size(234, 25);
            this.supPhone_maskedTextBox.TabIndex = 22;
            this.supPhone_maskedTextBox.Text = "79357636118";
            // 
            // supMail_textBox
            // 
            this.supMail_textBox.Location = new System.Drawing.Point(101, 141);
            this.supMail_textBox.Name = "supMail_textBox";
            this.supMail_textBox.Size = new System.Drawing.Size(234, 25);
            this.supMail_textBox.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label42.Location = new System.Drawing.Point(3, 142);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 18);
            this.label42.TabIndex = 18;
            this.label42.Text = "Почта";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label46.Location = new System.Drawing.Point(3, 114);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(76, 18);
            this.label46.TabIndex = 16;
            this.label46.Text = "Телефон";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label50.Location = new System.Drawing.Point(3, 83);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 18);
            this.label50.TabIndex = 6;
            this.label50.Text = "Адрес";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label51.Location = new System.Drawing.Point(3, 52);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 18);
            this.label51.TabIndex = 4;
            this.label51.Text = "Фирма";
            // 
            // supName_textBox
            // 
            this.supName_textBox.Location = new System.Drawing.Point(80, 16);
            this.supName_textBox.Name = "supName_textBox";
            this.supName_textBox.Size = new System.Drawing.Size(255, 25);
            this.supName_textBox.TabIndex = 3;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label52.Location = new System.Drawing.Point(3, 21);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(42, 18);
            this.label52.TabIndex = 2;
            this.label52.Text = "ФИО";
            // 
            // AddSupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(387, 297);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label39);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "AddSupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSupForm";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox supComp_textBox;
        private System.Windows.Forms.TextBox supAddr_textBox;
        private System.Windows.Forms.Button supAdd_button;
        private System.Windows.Forms.MaskedTextBox supPhone_maskedTextBox;
        private System.Windows.Forms.TextBox supMail_textBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox supName_textBox;
        private System.Windows.Forms.Label label52;
    }
}