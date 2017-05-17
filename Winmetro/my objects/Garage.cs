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
 public   class Garage//класс,хранящий информацию о всех транспортных средствах
    {
        //поля

      public  Vehicle[] all_venicle=new Vehicle[0]; //массив ,содержащий все транспортные средства



        //методы
        public void add_some_venicle(int way, int cost, string type,string color,string name,string spec,string picture)//добавляет транспортных элемент
        {
            Array.Resize(ref all_venicle, all_venicle.Length + 1);
            
            if (type == "car")
            {
                all_venicle[all_venicle.Length - 1] = new Car(way,cost,type,color,name,int.Parse(spec),picture);
            }
            if (type == "lorry")
            {
                all_venicle[all_venicle.Length - 1] = new Lorry(way,cost,type, color, name, spec, picture); 
            }
            if (type == "bicycle")
            {
                all_venicle[all_venicle.Length - 1] = new Bicycle(way,cost,type, color, name, spec, picture); 
            }


        }
        public void dell_some_venicle(int cout)//удаление выбранного элемента
        {


            for (int i=cout;i<all_venicle.Length-1;i++)
            {
                all_venicle[i] = all_venicle[i + 1];

            }
            Array.Resize(ref all_venicle, all_venicle.Length - 1);

            MessageBox.Show("обьект удален!");
        }

        public void show_info(ListBox lb)//
        {
            lb.Items.Clear();

            foreach(Vehicle el in all_venicle)
            {

                lb.Items.Add(el.Info_of_tc());

            }




        }



        public void show_garage(FlowLayoutPanel flpnl,int kuda,ref int cout)//выводит изображения всех гаража
        {
           

            if (kuda==0)//самый первый вывод
            {
                show_part_garage(flpnl, 0);
                
            }

           if (kuda==1)
            {
                cout++;
                show_part_garage(flpnl, cout*6);
                

            }
           if (kuda==-1)
            {
                cout--;
                show_part_garage(flpnl, cout * 6);
                


            }
            

            
        }

        public void show_part_garage(FlowLayoutPanel flpnl, int str_psition)
        {
            
            flpnl.Controls.Clear();
            int x = 0, y = 0;
            for (int i = str_psition; i < Math.Min(str_psition+6, all_venicle.Length); i++)
            {
                PictureBox I = new PictureBox();

                I.Location = new Point(x, y); //Set the PictureBox location to x,y
                x += 160; //Sort horizontally; Increment x by 50
                y += 160; //Sort vertically; Increment y by 50

                I.Image = Image.FromFile(all_venicle[i].picture_way);

                I.Size = new Size(160, 160); //Set the PictureBox Size property to 50,50
                I.SizeMode = PictureBoxSizeMode.StretchImage; //Stretch the image; maximum width and height are 50,50

                flpnl.Controls.Add(I);


            }





        }



        public void Random_gener(Random m)
        {

            string[] type_array = new string[] { "car", "lorry", "bicycle" };
            string[] color_array = new string[] { "green" , "blue","black", "red","yellow" };

            string[] litera = new string[] { "q", "w", "E", "r", "f", "O", "A", "u", "m", "N", "g", "", "a", "i" };
            string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", };


            int cout_objects;//количество гинирируеммых обьектов

            cout_objects = m.Next(3, 15);

            //MessageBox.Show(cout_objects.ToString());
            //cout_objects = 12;



            Array.Resize(ref all_venicle, cout_objects);//подготавливаем наш массив

            for(int i=0;i<cout_objects;i++)
            {
                //генерация пути

                int way_ran = m.Next(-1, 200000);


                //генерация стоимости

                int cost_ran = m.Next(500, 40000);

                //генерация имени
                string name_ran = "";
                for(int o=0;o<m.Next(5,8);o++)
                {
                    int ran=m.Next(0,2);

                    if (ran == 1)
                    {
                        name_ran += litera[m.Next(0, 14)];

                    }
                    else
                    {
                        name_ran += numbers[m.Next(0, 10)];
                    }

                }

                //генерация типа
                string type_ran = type_array[m.Next(0, 3)];

                //генерация цвета
                string color_ran = color_array[m.Next(0, 5)];

                //путь
                string picture_ran=type_ran+color_ran + ".jpg";


                //генерация спец
                string spec_ran;
                if (type_ran == "car")
                {
                    string[] spec_arr = new string[] { "1", "2", "3", "4", "5" };
                    spec_ran = spec_arr[m.Next(0, 5)];

                    all_venicle[i] = new Car(way_ran,cost_ran,type_ran,color_ran,name_ran,int.Parse(spec_ran),picture_ran);

                }
                if (type_ran == "lorry")
                {
                    string[] spec_arr = new string[] { "от 0.5 до 2.5 т.", "от 1.5 до 8 т.", "свыше 8 т." };
                    spec_ran = spec_arr[m.Next(0, 3)];

                    all_venicle[i] = new Lorry(way_ran,cost_ran,type_ran, color_ran, name_ran, spec_ran, picture_ran);
                }
                if (type_ran == "bicycle")
                {
                    string[] spec_arr = new string[] { "детский", "мужской", "женский" };
                    spec_ran = spec_arr[m.Next(0, 3)];

                    all_venicle[i] = new Bicycle(way_ran,cost_ran,type_ran, color_ran, name_ran, spec_ran, picture_ran);

                }

            }








        }




    }
}
