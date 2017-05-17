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
    public partial class Form_all_info : MetroFramework.Forms.MetroForm
    {
        View_garage help;
        public Form_all_info()
        {
            InitializeComponent();

        }
        public Form_all_info(View_garage f)
        {
            InitializeComponent();
            help = f;

            help.f_help.my_Garage.show_info(listBox1);

        }

        //закрыть
        private void metroButton_close_Click(object sender, EventArgs e)
        {
           // help.f_help.my_Garage.show_garage(help.flowLayoutPanel1, help.kuda,ref help.position);
            Close();
        }

        //удалить
        private void metroButton_del_Click(object sender, EventArgs e)
        {
            int cout= listBox1.SelectedIndex;//элемент под каким индексом следует удалить

            help.f_help.my_Garage.dell_some_venicle(cout);//удаляем

            help.f_help.my_Garage.show_info(listBox1);//обновляем
        }
    }
}
