using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winmetro
{
 public   class Garage//класс,хранящий информацию о всех транспортных средствах
    {
        //поля

      public  Vehicle[] all_venicle=new Vehicle[50]; //массив ,содержащий все транспортные средства



        //методы
        public void add_some_venicle()//добавляет транспортных элемент
        {
            Array.Resize(ref all_venicle, all_venicle.Length + 1);

            all_venicle[all_venicle.Length - 1] = new Car();

            Array.Resize(ref all_venicle, all_venicle.Length + 1);

            all_venicle[all_venicle.Length - 1] = new Bicycle();


        }
        public void show_garage()//выводит все элементы гаража
        { }




    }
}
