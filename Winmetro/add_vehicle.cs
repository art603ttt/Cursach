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
    public partial class add_vehicle : MetroFramework.Forms.MetroForm
    {
        Form1 help_form;

        public add_vehicle()
        {
            InitializeComponent();
        }

        //доп. конструктор
        public add_vehicle(Form1 f)
        {
            help_form = f;
            InitializeComponent();

            //подготовка формы
            metroComboBox_choose_tc.Items.Add("bicycle");
            metroComboBox_choose_tc.Items.Add("car");
            metroComboBox_choose_tc.Items.Add("lorry");
        }

        //события
        //событие--выбор транспортного средства
        private void metroComboBox_choose_tc_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
