namespace Winmetro
{
    partial class add_vehicle
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_choose_tc = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox_color = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.groupBox_spec = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel_specif = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton_ready = new MetroFramework.Controls.MetroButton();
            this.groupBox_main.SuspendLayout();
            this.groupBox_spec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "тип транспортного средства";
            // 
            // metroComboBox_choose_tc
            // 
            this.metroComboBox_choose_tc.FormattingEnabled = true;
            this.metroComboBox_choose_tc.ItemHeight = 23;
            this.metroComboBox_choose_tc.Location = new System.Drawing.Point(226, 93);
            this.metroComboBox_choose_tc.Name = "metroComboBox_choose_tc";
            this.metroComboBox_choose_tc.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_choose_tc.TabIndex = 1;
            this.metroComboBox_choose_tc.TextChanged += new System.EventHandler(this.metroComboBox_choose_tc_TextChanged);
            // 
            // metroComboBox_color
            // 
            this.metroComboBox_color.FormattingEnabled = true;
            this.metroComboBox_color.ItemHeight = 23;
            this.metroComboBox_color.Location = new System.Drawing.Point(119, 30);
            this.metroComboBox_color.Name = "metroComboBox_color";
            this.metroComboBox_color.Size = new System.Drawing.Size(79, 29);
            this.metroComboBox_color.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "цвет:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "название:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(119, 67);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(79, 23);
            this.metroTextBox1.TabIndex = 7;
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.metroComboBox_color);
            this.groupBox_main.Controls.Add(this.metroTextBox1);
            this.groupBox_main.Controls.Add(this.metroLabel2);
            this.groupBox_main.Controls.Add(this.metroLabel3);
            this.groupBox_main.Location = new System.Drawing.Point(34, 149);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(223, 115);
            this.groupBox_main.TabIndex = 8;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "Основная информация";
            // 
            // groupBox_spec
            // 
            this.groupBox_spec.Controls.Add(this.metroComboBox1);
            this.groupBox_spec.Controls.Add(this.metroLabel_specif);
            this.groupBox_spec.Location = new System.Drawing.Point(34, 290);
            this.groupBox_spec.Name = "groupBox_spec";
            this.groupBox_spec.Size = new System.Drawing.Size(223, 100);
            this.groupBox_spec.TabIndex = 9;
            this.groupBox_spec.TabStop = false;
            this.groupBox_spec.Text = "Классовые спецификации";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(118, 34);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(78, 29);
            this.metroComboBox1.TabIndex = 1;
            // 
            // metroLabel_specif
            // 
            this.metroLabel_specif.AutoSize = true;
            this.metroLabel_specif.Location = new System.Drawing.Point(6, 44);
            this.metroLabel_specif.Name = "metroLabel_specif";
            this.metroLabel_specif.Size = new System.Drawing.Size(99, 19);
            this.metroLabel_specif.TabIndex = 0;
            this.metroLabel_specif.Text = "<<наз спец>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winmetro.Properties.Resources.чч;
            this.pictureBox1.Location = new System.Drawing.Point(337, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton_ready
            // 
            this.metroButton_ready.Location = new System.Drawing.Point(320, 334);
            this.metroButton_ready.Name = "metroButton_ready";
            this.metroButton_ready.Size = new System.Drawing.Size(153, 45);
            this.metroButton_ready.TabIndex = 11;
            this.metroButton_ready.Text = "Готово!";
            this.metroButton_ready.Click += new System.EventHandler(this.metroButton_ready_Click);
            // 
            // add_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.metroButton_ready);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_spec);
            this.Controls.Add(this.groupBox_main);
            this.Controls.Add(this.metroComboBox_choose_tc);
            this.Controls.Add(this.metroLabel1);
            this.Name = "add_vehicle";
            this.Text = "Добавить трансортное средство";
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.groupBox_spec.ResumeLayout(false);
            this.groupBox_spec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox_choose_tc;
        private MetroFramework.Controls.MetroComboBox metroComboBox_color;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.GroupBox groupBox_spec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton_ready;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel_specif;
    }
}