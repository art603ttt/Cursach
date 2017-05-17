using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winmetro
{
   public class Bicycle:Vehicle//класс велосипед
    {//поля
     public   string type_bcl;//тип велосипеда(детский,мужской,женский)



       public Bicycle(int way, int cost, string type,string color, string name,string type_bcl,string picture_way)
        {
            this.color = color;
            this.name = name;
            this.type = type;

            this.way = way;
            this.cost = cost;

            this.type_bcl = type_bcl;
            this.picture_way = picture_way;


        }

        public override string Info_of_tc()
        {

            return ("тип: " + type + " имя: " + name + "  цвет: " + color + "  пройденный путь: " + way.ToString() + "  стоимость: " + cost.ToString() + "  тип велосипеда: " + type_bcl+ " Остав. ресурс= " + How_long());


        }
        public override int How_long()
        {

            if (type_bcl == "детский")
                return ( cost-way)/10;
            else
                return (cost-way )/5;

        }
    }
}
