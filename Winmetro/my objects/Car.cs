using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winmetro
{
   public class Car:Vehicle//класс  легковая машина
    {
        //поля
       public int lvl_safety;//уровень безопастности
       
        //методы

      public  Car(int way, int cost, string type, string color, string name, int lvl_safety, string picture_way)
        {
            this.color = color;
            this.name = name;
            this.type = type;

            this.way = way;
            this.cost = cost;

            this.lvl_safety = lvl_safety;
            this.picture_way = picture_way;


        }

        public override string Info_of_tc()
        {

            return ("тип: " + type + " имя: " + name + "  цвет: " + color + "  пройденный путь: " + way.ToString() + "  стоимость: " + cost.ToString() + "  уровень безопаст:" + lvl_safety.ToString() + "Остав.ресурс=" + How_long());


        }
        public override int How_long()
        {
            return( (lvl_safety * cost) / (int)Math.Sqrt(way))*10;



        }
    }
}
