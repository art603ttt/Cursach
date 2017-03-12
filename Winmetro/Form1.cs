using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winmetro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Garage my_Garage;
        add_vehicle form_add;


        public Form1()
        {
            InitializeComponent();
        }



        //События
        private void metroTile1_Click(object sender, EventArgs e)//Дальше -- в форму add_vehicle
        {
           form_add = new add_vehicle(this);  //инициализируем форму добавления тс
           form_add.ShowDialog();             //открываем форму
        }
    }
}
