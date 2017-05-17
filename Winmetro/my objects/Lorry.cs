using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winmetro
{
   public class Lorry:Vehicle//класс грузовик
    {

        //поля
      public  string carring_capasity;//грузоподьемность

      public Lorry(int way,int cost,string type, string color, string name, string carring_capasity, string picture_way)
        {
            this.color = color;
            this.name = name;
            this.type = type;

            this.way = way;
            this.cost = cost;


            this.carring_capasity = carring_capasity;
            this.picture_way = picture_way;


        }
        //методы
        public override string Info_of_tc()
        {

            return ("тип: " + type + " имя: " + name + "  цвет: " + color + " пройденный путь: " + way.ToString() + " стоимость: " + cost.ToString() + " Груз. категория: " + carring_capasity+ " Остав. ресурс= "+How_long());

            
        }

        public override int How_long()
        {
            const int const_engine = 100000;//усредний максимальный ресурс двигателе у грузовиков

            return Math.Abs((const_engine - way) * cost / way);


        }

    }
}
