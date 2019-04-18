using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.ConreteComponent
{
    class ChickenPizza:IPizza
    {
        private string chickenPizzaInfor = "C:\\Users\\Lin\\source\\repos\\DecoratorDemo\\DecoratorDemo\\bin\\Debug\\Resources\\pizzachicken.jpg";

        //thuc thi phuong thuc
        public List<string> doPizza()
        {
            return new List<string>() {chickenPizzaInfor };
        }
    }
}
