using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winmetro
{
  public  abstract class Vehicle  //абстрактный класс - транспортное средство
    {
        //поля
      public  string type;        //тип тс
       public string color;       //цвет 
      public  string name;        //название

      public  string picture_way; //расположение файла-изображения, соответ. данному экземпляру
        


       public int way=0;            //пройденный путь
       public int cost=0;           //цена 

        
      public  virtual  string Info_of_tc()//вывод информации
        {
            return null;
        }

        public virtual int How_long()//метод высчитывающий ресурс транс средства
        {
            return 0;

        }

    }
}
