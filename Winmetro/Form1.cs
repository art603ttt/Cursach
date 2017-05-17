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
       public Garage my_Garage;
       public add_vehicle form_add;
       public View_garage form_view;


        public Form1()
        {
            InitializeComponent();

            metroTile_auto.Visible = false;
            metroTile_hand.Visible = false;

            my_Garage = new Garage();
        }



        //События
        //событие-добавить тс
        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroTile_auto.Visible = true;
            metroTile_hand.Visible = true;
           // metroTile1.Enabled = false;
           // metroTile2.Enabled = false;


        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //событие-ручное добавление т.с
        private void metroTile_hand_Click(object sender, EventArgs e)//Дальше -- в форму add_vehicle
        {
             form_add = new add_vehicle(this);  //инициализируем форму добавления тс
             form_add.ShowDialog();             //открываем форму

        }


        //событие - автоматическое заполнение 
        private void metroTile_auto_Click(object sender, EventArgs e)
        {
            Random m=new Random();
            my_Garage.Random_gener(m);

            MessageBox.Show("Гараж сгенерирован!");
        }

        //событие -просмотр гаража
        private void metroTile2_Click(object sender, EventArgs e)//дальше в форму View_garage
        {
            form_view = new View_garage(this);
            form_view.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
