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

        bool color_change = false;
        bool name_change = false;
        bool cost_chenge = false;
        bool way_change = false;

        string pictureway;

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
            metroButton_ready.Enabled = false;
        }
/////////////////////////////////////////////////
/////////////////////////////////////////////////
        //события
        //событие--выбор транспортного средства
        private void metroComboBox_choose_tc_TextChanged(object sender, EventArgs e)
        {
            groupBox_main.Visible = true;
            metroComboBox_choose_tc.Enabled = false;


            metroComboBox_color.Items.Clear();
            metroComboBox_color.Items.Add("green");
            metroComboBox_color.Items.Add("blue");
            metroComboBox_color.Items.Add("black");
            metroComboBox_color.Items.Add("red");
            metroComboBox_color.Items.Add("yellow");
           


        }    
        //событие - ввод названия тс
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            name_change = true;
            if (color_change && name_change && cost_chenge && way_change) groupBox_spec.Visible = true;
            specif_form_gener();
            

        }

        //событие- ввод цвета тс
        private void metroComboBox_color_TextChanged(object sender, EventArgs e)
        {
            color_change = true;
            if (color_change && name_change&&cost_chenge&&way_change) groupBox_spec.Visible = true;
            specif_form_gener();//редактир форму
            gener_picture_way();//генерируем адрес изображения
            pictureBox1.Image = Image.FromFile(pictureway);//подгружаем изображение
            
        }
        //событие -ввод стоимости
        private void metrotextbox_cost_TextChanged(object sender, EventArgs e)
        {
            cost_chenge = true;
            if (color_change && name_change && cost_chenge && way_change) groupBox_spec.Visible = true;
            specif_form_gener();

           
        }

        //событие -ввод пройденного пути
        private void metroTextBox_way_TextChanged(object sender, EventArgs e)
        {

            way_change = true;
            if (color_change && name_change && cost_chenge && way_change) groupBox_spec.Visible = true;
            specif_form_gener();
            
        }
        //событие- ввод спец поля
        private void metroComboBox_specif_TextChanged(object sender, EventArgs e)
        {
            metroButton_ready.Enabled = true;
        }

        //событие-добавить
        private void metroButton_ready_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(metroTextBox_way.Text) < 0) throw new Exception("Пройденный путь не может быть меньше 0");
                if (int.Parse(metrotextbox_cost.Text) <= 0) throw new Exception("Стоимость не может быть меньше или равной 0");

                help_form.my_Garage.add_some_venicle(int.Parse(metroTextBox_way.Text), int.Parse(metrotextbox_cost.Text), metroComboBox_choose_tc.Text, metroComboBox_color.Text, metroTextBox1.Text, metroComboBox_specif.Text, pictureway);
                MessageBox.Show("Транспорт добавлен в гараж!");
                Close();
            }
            catch(OverflowException)
            {

                MessageBox.Show("переполнение!");
            }
            catch(FormatException)
            {
                MessageBox.Show("вы ввели неправельный формат данных" , "Внимание!!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Внимание!!");


            }

        }



        /////////////////////////////////////////////////
        /////////////////////////////////////////////////


        //методы
        void specif_form_gener()//подготовка элементов формы-спец поля тс
        {

            if (metroComboBox_choose_tc.Text == "bicycle")
            {
                //подготовка формы для заполнения спец. полей
                metroLabel_specif.Text = "тип велосипеда";
                metroComboBox_specif.Items.Clear();
                metroComboBox_specif.Items.Add("детский");
                metroComboBox_specif.Items.Add("мужской");
                metroComboBox_specif.Items.Add("женский");
            }
            if (metroComboBox_choose_tc.Text == "car")
            {
                //подготовка формы для заполнения спец. полей
                metroLabel_specif.Text = "уровень безопасности";
                metroComboBox_specif.Items.Clear();
                metroComboBox_specif.Items.Add("1");
                metroComboBox_specif.Items.Add("2");
                metroComboBox_specif.Items.Add("3");
                metroComboBox_specif.Items.Add("4");
                metroComboBox_specif.Items.Add("5");

            }
            if (metroComboBox_choose_tc.Text == "lorry")
            {
                //подготовка формы для заполнения спец. полей
                metroLabel_specif.Text = "грузоподьемность";
                metroComboBox_specif.Items.Clear();
                metroComboBox_specif.Items.Add("от 0.5 до 2.5 т.");
                metroComboBox_specif.Items.Add("от 1.5 до 8 т.");
                metroComboBox_specif.Items.Add("свыше 8 т.");
            }


        }
        void gener_picture_way()//генерирует путь к изображению тс
        {

            pictureway = metroComboBox_choose_tc.Text + metroComboBox_color.Text + ".jpg";

        }

        
    }
}
