namespace Winmetro
{
    partial class Form_all_info
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
            this.metroButton_close = new MetroFramework.Controls.MetroButton();
            this.metroButton_del = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // metroButton_close
            // 
            this.metroButton_close.Location = new System.Drawing.Point(573, 361);
            this.metroButton_close.Name = "metroButton_close";
            this.metroButton_close.Size = new System.Drawing.Size(113, 63);
            this.metroButton_close.TabIndex = 0;
            this.metroButton_close.Text = "Выход";
            this.metroButton_close.Click += new System.EventHandler(this.metroButton_close_Click);
            // 
            // metroButton_del
            // 
            this.metroButton_del.Location = new System.Drawing.Point(23, 361);
            this.metroButton_del.Name = "metroButton_del";
            this.metroButton_del.Size = new System.Drawing.Size(114, 63);
            this.metroButton_del.TabIndex = 1;
            this.metroButton_del.Text = "Удалить";
            this.metroButton_del.Click += new System.EventHandler(this.metroButton_del_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 212);
            this.listBox1.TabIndex = 2;
            // 
            // Form_all_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 447);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroButton_del);
            this.Controls.Add(this.metroButton_close);
            this.Name = "Form_all_info";
            this.Text = "Более подробно";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_close;
        private MetroFramework.Controls.MetroButton metroButton_del;
        private System.Windows.Forms.ListBox listBox1;
    }
}