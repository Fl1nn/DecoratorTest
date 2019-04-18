using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.ConreteComponent
{
    public class TomatoPizza : IPizza
    {
        private string TomatoPizzaInfor = "C:\\Users\\Lin\\source\\repos\\DecoratorDemo\\DecoratorDemo\\bin\\Debug\\Resources\\tomato.jpg";

        //thuc thi phuong thuc
        public List<string> doPizza()
        {
            return  new List<string>() { TomatoPizzaInfor } ;
        }
    }
}
