namespace Winmetro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile_hand = new MetroFramework.Controls.MetroTile();
            this.metroTile_auto = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 102);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 70);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Add vehicle";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(23, 210);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(93, 70);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "View Garage";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile_hand
            // 
            this.metroTile_hand.BackColor = System.Drawing.Color.White;
            this.metroTile_hand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile_hand.Location = new System.Drawing.Point(150, 102);
            this.metroTile_hand.Name = "metroTile_hand";
            this.metroTile_hand.Size = new System.Drawing.Size(93, 70);
            this.metroTile_hand.TabIndex = 3;
            this.metroTile_hand.Text = "hand";
            this.metroTile_hand.Click += new System.EventHandler(this.metroTile_hand_Click);
            // 
            // metroTile_auto
            // 
            this.metroTile_auto.Location = new System.Drawing.Point(150, 210);
            this.metroTile_auto.Name = "metroTile_auto";
            this.metroTile_auto.Size = new System.Drawing.Size(93, 70);
            this.metroTile_auto.TabIndex = 4;
            this.metroTile_auto.Text = "auto";
            this.metroTile_auto.Click += new System.EventHandler(this.metroTile_auto_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(486, 345);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(93, 51);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Выход";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 419);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile_auto);
            this.Controls.Add(this.metroTile_hand);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Text = "Курсовой проект";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile_hand;
        private MetroFramework.Controls.MetroTile metroTile_auto;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

