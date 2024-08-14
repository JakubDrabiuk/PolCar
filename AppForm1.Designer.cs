namespace PolCar_WinForms
{
    partial class AppForm1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RolaOpisValue_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RolaValue_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pracownik_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.New_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 364);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RolaOpisValue_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RolaValue_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Pracownik_comboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 65);
            this.panel1.TabIndex = 3;
            // 
            // RolaOpisValue_label
            // 
            this.RolaOpisValue_label.AutoSize = true;
            this.RolaOpisValue_label.Location = new System.Drawing.Point(419, 18);
            this.RolaOpisValue_label.Name = "RolaOpisValue_label";
            this.RolaOpisValue_label.Size = new System.Drawing.Size(84, 16);
            this.RolaOpisValue_label.TabIndex = 5;
            this.RolaOpisValue_label.Text = "{Rola:Value}";
            this.RolaOpisValue_label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis:";
            // 
            // RolaValue_label
            // 
            this.RolaValue_label.AutoSize = true;
            this.RolaValue_label.Location = new System.Drawing.Point(268, 18);
            this.RolaValue_label.Name = "RolaValue_label";
            this.RolaValue_label.Size = new System.Drawing.Size(84, 16);
            this.RolaValue_label.TabIndex = 3;
            this.RolaValue_label.Text = "{Rola:Value}";
            this.RolaValue_label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rola:";
            // 
            // Pracownik_comboBox
            // 
            this.Pracownik_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pracownik_comboBox.FormattingEnabled = true;
            this.Pracownik_comboBox.Location = new System.Drawing.Point(81, 18);
            this.Pracownik_comboBox.Name = "Pracownik_comboBox";
            this.Pracownik_comboBox.Size = new System.Drawing.Size(136, 24);
            this.Pracownik_comboBox.TabIndex = 1;
            this.Pracownik_comboBox.SelectedIndexChanged += new System.EventHandler(this.Pracownik_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pracownik:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Edit_btn);
            this.panel2.Controls.Add(this.New_btn);
            this.panel2.Controls.Add(this.delete_btn);
            this.panel2.Controls.Add(this.Close_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 79);
            this.panel2.TabIndex = 4;
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(765, 18);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(111, 49);
            this.Edit_btn.TabIndex = 3;
            this.Edit_btn.Text = "Podglad/Edytuj";
            this.Edit_btn.UseVisualStyleBackColor = true;
            // 
            // New_btn
            // 
            this.New_btn.Location = new System.Drawing.Point(882, 18);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(89, 49);
            this.New_btn.TabIndex = 2;
            this.New_btn.Text = "Dodaj";
            this.New_btn.UseVisualStyleBackColor = true;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(566, 18);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(89, 49);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Usuń";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(15, 18);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(89, 49);
            this.Close_btn.TabIndex = 0;
            this.Close_btn.Text = "Zamknij";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // AppForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppForm1";
            this.Text = "AppForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RolaOpisValue_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RolaValue_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Pracownik_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button New_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}