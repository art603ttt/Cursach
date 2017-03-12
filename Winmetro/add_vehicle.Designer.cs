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
            // add_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 386);
            this.Controls.Add(this.metroComboBox_choose_tc);
            this.Controls.Add(this.metroLabel1);
            this.Name = "add_vehicle";
            this.Text = "Добавить трансортное средство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox_choose_tc;
    }
}