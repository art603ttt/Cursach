namespace Winmetro
{
    partial class View_garage
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton_back = new MetroFramework.Controls.MetroButton();
            this.metroButton_foward = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(534, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 40);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Подробнее..";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(505, 331);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroButton_back
            // 
            this.metroButton_back.Location = new System.Drawing.Point(114, 407);
            this.metroButton_back.Name = "metroButton_back";
            this.metroButton_back.Size = new System.Drawing.Size(75, 23);
            this.metroButton_back.TabIndex = 3;
            this.metroButton_back.Text = "Назад";
            this.metroButton_back.Click += new System.EventHandler(this.metroButton_back_Click);
            // 
            // metroButton_foward
            // 
            this.metroButton_foward.Location = new System.Drawing.Point(344, 407);
            this.metroButton_foward.Name = "metroButton_foward";
            this.metroButton_foward.Size = new System.Drawing.Size(75, 23);
            this.metroButton_foward.TabIndex = 4;
            this.metroButton_foward.Text = "Дальше";
            this.metroButton_foward.Click += new System.EventHandler(this.metroButton_foward_Click);
            // 
            // View_garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 453);
            this.Controls.Add(this.metroButton_foward);
            this.Controls.Add(this.metroButton_back);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "View_garage";
            this.Text = "Просмотр гаража";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton_back;
        private MetroFramework.Controls.MetroButton metroButton_foward;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}