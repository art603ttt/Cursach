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

            groupBox_main.Visible = false;
            groupBox_spec.Visible = false;
        }

        //события
        //событие--выбор транспортного средства
        private void metroComboBox_choose_tc_TextChanged(object sender, EventArgs e)
        {
            groupBox_main.Visible = true;
            metroComboBox_choose_tc.Enabled = false;

            metroComboBox_color.Items.Add("green");
            metroComboBox_color.Items.Add("blue");
            metroComboBox_color.Items.Add("black");
            metroComboBox_color.Items.Add("red");
            metroComboBox_color.Items.Add("yellow");
            metroComboBox_color.Items.Add("white");


        }

        //событие-добавить
        private void metroButton_ready_Click(object sender, EventArgs e)
        {
            if (metroComboBox_choose_tc.Text == "bicycle")
            {
                help_form.my_Garage.all_venicle[help_form.my_Garage.all_venicle.Length - 1] = new Bicycle();MessageBox.Show("vel");
            }
            if (metroComboBox_choose_tc.Text == "car")
            {
                help_form.my_Garage.all_venicle[help_form.my_Garage.all_venicle.Length - 1] = new Car(); MessageBox.Show("car");
            }
            if (metroComboBox_choose_tc.Text == "lorry")
            {
                help_form.my_Garage.all_venicle[help_form.my_Garage.all_venicle.Length - 1] = new Lorry(); MessageBox.Show("lorry");
            }
        }
    }
}
