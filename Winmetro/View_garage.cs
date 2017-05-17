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
    public partial class View_garage :  MetroFramework.Forms.MetroForm
    {
        public Form1 f_help;

        Form_all_info ALL;

       public int kuda = 0;

       public int position = 0;

      public  int cout = 0;

        public View_garage()
        {
            InitializeComponent();

        }

        public View_garage(Form1 f)
        {
            
            InitializeComponent();

            f_help = f;

            if (f_help.my_Garage.all_venicle.Length < 7) { metroButton_back.Enabled = false; metroButton_foward.Enabled = false; }
            metroButton_back.Enabled = false;

            f_help.my_Garage.show_garage(flowLayoutPanel1,kuda,ref position);


        }


        //назад
        private void metroButton_back_Click(object sender, EventArgs e)
        {

            metroButton_foward.Enabled = true;
            kuda = -1;
            f_help.my_Garage.show_garage(flowLayoutPanel1, kuda, ref position);
            if (position == 0) metroButton_back.Enabled = false;

        }


        //вперед
        private void metroButton_foward_Click(object sender, EventArgs e)
        {
            metroButton_back.Enabled = true;
            kuda = 1;
            f_help.my_Garage.show_garage(flowLayoutPanel1, kuda, ref position);
            if ((position+1) * 6 >= (f_help.my_Garage.all_venicle.Length)) metroButton_foward.Enabled = false;
            
        }

        //более подробно
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ALL = new Form_all_info(this);
            ALL.ShowDialog();
            Close();
        }
    }
}
